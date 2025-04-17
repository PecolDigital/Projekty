using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kalkulator!");

            double num1, num2, result;
            string operation;

            Console.Write("Podaj pierwszą liczbę: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj drugą liczbę: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Wybierz operację (+, -, *, /): ");
            operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"Wynik: {num1} + {num2} = {result}");
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"Wynik: {num1} - {num2} = {result}");
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"Wynik: {num1} * {num2} = {result}");
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Wynik: {num1} / {num2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Nie można dzielić przez zero!");
                    }
                    break;
                default:
                    Console.WriteLine("Nieznana operacja.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
