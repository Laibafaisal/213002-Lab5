using System;
using System.Diagnostics.CodeAnalysis;

namespace Lab5Question6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] scores = { {92, 73, 86, 71, 97, 93, 95, 97, 80, 91 },
                         {90, 86, 81, 80, 78, 78, 80, 82, 88, 88 },
                         {99, 97, 89, 100, 77, 90, 78, 80, 78, 97 },
                         {79, 95, 79, 77, 89, 84, 71, 92, 80, 83 },
                         {72, 82, 97, 88, 90, 88, 80, 82, 83 , 80 } };
            int[] averageScores = new int[10];

            for (int i = 0; i < 10; i++)
            {
                int sum = 0;
                int avg = 0;
                for (int j = 0; j < 5; j++)
                {
                    sum = sum + scores[j,i];
                }
                avg = sum / 5;
                averageScores[i] = avg;
            }

            //displaying output
            Console.WriteLine("Student\t1\t2\t3\t4\t5\t6\t7\t8\t9\t10");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Test{i + 1}\t");
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(scores[i,j] + "\t");
                }
                Console.WriteLine();
            }

            Console.Write("Avg.\t");
            for (int k = 0; k < 10; k++)
            {
                Console.Write(averageScores[k] + "\t");
            }




        }
    }
}