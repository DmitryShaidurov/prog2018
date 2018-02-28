﻿using System;

namespace ConsoleApplication
{
    class Program
    {
        static Random rnd = new Random();

        public static void QuickSort(int[] array)
        {
            Array.Sort(array);
        }

        public static void Filling(int[] array, int j)
        {
            for (int i = 0; i < j; i++)
                array[i] = rnd.Next(0, 100);
        }

        public static void Main()
        {
            TestThreeElements();
            TestHundredElements();
            TestOneThousandElements();
            TestNullMassive();
            TestMostElements();
        }

        private static void TestThreeElements()
        {
            int j = 3;
            int kopilka = 0;
            var randomMassive = new int[j];
            Filling(randomMassive, j);
            QuickSort(randomMassive);
            for (int i = 0; i < j - 1; i++)
            {
                if (randomMassive[i] <= randomMassive[i + 1])
                    kopilka = kopilka + 1;
                else
                    Console.WriteLine("Сортировка массива из трёх элементов работает некорректно");
            }
            if (kopilka == randomMassive.Length-1)
                Console.WriteLine("Сортировка массива из трёх элементов работает корректно");
            else
                Console.WriteLine("Сортировка массива из трёх элементов работает некорректно");
        }

        private static void TestHundredElements()
        {
            int j = 100;
            int kopilka = 0;
            var randomMassive = new int[j];
            for (int i = 0; i < j; i++)
                randomMassive[i] = rnd.Next(5, 5);
            QuickSort(randomMassive);
            for (int i = 0; i < j - 1; i++)
            {
                if (randomMassive[i] == randomMassive[i + 1])
                    kopilka = kopilka + 1;
                else
                    Console.WriteLine("Сортировка массива из 100 элементов работает некорректно");
            }
            if (kopilka == randomMassive.Length - 1)
                Console.WriteLine("Сортировка массива из 100 элементов работает корректно");
            else
                Console.WriteLine("Сортировка массива из 100 элементов работает некорректно");
        }

        private static void TestNullMassive()
        {
            int j = 100;
            int kopilka = 0;
            var randomMassive = new int[j];
            for (int i = 0; i < j; i++)
                randomMassive[i] = rnd.Next(0, 0);
            QuickSort(randomMassive);
            for (int i = 0; i <j - 1 ; i++)
            {
                if (randomMassive[i] == 0)
                    kopilka = kopilka + 1;
                else
                    Console.WriteLine("Сортировка пустого массива работает некорректно");
            }
            if (kopilka == randomMassive.Length - 1)
                Console.WriteLine("Сортировка пустого массива работает корректно");
            else
                Console.WriteLine("Сортировка пустого массива работает некорректно");
        }

        private static void TestOneThousandElements()
        {
            int j = 1000;
            int kopilka = 0;
            var randomMassive = new int[j];
            Filling(randomMassive, j);
            QuickSort(randomMassive);
            for (int i = 0; i < j - 1; i++)
            {
                if ((randomMassive[i] <= randomMassive[i + 1]) && (i < i+1))
                    kopilka = kopilka + 1;
                else
                    Console.WriteLine("Сортировка массива из 1000 случайных элементов работает некорректно");
            }
            if (kopilka == randomMassive.Length - 1)
                Console.WriteLine("Сортировка массива из 1000 случайных элементов работает корректно");
            else
                Console.WriteLine("Сортировка массива из 1000 случайных элементов работает некорректно");
        }


        private static void TestMostElements()
        {
            int j = 1500000000;
            int kopilka = 0;
            var randomMassive = new int [j];
            Filling(randomMassive, j);
            QuickSort(randomMassive);
            for (int i = 0; i < j - 1; i++)
            {
                if (randomMassive[i] <= randomMassive[i + 1])
                    kopilka = kopilka + 1;
                else
                    Console.WriteLine("Сортировка массива из 1 500 000 000 элементов работает некорректно");
            }
            if (kopilka == randomMassive.Length - 1)
                Console.WriteLine("Сортировка массива из 1 500 000 000 элементов работает корректно");
            else
                Console.WriteLine("Сортировка массива из 1 500 000 000 элементов работает некорректно");
        }
    }
}