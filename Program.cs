namespace Leap_years
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Convert number to words");
            Console.WriteLine("2. Convert words to number");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Please enter a number:");
                    int number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(NumberToWords(number));
                    break;
                case 2:
                    Console.WriteLine("Please enter a word:");
                    string word = Console.ReadLine();
                    Console.WriteLine(WordsToNumber(word));
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }

        private static bool WordsToNumber(string? word)
        {
            throw new NotImplementedException();
        }

        public static string NumberToWords(int number)
        {
            return NumberToWords(number, int, string);
        }

        public static string NumberToWords(int number, int @string, string str)
        {
            if (number < 0)
            {
                return "Negative " + NumberToWords(Math.Abs(number));
            }

            string words = "";

            if (number == 0)
            {
                return "Zero";
            }

            int[] numbers = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            /*const string  = " Thousand";
            int[] strings = { "",  " Million", " Billion", " Trillion" };*/

            int i = 0;
            while (number > 0)
            {
                int divisor = (int)Math.Pow(1000, i);
                numbers[i] = number % 1000;
                number /= 1000;
                i++;
            }

            for (int j = 0; j < i; j++)
            {
                if (numbers[j] > 0)
                {
                    words += ConvertThreeDigitsToWords(numbers[j]) + str[j] + " ";
                }
           

            return words.Trim();
        }

            public static string ConvertThreeDigitsToWords(int number)
        {
            if (number == 0)
            {
                return "";
            }

            int hundreds = number / 100;
            int remainder = number % 100;

            string words = "";

            if (hundreds > 0)
            {
                words += HundredsToWords(hundreds) + " Hundred ";
            }

            if (remainder > 0)
            {
                words += ProgramHelpers.TensToWords(remainder);
            }

            return words.Trim();
        }

        public static string HundredsToWords(int hundreds)
        {
            if (hundreds == 1)
            {
                return "One Hundred";
            }
            else if (hundreds == 2)
            {
                return "Two Hundred";
            }
            else if (hundreds == 3)
            {
                return "Three Hundred";
            }
            else if (hundreds == 4)
            {
                return "Four Hundred";
            }
            else if (hundreds == 5)
            {
                return "Five Hundred";
            }
            else if (hundreds == 6)
            {
                return "Six Hundred";
            }
            else if (hundreds == 7)
            {
                return "Seven Hundred";
            }
            else if (hundreds == 8)
            {
                return "Eight Hundred";
            }
            else if (hundreds == 9)
            {
                return "Nine Hundred";
            }
            else
            {
                return "";
            }
        }

        
    }
}