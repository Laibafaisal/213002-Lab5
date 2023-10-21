using System;

namespace Lab5Q3
{
    class stringManipulation
    {
        private static void Main(string[] args)
        {
            string str = "Visual programming is a very good subject.";
            str = FindVowelsAndLength(str);
            Console.WriteLine(str);
        }

        private static string FindVowelsAndLength(string str)
        {
            //string temp = String.Empty;
            string[] WordsArray = str.Split(' ');//to split only on spaces
            str = String.Empty;

            foreach (string word in WordsArray)
            {
                if (word.Length == 4 ||word.Length == 5)
                {
                    for (int i = 0; i<word.Length; i++)
                    {
                        if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u')
                        {
                            //temp = temp + word;
                            str = str + word + " ";
                            break;
                        }
                    }
                }
            }
            return str;
        }
    }
    
}
