using System;

namespace kursova
{
    public class Tree
    {
        private int?[] tree;//масив для дерева  
        private int nMax;//к-ть листківа дерева(з урахуванням null)
        private int count;//к-ть елементів в ряду
        private Function sum_min_max;

        public int Count
        {
            get { return count; }
        }
        public delegate int Function(int a, int b);
        public Tree(int[] input_data, Function sum_min_max)
        {
            if (input_data == null)
                throw new ArgumentNullException("Array of element can't be null");
            if (sum_min_max == null)
                throw new ArgumentNullException("Function can't be null");

            this.sum_min_max = sum_min_max;
            Build_tree(input_data);
        }

        private void Build_tree(int[] input_array)//метод для побудови дерева
        {
            nMax = 1;
            count = input_array.Length;
            while (nMax < count) //шукаемо найменшу більшу за count степінь двійки
                nMax <<= 1;
            tree = new int?[2 * nMax - 1];//масив для дерева
           
            for (int i = 0; i < count; i++)
                tree[nMax - 1 + i] = input_array[i];
            for (int i = nMax - 2; i >= 0; i--)//будуємо дерево вверх
                tree[i] = Apply_sum_min_or_max_func(tree[2 * i + 1], tree[2 * i + 2]);
        }

        private int? Apply_sum_min_or_max_func(int? a, int? b)
        {
            if (b == null)
                return a;
            if (a == null)
                return b;
            return sum_min_max((int)a, (int)b);
        }

        public override string ToString()
        {
            string result = "";
            int nodes_in_row = 1, 
                count_in_row = 0;//змінюється від 0 до nodes_in_row
            for (int i = 0; i < tree.Length; i++)
            {
                result += tree[i] + "  ";
                count_in_row++;
                if (count_in_row == nodes_in_row)
                {
                    nodes_in_row *= 2;
                    result += "\n";
                    count_in_row = 0;
                }
            }
            return result;
        }

        public int this[int n]
        {
            get
            {
                if (n < 0 || n >= count)
                    throw new IndexOutOfRangeException("Wrong index");
                return (int)tree[nMax - 1 + n];
            }
            set
            {
                if (n < 0 || n >= count)
                    throw new IndexOutOfRangeException("Wrong index");
                n = nMax - 1 + n;
                tree[n] = value;
                while (n >= 1)
                {
                    n = (n - 1) / 2;
                    tree[n] = Apply_sum_min_or_max_func(tree[2 * n + 1], tree[2 * n + 2]);
                }
            }
        }
        public int Get_value_on_segment(int l, int r)// 
        {
            if (l < 0 || r < l || r >= count) throw new ArgumentException("wrong argument");
            return (int)get_value_on_segment(l, r, 0, nMax - 1, 1);
        }

        private int? get_value_on_segment(int l, int r, int left_of_head_seg, int right_of_head_seg, int curr_head_seg)
        {
            if (r < l) return null;
            if (l == left_of_head_seg && r == right_of_head_seg)
                return tree[curr_head_seg - 1];
            int midd_curr_seg = (left_of_head_seg + right_of_head_seg) / 2;

            return Apply_sum_min_or_max_func(
                get_value_on_segment(//рекурсивний вхід у ліву частину дерева
                    l,
                    min(midd_curr_seg, r),
                    left_of_head_seg,
                    midd_curr_seg, curr_head_seg * 2),
                get_value_on_segment(//рекурсивний вхід у праву частину дерева
                    max(l, midd_curr_seg + 1),
                    r, midd_curr_seg + 1,
                    right_of_head_seg,
                    curr_head_seg * 2 + 1));
        }
        private int min(int a, int b)
        {
            return (a < b) ? a : b;
        }
        private int max(int a, int b)
        {
            return (a > b) ? a : b;
        }

        public void Delete(int index)
        {
            resize_array(new int[count - 1], index);
        }
        public void Add(int value, int index)
        {
            resize_array(new int[count + 1], index, value, true);//true вказує, що виклик йде від функції Add
        }
        private void resize_array(int[] newArray, int index, int value = 0, bool add_method = false)
        {
            for (int i = 0; i < index; ++i)
                newArray[i] = this[i];
            //умова виконуєть для методу Add і не виконується для Delete
            if (add_method)
            {
                newArray[index] = value;
                for (int i = index + 1; i < count + 1; ++i)
                    newArray[i] = this[i - 1];
            }
            else
                for (int i = index; i < count - 1; ++i)
                    newArray[i] = this[i + 1];
            Build_tree(newArray);
        }
        public void Add(int value)
        {
            Add(value, count);
        }
    }
}