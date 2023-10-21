using System;
using System.Reflection;

namespace Lab5Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int min = 1;
            int max = 5;
            int[] responses = new int[40];

            for (int i =0; i < responses.Length; i++)
            {
                int random = rnd.Next(min, max + 1);
                responses[i] = random;
            }

            //declaring and initialising the array to get the frequency
            int[] frequency = new int[5];
            for (int i =0; i< frequency.Length; i++)
            {
                frequency[i] = 0;
            }

            foreach (int i in responses)
            {
                switch (i)
                {
                    case 1:
                        {
                            frequency[0]++;
                            break;
                        }
                    case 2:
                        {
                            frequency[1]++; 
                            break;
                        }
                    case 3:
                        {
                            frequency[2]++;
                            break;
                        }
                    case 4:
                        {
                            frequency[3]++;
                            break;
                        }
                    case 5:
                        {
                            frequency[4]++;
                            break;
                        }
                }
            }

            Console.WriteLine($"Response 1 is given by: {frequency[0]} people");
            Console.WriteLine($"Response 2 is given by: {frequency[1]} people");
            Console.WriteLine($"Response 3 is given by: {frequency[2]} people");
            Console.WriteLine($"Response 4 is given by: {frequency[3]} people");
            Console.WriteLine($"Response 5 is given by: {frequency[4]} people");
        }
    }
}
