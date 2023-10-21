using System;

namespace Lab5Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = { "Pakistan", "Zindabaad", "!" };
            string str = function(s);
            Console.WriteLine(str);
        }

        public static string function(string[] array)
        {
            string a = "";
            foreach (string i in array)
            {
                a = a + " " + i;
            }
            return a;
        }
    }
}
