using System;
using kursova;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_to_kursova
{
    [TestClass]
    public class SegmentTree
    {

        Tree tree_for_addDel_elem, tree_check_property_COUNT, tree_check_adding_deleting, tree_for_check_sum_of_range;
        int[] test_array;
        const int NON_EXISTING_INDEX_IN_TREE = -1;
        static int Sum(int a, int b) { return a + b; }
        static int Min(int a, int b) { return (a < b ? a : b); }
        static int Max(int a, int b) { return (a > b ? a : b); }

        [TestInitialize]
        public void Initialize()
        {
            tree_check_adding_deleting = new Tree(new int[] { }, (int a, int b) => { return a + b; });


            tree_check_property_COUNT = new Tree(new int[] { 0 }, (int a, int b) => { return a + b; });

            test_array = new int[] { 1, 2, 3 };
            tree_for_addDel_elem = new Tree(test_array, (int a, int b) => { return a + b; });
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Create_tree_with_first_null_arg_Error()
        {
            Tree tree = new Tree(null, (int a, int b) => { return a + b; });
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Create_tree_with_second_null_arg_Error()
        {
            Tree tree = new Tree(new int[] { }, null);
        }


        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void take_value_with_non_existing_index_Error()
        {
            int a = tree_for_addDel_elem[NON_EXISTING_INDEX_IN_TREE];
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Add_elem_with_error_index_Error()
        {
            tree_for_addDel_elem.Add(1, NON_EXISTING_INDEX_IN_TREE);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Delete_elem_with_non_existing_index_Error()
        {
            tree_for_addDel_elem.Delete(NON_EXISTING_INDEX_IN_TREE);
        }

        [TestMethod]
        public void Create_empty_tree_Success()
        {
            Tree tree = new Tree(new int[] { }, Sum);

            Assert.AreEqual(tree.Count, 0);
        }

        [TestMethod]
        public void Add_elem_at_end_Success()
        {
            Tree tree = new Tree(new int[] { 30, 20, 10, -1000, 2000 }, Sum);
            tree.Add(400);
            Assert.AreEqual(tree[5], 400);
        }
        [TestMethod]
        public void Add_elem_at_begin_with_index_Success()
        {
            Tree tree = new Tree(new int[] { 30, 20, 10, -1000, 2000 }, Sum);
            const int ADDED_ELEM = 400;
            tree.Add(ADDED_ELEM, 0);
            Assert.AreEqual(tree[0], ADDED_ELEM);
        }
        [TestMethod]
        public void Set_elem_at_end_Success()
        {
            Tree tree = new Tree(new int[] { 30, 20, 10, -1000, 2000 }, Sum);
            const int SETTING_ELEM = -900;
            tree[4] = SETTING_ELEM;
            Assert.AreEqual(tree[4], SETTING_ELEM);
        }
        [TestMethod]
        public void Set_elem_at_begin_Success()
        {
            Tree tree = new Tree(new int[] { 30, 20, 10, -1000, 2000 }, Sum);
            const int SETTING_ELEM = -1;
            tree[0] = SETTING_ELEM;
            Assert.AreEqual(tree[0], SETTING_ELEM);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Set_elem_at_with_error_index_Error()
        {
            Tree tree = new Tree(new int[] { 30, 20, 10, -1000, 2000 }, Sum);
            tree[NON_EXISTING_INDEX_IN_TREE] = -1;
        }
        [TestMethod]
        public void Search_sum_on_range_Success()
        {
            Tree tree = new Tree(new int[] { 10, 1, 20, 2, 2 }, Sum);
            const int LEFT_BORDER = 0, 
                RIGHT_BORDER = 4, 
                RESULT_SUM = 35;

            int sum = tree.Get_value_on_segment(LEFT_BORDER, RIGHT_BORDER);
            Assert.AreEqual(sum, RESULT_SUM);
        }
        [TestMethod]
        public void Search_min_on_range_Success()
        {
            Tree tree = new Tree(new int[] { 10, 1, 20, 2, 2 }, Min);
            const int LEFT_BORDER = 0,
                RIGHT_BORDER = 4,
                RESULT_MIN = 1;
            int min = tree.Get_value_on_segment(LEFT_BORDER, RIGHT_BORDER);
            Assert.AreEqual(min, RESULT_MIN);
        }
        [TestMethod]
        public void Search_max_on_range_Success()
        {
            Tree tree = new Tree(new int[] { 10, 1, 20, 2, 2 }, Max);
            const int LEFT_BORDER = 0,
                RIGHT_BORDER = 4,
                RESULT_MAX = 20;

            int max = tree.Get_value_on_segment(LEFT_BORDER, RIGHT_BORDER);
            Assert.AreEqual(max, RESULT_MAX);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Search_sum_on_wrong_range__Error()
        {
            Tree tree = new Tree(new int[] { -10, -1, -20, -2, -2 }, Sum);
            const int LEFT_BORDER_MORE_RIGHT = 4,
                RIGHT_BORDER_LESS_LEFT = 0;
            tree.Get_value_on_segment(LEFT_BORDER_MORE_RIGHT, RIGHT_BORDER_LESS_LEFT);
        }
        [TestMethod]
        public void ToString_Success()
        {
            Tree tree = new Tree(new int[] { 10, 1, 20, 2, 2 }, Sum);
            string s = tree.ToString();
            const string RESULT = "35  \n33  2  \n11  22  2    \n10  1  20  2  2        \n";
            Assert.AreEqual(s,RESULT);
        }
    }
}
