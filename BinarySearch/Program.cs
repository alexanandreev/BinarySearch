using System;

namespace BinarySearch

{
    class Program
    {
        public static int BinarySearch(int[] array, int value)
        {
            //код поиска значения value в массиве array
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
            //Тестирование поиска отсутствующего элемента
            int[] Numbers = new[] { -5, -4, -3, -2, 4 };
            if (BinarySearch(Numbers, -2) != 3)
                Console.WriteLine("Поиск работает некорректно");
            else
                Console.WriteLine("Поиск вернул корректный результат работает корректно");
        }
    }
}