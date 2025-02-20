using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator");
            int counter = 1;
            while (true)
            {
                Console.WriteLine("this is operation number = " + counter++);
                Console.WriteLine("Please enter a number");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter a number");
                int y = Convert.ToInt32(Console.ReadLine());
                ;
                Console.WriteLine(
                    "Enter Your Operation ( Addition(+) , Subtraction(-) , Multiplication(*) , Division(/) , Exponentiation(^) ");
                String operation = Console.ReadLine();
                switch (operation)
                {
                    case "+":
                        Console.WriteLine("Your Output is " + x + "+" + y + "=" + (x + y));
                        break;
                    case "-":
                        Console.WriteLine("Your Output is " + x + "-" + y + "=" + (x - y));
                        break;
                    case "*":
                        Console.WriteLine("Your Output is " + x + "*" + y + "=" + (x * y));
                        break;
                    case "/":
                        Console.WriteLine("Your Output is " + x + "/" + y + "=" + (x / y));
                        break;
                    case "^":
                        Console.WriteLine("Your Output is " + x + "^" + y + "=" + Math.Pow(x,y));
                        break;
                    default:
                        Console.WriteLine("Invalid Operation");
                        break;
                }
                Console.WriteLine("Enter any key to continue or X to quit");
                char check = Convert.ToChar(Console.ReadLine());
                if (check == 'X' || check == 'x')
                {
                    Console.Clear();
                    Console.WriteLine("Thank you for using the calculator");
                    return;
                }
                Console.Clear();
            }
        }
    }
}