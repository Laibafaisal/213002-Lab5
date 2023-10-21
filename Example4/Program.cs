using System;
using System.Linq;

namespace Example4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] weekDays = { "Mon", "Tue", "Wed", "Thurs", "Fri", "Sat", "Sun" };
            printArray(weekDays);
            
            changeArray(weekDays);
            Console.WriteLine("Array elements after call to changeArray:\n");
            printArray(weekDays);

            changeArrayElements(weekDays);
            Console.WriteLine("Array elements after call to changeArrayElements:\n");
            printArray(weekDays);
        }

        private static void changeArrayElements(string[] weekDays)
        {
            weekDays[0] = "Sat";
            weekDays[1] = "Fri";
            weekDays[2] = "Thu";
            Console.WriteLine("arr[0] is {0} in ChangeArray Elements.", weekDays[0]);
        }

        private static void changeArray(string[] weekDays)
        {
            weekDays = weekDays.Reverse().ToArray();
            Console.WriteLine("arr[0] is {0} in ChangeArray.", weekDays[0]);
        }

        public static void printArray(string[] weekDays)
        {
            for (int i = 0; i < weekDays.Length; i++)
            {
                Console.Write(weekDays[i] + "{0}", i < weekDays.Length - 1 ? "" : "");
                Console.WriteLine();
            }
        }
    }
}
