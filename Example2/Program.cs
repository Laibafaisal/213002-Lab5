using System;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {

                int[,] numbers2DArray = new int[3, 2] { { 1, 11}, { 3, 33 }, { 4, 44 } };
                foreach (int i in numbers2DArray)
                {
                    Console.WriteLine("{0} ", i);
                }
         }
    }
 }


