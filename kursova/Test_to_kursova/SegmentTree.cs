using System;
using kursova;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_to_kursova
{
    [TestClass]
    public class SegmentTree
    {


        const int NON_EXISTING_INDEX_IN_TREE = -1;
        static int Sum(int a, int b) { return a + b; }
        static int Min(int a, int b) { return (a < b ? a : b); }
        static int Max(int a, int b) { return (a > b ? a : b); }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_CreateTreeWithNullArray_Exception()
        {
            //arrange
            Tree tree;

            //act
            tree = new Tree(null, Sum);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_CreateTreeWithNullFunc_Exception()
        {
            //arrange
            Tree tree;
            //act
            tree = new Tree(new int[] { }, null);
        }


        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Indexer_GetElemWithNonExitingIndex_Exception()
        {
            //arrange
            Tree tree = new Tree(new int[] { 30, 20, 10, -1000, 2000 }, Sum);
            //act
            int a = tree[NON_EXISTING_INDEX_IN_TREE];
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Add_ByNonExitingIndex_Exception()
        {
            //arrange
            Tree tree = new Tree(new int[] { 30, 20, 10, -1000, 2000 }, Sum);
            //act
            tree.Add(1, NON_EXISTING_INDEX_IN_TREE);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Delete_ByNonExitingIndex_Exception()
        {
            //arrange
            Tree tree = new Tree(new int[] { 30, 20, 10, -1000, 2000 }, Sum);
            //act
            tree.Delete(NON_EXISTING_INDEX_IN_TREE);
        }

        [TestMethod]
        public void Add_ToEndOfNonEmptyTree_Success()
        {
            //arrange
            Tree tree = new Tree(new int[] { 30, 20, 10, -1000, 2000 }, Sum);

            //act
            tree.Add(400);

            //assert
            Assert.AreEqual(tree[5], 400);
        }
        [TestMethod]
        public void Add_ToBeginOfNonEmptyTree_Success()
        {
            //arrange
            Tree tree = new Tree(new int[] { 30, 20, 10, -1000, 2000 }, Sum);

            //act
            tree.Add(400, 0);

            //assert
            Assert.AreEqual(tree[0], 400);
        }
        [TestMethod]
        public void Set_LastAddedElementOfNonEmptyTree_ElementChanged()
        {
            //arrange
            Tree tree = new Tree(new int[] { 30, 20, 10, -1000, 2000 }, Sum);

            //act
            tree[4] = -900;

            //assert
            Assert.AreEqual(tree[4], -900);
        }
        [TestMethod]
        public void Set_InitialAddedElemOfNonEmptyTree_BeginElemChanged()
        {
            //arrange
            Tree tree = new Tree(new int[] { 30, 20, 10, -1000, 2000 }, Sum);

            //act
            tree[0] = -1;

            //assert
            Assert.AreEqual(tree[0], -1);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Set_ElemWithNonExitingIndex_Exception()
        {
            //arrange
            Tree tree = new Tree(new int[] { 30, 20, 10, -1000, 2000 }, Sum);

            //act
            tree[NON_EXISTING_INDEX_IN_TREE] = -1;
        }
        [TestMethod]
        public void GetValueOnSegment_CorrectRange_SumOfRange()
        {
            //arrange
            Tree tree = new Tree(new int[] { 10, 1, 20, 2, 2 }, Sum);
            const int RESULT_SUM = 35;//10+1+20+2+2

            //act
            int sum = tree.GetValueOnSegment(0, 4);

            //assert
            Assert.AreEqual(sum, RESULT_SUM);
        }
        [TestMethod]
        public void GetValueOnSegment_CorrectRange_MinOfRange()
        {
            //arrange
            Tree tree = new Tree(new int[] { 10, 1, 20, 2, 2 }, Min);
            const int RESULT_MIN = 1;

            //act
            int min = tree.GetValueOnSegment(0, 4);

            //assert
            Assert.AreEqual(min, RESULT_MIN);
        }
        [TestMethod]
        public void GetValueOnSegment_CorrectRange_MaxofRange()
        {
            //arrange
            Tree tree = new Tree(new int[] { 10, 1, 20, 2, 2 }, Max);
            const int RESULT_MAX = 20;

            //act
            int max = tree.GetValueOnSegment(0, 4);

            //assert
            Assert.AreEqual(max, RESULT_MAX);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetValueOnSegment_IncorrectRange_Exception()
        {
            //arrange
            Tree tree = new Tree(new int[] { -10, -1, -20, -2, -2 }, Sum);

            //act
            tree.GetValueOnSegment(4, 0);
        }
        [TestMethod]
        public void ToString_NonEmptyTree_ImageTree()
        {
            //arrange
            Tree tree = new Tree(new int[] { 10, 1, 20, 2, 2 }, Sum);
            const string RESULT = "35  \n33  2  \n11  22  2    \n10  1  20  2  2        \n";

            //act
            string s = tree.ToString();

            //assert
            Assert.AreEqual(s, RESULT);
        }
    }
}
