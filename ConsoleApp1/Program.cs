using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();
            while (text.Length > 100)
            {
                Console.WriteLine("Введите текст меньше 100 символов:");
                text = Console.ReadLine();
            }
            Console.WriteLine(ReverseString(text, String.Empty));
            Console.ReadLine();
        }
        public static string ReverseString(string originalText, string endText)
        {
            if (originalText.Length > endText.Length)
            {
                endText += originalText[originalText.Length - endText.Length - 1];
                return ReverseString(originalText, endText);
            }
            else
                return endText;
        }
    }
}
