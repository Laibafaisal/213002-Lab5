using System;
using System.Security.Cryptography.X509Certificates;

namespace Lab5Q7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrixA = new int[3,3];
            int[,] matrixB = new int[3,3];
            int[,] result = new int[3,3];
            matrixA = GetInput();
            matrixB = GetInput();
;           result = GetProduct(ref  matrixA, ref matrixB);
            Display(ref result);
        }

        static int[,] GetInput()
        {
            int[,] array = new int[3,3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Enter the value of {j + 1} column of {i + 1} row:\n");
                    array[i,j]=int.Parse(Console.ReadLine());
                }
            }
            return array;
        }

        static int[,] GetProduct(ref int[,] matrixA, ref int[,] matrixB ) 
        {
            int[,] product = new int[3, 3];
            for (int i=0; i<3; i++)
            {
                for (int j = 0; j<3 ; j++)
                {
                    product[i, j] = 0;

                    for(int k =0; k<3; k++)
                    {
                        product[i, j] += matrixA[i, k] * matrixB[k, j]; 
                    }
                }
            }
            return product;
        }

        static void Display(ref int[,] product)
        {
            for (int i=0; i<3; i++)
            {
                for (int j=0; j<3 ; j++)
                {
                    Console.Write(product[i, j]);
                }
                Console.WriteLine();    
            }
        }
    }
}