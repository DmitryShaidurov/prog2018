using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using task3;


namespace Test_Task3
{
    [TestClass]
    public class Tests
    {
        public static Random random = new Random();
        [TestMethod]
        //Сортировка массива из трёх элементов. После сортировки второй элемент больше первого, третий больше второго
        public void TestSortThreeElements()
        {
            var array = new[] { 123, 5345, 2233 };
            Program.QuickSort(array);
            Assert.IsTrue(array[0] <= array[1], "Первый элемент меньше (либо равен) второго элемента");
            Assert.IsTrue(array[1] <= array[2], "Второй элемент меньше (либо равен) третьего элемента");
        }

        [TestMethod]
        //Сортировка массива из 100 одинаковых чисел
        public void TestSortOneHundredElements()
        {
            var array = new int[100];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 50;
            }
            Program.QuickSort(array);
        }

        [TestMethod]
        //Сортировка массива из 1000 случайных элементов. Проверить что 10 случайных пар элементов массива после сортировки упорядочены (их пары больший тот, чей индекс больше)
        public void TestSortOneThousandElements()
        {
            var array = new int[1000];
            Program.GenerateArray(array.Length);
            Program.QuickSort(array);

            for(int i = 0; i < 10; i++)
            {
                int firstIndex = random.Next(0, (array.Length / 2));
                int secondIndex = random.Next((array.Length / 2), array.Length);
                Assert.IsTrue(array[firstIndex] <= array[secondIndex], "Второй элемент больше (либо равен) первого элемента");
            }
        }

        [TestMethod]
        //Сортировка пустого массива
        public void TestSortOneEmpty()
        {
            var array = new int[0];
            Program.QuickSort(array);
        }

        [TestMethod]
        //Сортировка пустого массива
        public void TestSortMoreElements()
        {
            var array = new int[1500000000];
            Program.QuickSort(array);
        }
    }
}
