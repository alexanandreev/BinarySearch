using System;

namespace BinarySearch

{
    class Program
    {
        public static int BinarySearch(int[] array, int value)
        {
            //код поиска значения value в массиве array
            if (array.Length == 0) return -1;
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
            TestNegativeNumbers();
            TestNonExistentElement();
            TestSearch();
            TestSearchRepeatNumber();
            TestSearchInEmptyMassive();
            TestSearchInBigMassive();
            Console.ReadKey();
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
            int[] negativeNumbers = new[] { -5, -4, -3, -2 };
            if (BinarySearch(negativeNumbers, -1) >= 0)
                Console.WriteLine("! Поиск нашёл число -1 среди чисел {-5, -4, -3, -2}");
            else
                Console.WriteLine("Поиск отсутствующего элемента вернул корректный результат работает корректно");
        }

        private static void TestSearch()
        {
            //Тестирование поиска
            int[] Numbers = new[] { -5, -4, -3, -2, 4 };
            if (BinarySearch(Numbers, -2) != 3)
                Console.WriteLine("Поиск работает некорректно");
            else
                Console.WriteLine("Поиск вернул корректный результат работает корректно");
        }

        private static void TestSearchRepeatNumber()
        {
            //Тестирование поиска повторяющегося элемента
            int[] Numbers = new[] { -5, -4, -2, -2, 4 };
            if (BinarySearch(Numbers, -2) != 2)
                Console.WriteLine("Поиск элемента, повторяющегося несколько раз работает некорректно");
            else
                Console.WriteLine("Поиск элемента, повторяющегося несколько раз вернул корректный результат работает корректно");
        }

        private static void TestSearchInEmptyMassive()
        {
            //Тестирование поиска в пустом массиве
            int[] Numbers = new int[0];
            if (BinarySearch(Numbers, -2) != -1)
                Console.WriteLine("Поиск в пустом массиве работает некорректно");
            else
                Console.WriteLine("Поиск в пустом массиве работает корректно");
        }

        private static void TestSearchInBigMassive()
        {
            //Тестирование поиска в большом массиве
            int[] Numbers = new int[100001];
            for (int i = 0; i < Numbers.Length; i++) Numbers[i] = i;
            if (BinarySearch(Numbers, 1000) != 1000)
                Console.WriteLine("Поиск в массиве из 100001 элементов работает некорректно");
            else
                Console.WriteLine("Поиск в массиве из 100001 элементов работает корректно");
        }
    }
}