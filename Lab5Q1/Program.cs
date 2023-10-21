using System;

namespace Lab5Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,]{ { 2, 200 }, { 56, 560 } };
            print2DArray(array);
        }

        public static void print2DArray(int[,] num)
        {
            foreach (int i in num)
            {
                Console.WriteLine("{0} ", i);
            }
        }
    }
}
