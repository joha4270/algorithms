using NUnit.Framework;
using Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Tests
{
    [TestFixture()]
    public class HeapTests
    {
        [Test()]
        public void HeapifyTest1()
        {
            int[] arr = new[] {1, 2, 3, 4, 5, 6};
            Heap.MaxHeapify(arr);
            TestContext.WriteLine(string.Join(", ", arr));
            Assert.That(Heap.IsMaxHeap(arr));
        }

        [Test()]
        public void HeapifyTest2()
        {
            int[] arr = new[] { 1,2,2,4,4,4,4,8,8,8 };
            Heap.MaxHeapify(arr);
            TestContext.WriteLine(string.Join(", ", arr));
            Assert.That(Heap.IsMaxHeap(arr));
        }

        [Test()]
        public void HeapifyTest3()
        {
            int[] arr = new[] { 5,2,5,2,5,2,1 };
            Heap.MaxHeapify(arr);
            TestContext.WriteLine(string.Join(", ", arr));
            Assert.That(Heap.IsMaxHeap(arr));
        }

        [Test()]
        public void HeapifyTest4()
        {
            int[] arr = new[] {6,5,5,5,5,5 };
            Heap.MaxHeapify(arr);
            TestContext.WriteLine(string.Join(", ", arr));
            Assert.That(Heap.IsMaxHeap(arr));
        }

        [Test()]
        public void HeapifyTest5()
        {
            int[] arr = new[] {6,6,6,6, 6 };
            Heap.MaxHeapify(arr);
            TestContext.WriteLine(string.Join(", ", arr));

            Assert.That(Heap.IsMaxHeap(arr));
        }

        [Test()]
        public void HeapifyTest6()
        {
            int[] arr = new[] { 5,5,5,5,5,6 };
            Heap.MaxHeapify(arr);
            TestContext.WriteLine(string.Join(", ", arr));
            Assert.That(Heap.IsMaxHeap(arr));
        }

        //[Test()]
        //[TestCase(new[] {1, 2}, false)]
        //[TestCase(new[] {1, 2}, false)]
        //[TestCase(new[] {1, 2}, false)]
        //[TestCase(new[] {1, 2}, false)]
        //[TestCase(new[] {1, 2}, false)]
        //public void IsHeapTest(int[] values, bool result)
        //{
        //    Assert.Pass();
        //    Assert.AreEqual(result, Heap.IsMaxHeap(values));
        //}


        [Test()]
        public void IsHeapTest1()
        {
            Assert.AreEqual(false, Heap.IsMaxHeap(new[] {1, 2}));
        }

        [Test()]
        public void IsHeapTest2()
        {
            Assert.AreEqual(false, Heap.IsMaxHeap(new[] { 1, 2, 3 }));
        }

        [Test()]
        public void IsHeapTest3()
        {
            Assert.AreEqual(true, Heap.IsMaxHeap(new[] { 3, 1, 1 }));
        }

        [Test()]
        public void IsHeapTest4()
        {
            Assert.AreEqual(true, Heap.IsMaxHeap(new[] { 7, 6, 4, 5, 3, 2, 4 }));
        }

        [Test()]
        public void IsHeapTest5()
        {
            Assert.AreEqual(false, Heap.IsMaxHeap(new[] { 7, 6, 4,4,  3, 5, 2, 4 }));
        }
    }
}