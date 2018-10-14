using System;
using System.Collections.Generic;
using System.Text;

// Реализовать перевод из 10 в 2 систему счисления с использованием стека.

// Александр Коновальцев

namespace Task1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number, that you are going to convert to binary number: ");
            try
            {
                int n = int.TryParse(Console.ReadLine(), out n) ? n : throw new Exception("Incorrect number");
                Console.WriteLine($"Binary value is: {ConvertIntToBinary(n)}");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static string ConvertIntToBinary(int value)
        {
            var stack = new Stack<string>();
            var result = new StringBuilder();
            while(value >= 0)
            {
                if (value == 0) break;
                stack.Push((value % 2).ToString());
                value /= 2;
            }

            while(stack.Count != 0)
            {
                result.Append(stack.Pop());
            }
            return result.ToString();
        }
    }
}