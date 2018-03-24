using System;
namespace ConsoleApplication
{
    class Program
    {
        public static int BinarySearch(int[] array, int value)
        {
            if (array.Length == 0) return -2;
            var left = 0;
            var right = array.Length - 1;
            while (left < right)
            {
                var middle = (right + left) / 2;
                if (value <= array[middle])
                    right = middle;
                else left = middle + 1;
            }
            if (array[right] == value)
                return right;
            return -1;
        }
        static void Main(string[] args)
        {
            TestOneElement();
            TestNegativeNumbers();
            TestNonExistentElement();
            TestRepeatedElements();
            TestEmptyMassive();
            TestBigMassive();
            Console.ReadKey();
        }
        private static void TestOneElement()
        {
            //Тестирование поиска одного элемента в массиве из 5 элементов
            int[] fiveElements = new[] { 3, 7, 14, 26, 44 };
            if (BinarySearch(fiveElements, 7) != 1)
                Console.WriteLine("! Поиск не нашёл число 7 среди чисел { 3, 7, 14, 26, 44 }");
            else
                Console.WriteLine("Поиск одного элемента в массиве из 5 элементов выполнен корректно");
        }
        private static void TestNegativeNumbers()
        {
            //Тестирование поиска в отрицательных числах 
            int[] negativeNumbers = new[] { -5, -4, -3, -2 };
            if (BinarySearch(negativeNumbers, -3) != 2)
                Console.WriteLine("! Поиск не нашёл число -3 среди чисел {-5, -4, -3, -2}");
            else
                Console.WriteLine("Поиск среди отрицательных чисел работает корректно");
        }
        private static void TestNonExistentElement()
        {
            //Тестирование поиска отсутствующего элемента 
            int[] numbers = new[] { -5, -4, -3, -2 };
            if (BinarySearch(numbers, -1) >= 0)
                Console.WriteLine("! Поиск нашёл число -1 среди чисел {-5, -4, -3, -2}");
            else
                Console.WriteLine("Поиск отсутствующего элемента вернул корректный результат");
        }
        private static void TestRepeatedElements()
        {
            //Тестирование поиска элемента, повторяющегося несколько раз 
            int[] numbers = new[] { 3, 7, 7, 14, 44 };
            if (BinarySearch(numbers, 7) != 1)
                Console.WriteLine("! Поиск не нашёл число 7 среди чисел { 3, 7, 7, 14, 44 }");
            else
                Console.WriteLine("Поиск элемента, повторяющегося несколько раз работает корректно");
        }
        private static void TestEmptyMassive()
        {
            //Тестирование поиска в пустом массиве 
            int[] numbers = new int[0];
            if (BinarySearch(numbers, 7) != -2)
                Console.WriteLine("! Поиск в пустом массиве работает не корректно");
            else
                Console.WriteLine("Поиск в пустом массиве работает корректно");
        }
        private static void TestBigMassive()
        {
            //Тестирование поиска в массиве из 100001 элементов 
            int[] numbers = new int[100001];
            Random rand = new Random();
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = rand.Next(0, 100);
            Array.Sort(numbers);
            numbers[100000] = 100;
            if (BinarySearch(numbers, 100) != 100000)
                Console.WriteLine("! Поиск в массиве из 100001 элементов работает не корректно");
            else
                Console.WriteLine("Поиск в массиве из 100001 элементов работает корректно");
        }
    }
}