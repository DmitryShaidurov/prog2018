using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace testForTask4
{

    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void GetAndFindThreeElements()
        {
            var hashTable = new task4.HashTable(3);

            hashTable.PutPair("4", "Четыре");
            hashTable.PutPair("7", "Семь");
            hashTable.PutPair("13", "Тринадцать");

            Assert.AreEqual(hashTable.GetValueByKey("4"), "Четыре");
            Assert.AreEqual(hashTable.GetValueByKey("7"), "Семь");
            Assert.AreEqual(hashTable.GetValueByKey("13"), "Тринадцать");
        }

        [TestMethod]
        public void GetTwoIdenticalKey()
        {
            var hashTable = new task4.HashTable(3);

            hashTable.PutPair("4", "Четыре");
            hashTable.PutPair("4", "четыре!");

            Assert.AreEqual(hashTable.GetValueByKey("4"), "четыре!");
        }

        [TestMethod]
        public void TenThousandElements()
        {
            var hashTable = new task4.HashTable(10000);

            for (int i = 0; i < 10000; i++)
            {
                hashTable.PutPair(i, i + " элемент");
            }

            Assert.AreEqual(hashTable.GetValueByKey(18), "18 элемент");
        }

        [TestMethod]
        public void OneThousandNotAddedElements()
        {
            var hashTable = new task4.HashTable(10000);

            for (int i = 0; i < 10000; i++)
            {
                hashTable.PutPair(i, i + " элемент");
            }

            for (int i = 10000; i < 11000; i++)
            {
                Assert.AreEqual(hashTable.GetValueByKey(i), null);
            }
        }
    }
}