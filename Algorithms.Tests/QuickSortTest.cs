using System;
using NUnit.Framework;

namespace Algorithms.Tests
{
    [TestFixture()]
    public class QuickSortTest
    {
        [Test]
        [TestCase(8)]
        [TestCase(13)]
        [TestCase(1024)]
        public void TestReverse(int size)
        {
            int[] testArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                testArray[i] = size - i;
            }
            Quicksort.Sort(testArray);

            CollectionAssert.IsOrdered(testArray);
        }

        [Test]
        [TestCase(8)]
        [TestCase(13)]
        [TestCase(1024)]
        public void TestAllreadySorted(int size)
        {
            int[] testArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                testArray[i] = i;
            }
            Quicksort.Sort(testArray);

            CollectionAssert.IsOrdered(testArray);
        }

        [Test]
        [TestCase(8)]
        [TestCase(13)]
        [TestCase(1024)]
        public void TestRandom(int size)
        {
            int[] testArray = new int[size];
            Random random = new Random(1);
            for (int i = 0; i < size; i++)
            {
                testArray[i] = i;
            }

            for (int i = 0; i < size-1; i++)
            {
                int randomIndex = random.Next(i+1, size );

                int temp = testArray[i];
                testArray[i] = testArray[randomIndex];
                testArray[randomIndex] = temp;
            }
            Quicksort.Sort(testArray);

            CollectionAssert.IsOrdered(testArray);
        }

        [Test]
        [TestCase(8)]
        [TestCase(13)]
        [TestCase(1024)]
        public void TestMostlySame(int size)
        {
            int[] testArray = new int[size];
            Random random = new Random(1);
            for (int i = 0; i < size; i++)
            {
                testArray[i] = random.Next(4);
            }
            Quicksort.Sort(testArray);

            CollectionAssert.IsOrdered(testArray);
        }

        [Test]
        public void TestOddOneOut()
        {
            int[] testArray = new[] {1, 1, 1, 1, 5, 1, 1,};
            Quicksort.Sort(testArray);

            CollectionAssert.IsOrdered(testArray);
        }
    }
}