using System;

namespace kursova
{
    public class Tree
    {
        private int?[] tree;//масив для дерева  
        private int nMax;//к-ть листківа дерева(з урахуванням null)
        private int count;//к-ть елементів в ряду
        private Function SumMinMax;
        const int COUNT_CHILD_IN_FATHER = 2;
        public int Count
        {
            get { return count; }
        }
        public delegate int Function(int a, int b);
        public Tree(int[] inputData, Function SumMinMax)
        {
            if (inputData == null)
                throw new ArgumentNullException("Array of element can't be null");
            if (SumMinMax == null)
                throw new ArgumentNullException("Function can't be null");

            this.SumMinMax = SumMinMax;
            BuildTree(inputData);
        }

        private void BuildTree(int[] inputArray)
        {
            nMax = 1;
            count = inputArray.Length;
            while (nMax < count) //шукаемо найменшу більшу за count степінь двійки
                nMax <<= 1;
            tree = new int?[2 * nMax - 1];
           
            for (int i = 0; i < count; i++)
                tree[nMax - 1 + i] = inputArray[i];
            for (int i = nMax - 2; i >= 0; i--)//будуємо дерево вверх
                tree[i] = ApplySumMinOrMaxFunc(tree[2 * i + 1], tree[2 * i + 2]);
        }

        private int? ApplySumMinOrMaxFunc(int? a, int? b)
        {
            if (b == null)
                return a;
            if (a == null)
                return b;
            return SumMinMax((int)a, (int)b);
        }

        public override string ToString()
        {
            string message = "";
            int nodesInRow = 1, 
                countInRow = 0;//змінюється від 0 до nodes_in_row
            for (int i = 0; i < tree.Length; i++)
            {
                message += tree[i] + "  ";
                countInRow++;
                if (countInRow == nodesInRow)
                {
                    nodesInRow *= COUNT_CHILD_IN_FATHER;
                    message += "\n";
                    countInRow = 0;
                }
            }
            return message;
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
                    tree[n] = ApplySumMinOrMaxFunc(tree[2 * n + 1], tree[2 * n + 2]);
                }
            }
        }
        public int GetValueOnSegment(int leftUserRange, int rightUserRange)// 
        {
            if (leftUserRange < 0)
                throw new ArgumentException("wrong argument: left argument less 0");
            if (rightUserRange < leftUserRange)
                throw new ArgumentException("wrong argument: left more right border");
            if (rightUserRange >= count)
                throw new ArgumentException("wrong argument: rigth argument more size of tree");

            return (int)getValueOnSegment(leftUserRange, rightUserRange, 0, nMax - 1, 1);
        }

        private int? getValueOnSegment(int leftUserRange, int rightUserRange, int leftOfHeadSeg, int rightOfHeadSeg, int currHeadSeg)
        {
            if (rightUserRange < leftUserRange) return null;
            if (leftUserRange == leftOfHeadSeg && rightUserRange == rightOfHeadSeg)
                return tree[currHeadSeg - 1];
            int currentSegmentCenter = (leftOfHeadSeg + rightOfHeadSeg) / 2;


            int? left_part = getValueOnSegment(//рекурсивний вхід у ліву частину дерева
                    leftUserRange,
                    min(currentSegmentCenter, rightUserRange),
                    leftOfHeadSeg,
                    currentSegmentCenter, currHeadSeg * 2);
            int? right_part = getValueOnSegment(//рекурсивний вхід у праву частину дерева
                    max(leftUserRange, currentSegmentCenter + 1),
                    rightUserRange, currentSegmentCenter + 1,
                    rightOfHeadSeg,
                    currHeadSeg * 2 + 1);

            return ApplySumMinOrMaxFunc(left_part,right_part);
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
            resizeArray(new int[count - 1], index);
        }
        public void Add(int value, int index)
        {
            resizeArray(new int[count + 1], index, value, true);//true вказує, що виклик йде від функції Add
        }
        private void resizeArray(int[] newArray, int index, int value = 0, bool is_add_method = false)//0, false для метода Delete
        {
            for (int i = 0; i < index; ++i)
                newArray[i] = this[i];
            //умова виконуєть для методу Add і не виконується для Delete
            if (is_add_method)
            {
                newArray[index] = value;
                for (int i = index + 1; i < count + 1; ++i)
                    newArray[i] = this[i - 1];
            }
            else
                for (int i = index; i < count - 1; ++i)
                    newArray[i] = this[i + 1];
            BuildTree(newArray);
        }
        public void Add(int value)//додаємо елемент в кінець
        {
            Add(value, count);
        }
    }
}