using System;
using System.Collections;

namespace ConsoleApp1
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var firstNumber = GetNumber("First num: ");
            var userOperator = GetOperator("Enter the operation + , - , * , / , ^, % :");
            var secondNumber = GetNumber("Second num: ");

            double? result;   
            switch (userOperator)
            {
                case "+": result = firstNumber + secondNumber;
                    break;
                case "-": result = firstNumber - secondNumber;
                    break;
                case "*": result = firstNumber * secondNumber;
                    break;
                case "/": result = firstNumber / secondNumber;
                    break;
                case "^": result = Math.Pow(firstNumber, secondNumber);
                    break;
                case "%":  result = firstNumber % secondNumber;
                    break;
                default: throw new Exception("invalid logic");
            }
            
            Console.WriteLine("\n" + firstNumber + " " + userOperator + " " + secondNumber + " = " + result + ".");

        }

        private static double GetNumber(string textLine)
        {
            Console.Write(textLine);
            var readLine = Console.ReadLine();
            while (!double.TryParse(readLine, out _))
            {
                Console.WriteLine("Wrong input!");
                Console.Write(textLine);
                readLine = Console.ReadLine();
            }
            return double.Parse(readLine);
        }
        
        private static readonly string[] Operators = { "+", "-", "*", "/", "^", "%" };

        private static bool IsValidOperation(string input)
        {
            return ((IList) Operators).Contains(input);
        }
        
        private static string GetOperator(string outputText)
        {
            Console.Write(outputText);
            var tempInput = Console.ReadLine();
            while (!IsValidOperation(tempInput))
            {
                Console.WriteLine("Incorrect input !");
                Console.Write(outputText);
                tempInput = Console.ReadLine();
            }
            return tempInput;
        }
    }
}
