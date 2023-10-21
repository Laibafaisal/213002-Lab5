using System;
namespace LabQ5
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("Choose an option:\n" +
                "1 for Binary to Decimal conversion\n" +
                "2 for Decimal to Binary conversion\n" +
                "0 to exit");
            string opt = Console.ReadLine();    
            int.TryParse(opt, out int choice);

            switch(choice)
            {
                case 0:
                    {
                        break;
                    }
                case 1:
                    {
                        BinaryToDecimal();
                        break;
                    }
                case 2:
                    {
                        DecimalToBinary();
                        break;
                    }
            }
        }

        static void DecimalToBinary()
        {
            Console.WriteLine("Enter the decimal number: ");
            int decNum = int.Parse(Console.ReadLine());
            string binaryNum = "";

            while (decNum > 0)
            {
                int remainder = decNum % 2;
                binaryNum = remainder + binaryNum;
                decNum = decNum / 2;
            }

            Console.WriteLine($"The binary equivalent is: {binaryNum}.");
        }

        static void BinaryToDecimal()
        {
            Console.WriteLine("Enter the binary number: ");
            string input = Console.ReadLine();
            if (input != null)
            {
                int a = Convert.ToInt32(input, 2);
                Console.WriteLine($"The decimal equivalent is: {a}.");
            }
            else
            {
                Console.WriteLine("Exception error!");
            }
        }
    }
}