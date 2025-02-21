using System;
using System.ComponentModel.Design;
using System.Net.Quic;

namespace Calculator
{
    class Program
    {
        static void Multiply(Double a, Double b)
        {
            Console.WriteLine("Your Output is " + a + "*" + b + "=" + (a * b));
        }

        static void Divide(Double a, Double b)
        {
            if (b > 0)
                Console.WriteLine("Your Output is " + a + "/" + b + "=" + (a / b));
            else
                Console.WriteLine("can't divide by 0");
        }

        static void Add(Double a, Double b)
        {
            Console.WriteLine("Your Output is " + a + "+" + b + "=" + (a + b));
        }

        static void Subtract(Double a, Double b)
        {
            Console.WriteLine("Your Output is " + a + "-" + b + "=" + (a - b));
        }

        static void Exponentiate(Double a, Double b)
        {
            Console.WriteLine("Your Output is " + a + "^" + b + "=" + Math.Pow(a, b));
        }

        static void check(char input)
        {
            if (input == 'X' || input == 'x')
                quit();
        }

        static void quit()
        {
            Console.Clear();
            Console.WriteLine("Thank you for using the calculator");
            Environment.Exit(0);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator");
            int counter = 1;
            while (true)
            {
                Console.WriteLine("this is operation number = " + counter++);
                Console.WriteLine("Please enter a number");
                Double x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter a number");
                Double y = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(
                    "Enter Your Operation ( Addition(+) , Subtraction(-) , Multiplication(*) , Division(/) , Exponentiation(^) ");
                String operation = Console.ReadLine();
                switch (operation)
                {
                    case "+":
                        Add(x, y);
                        break;
                    case "-":
                        Subtract(x, y);
                        break;
                    case "*":
                        Multiply(x, y);
                        break;
                    case "/":
                        Divide(x, y);
                        break;
                    case "^":
                        Exponentiate(x, y);
                        break;
                    default:
                        Console.WriteLine("Invalid Operation");
                        break;
                }
                Console.WriteLine("Enter any key to continue or X to quit");
                char final = Convert.ToChar(Console.ReadLine());
                check(final);
                Console.Clear();
            }
        }
    }
}