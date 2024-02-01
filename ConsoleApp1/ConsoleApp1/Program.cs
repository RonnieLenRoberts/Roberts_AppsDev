using System;
using System.IO;

namespace Math
{

    public class Math
    {

        public double Add(double num1, double num2)
        {

            return num1 + num2;
        }
        public double Sub(double num1, double num2)
        {

            return num1 - num2;
        }
        public double Mul(double num1, double num2)
        {

            return num1 * num2;
        }
        public double Div(double num1, double num2)
        {

            return num1 / num2;
        }

    }

    class Program
    {

        static void Main(string[] args)
        {

            Math math = new Math();

            double num1, num2;

            Console.WriteLine("Enter num1: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2: ");
            num2 = double.Parse(Console.ReadLine());

            math.Add(num1, num2);
            math.Sub(num1, num2);
            math.Mul(num1, num2);
            math.Div(num1, num2);

            Console.WriteLine("Addition: " + math.Add(num1, num2));
            Console.WriteLine("Subtraction: " + math.Sub(num1, num2));
            Console.WriteLine("Multiplication: " + math.Mul(num1, num2));
            Console.WriteLine("Division: " + math.Div(num1, num2));

        }

    }
}