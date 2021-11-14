using System;
using System.Threading.Tasks;


namespace FreeCodeCampCourseCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another Number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your opperation (+ - * /): ");
            string op  = Console.ReadLine();
            Calculator(num1, num2, op);
        }
        static void Calculator(double num1 , double num2, string op)
        {
            if (op == "+")
            {
                Console.WriteLine($"Adding {num1} and {num2}");
                double result = num1 + num2;
                Console.WriteLine(result);
            }
            else if (op == "-")
            {
                Console.WriteLine($"Subtracting {num1} and {num2}");
                double result = num1 - num2;
                Console.WriteLine(result);
            }
            else if (op == "/")
            {
                Console.WriteLine($"Dividing {num1} and {num2}");
                double result = num1 / num2;
                Console.WriteLine(result);
            }
            else if (op == "*")
            {
                Console.WriteLine($"Multiplying {num1} and {num2}");
                double result = num1 * num2;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("The Operator Entered is invalid !");
            }
        }

    }              
    
}
