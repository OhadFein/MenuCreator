using System;

namespace Ex04.Menus.Test
{
    internal static class UtilsUI
    {
        internal static void showVersion()
        {
            Console.WriteLine("Version: 18.2.4.0");
            Console.WriteLine();
        }

        internal static void showDate()
        {
            Console.WriteLine("The date is {0}", DateTime.Today.ToString("d"));
            Console.WriteLine();
        }

        internal static void showTime()
        {
            Console.WriteLine("The time is {0}", DateTime.Now.ToString("hh:mm:ss tt"));
            Console.WriteLine();
        }

        internal static void countCapitalLetterInput()
        {
            int numOfCapitalLetters = 0;

            Console.WriteLine("Enter your sentence:");
            string inputSentence = Console.ReadLine();

            foreach (char currentChar in inputSentence)
            {
                if (char.IsUpper(currentChar))
                {
                    numOfCapitalLetters++;
                }
            }

            Console.WriteLine("Number of capital letters in your sentence is: {0}", numOfCapitalLetters);
            Console.WriteLine();
        }
    }
}
