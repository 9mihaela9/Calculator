using System;

namespace MyApp
{
    internal class Calculator
    {
        public static double AskDoubleInput(string numberTypeName)
        {
            double number;
            Console.Write($"Insert {numberTypeName} number: ");
            if (double.TryParse(Console.ReadLine(), out number)) { return number; }
            else 
            { 
                Console.WriteLine("Invalid input. \nPlease enter number again: ");
                return Convert.ToDouble(Console.ReadLine());
            }
        }
        public static void screenClear()
        {
            Console.ReadKey();
            Console.Clear();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Calx" + Environment.NewLine);

            double firstNumber = 0, secondNumber = 0;
            double result;
            bool isOpen = true;

            while (isOpen)
            {
                Console.WriteLine("Options:");
                Console.WriteLine("1. Perform calculation");
                Console.WriteLine("2. Exit");

                Console.Write("Enter option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        firstNumber = AskDoubleInput("first");
                        secondNumber = AskDoubleInput("second");

                        if (firstNumber == 0 && secondNumber == 0)
                        {
                            Console.WriteLine("Please insert numbers first.");
                            break;
                        }

                        Console.Write("Insert operation (+ - / *): ");

                        switch (Console.ReadLine())
                        {
                            case "+":
                                result = firstNumber + secondNumber;
                                Console.WriteLine($"{firstNumber} + {secondNumber} = {result}");
                                screenClear();
                                break;
                            case "-":
                                result = firstNumber - secondNumber;
                                Console.WriteLine($"{firstNumber} - {secondNumber}  = {result}");
                                screenClear();
                                break;
                            case "/":
                                result = firstNumber / secondNumber;
                                Console.WriteLine($"{firstNumber} / {secondNumber}  = {result}");
                                screenClear();
                                break;
                            case "*":
                                result = firstNumber * secondNumber;
                                Console.WriteLine($"{firstNumber} * {secondNumber}  = {result}");
                                screenClear();
                                break;
                            default:
                                Console.WriteLine("Invalid operation.");
                                screenClear();
                                break;
                        }
                        break;
                    case "2":
                        isOpen = false;
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        screenClear();
                        break;
                }
            }

            Console.WriteLine("outside");
        }
    }
}
