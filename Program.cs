using System;

namespace hw1Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ex1");
            Console.WriteLine("Enter value a:");
            double valueA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value b:");
            double valueB = Convert.ToDouble(Console.ReadLine());
            double result = (valueA * 5 + Math.Pow(valueB, 2)) / (valueB - valueA);
            Console.WriteLine($"Result: {result}");
            Console.WriteLine();

            Console.WriteLine("Ex2");
            Console.WriteLine("Enter string a:");
            string stringA = Console.ReadLine();
            Console.WriteLine("Enter string b:");
            string stringB = Console.ReadLine();
            string tmpString = stringA;
            stringA = stringB;
            stringB = tmpString;
            Console.WriteLine("Result: " + stringA + " " + stringB);
            Console.WriteLine();

            Console.WriteLine("Ex3");
            Console.WriteLine("Enter number 1:");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2:");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            int intOfDivision = numberOne / numberTwo;
            int lessOfDivision = numberOne % numberTwo;
            Console.WriteLine($"Result: int of division -> {intOfDivision}, less of division -> {lessOfDivision}");
            Console.WriteLine();

            Console.WriteLine("Ex4");
            Console.WriteLine("Enter value а:");
            double valueAA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value b:");
            double valueBB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value c:");
            double valueCC = Convert.ToDouble(Console.ReadLine());
            double resultX = (valueCC - valueBB) / valueAA;
            Console.WriteLine($"Result: х = {resultX}");
            Console.WriteLine();

            Console.WriteLine("Ex5");
            Console.WriteLine("Enter x for point 1:");
            double pointOneX = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y for point 1:");
            double pointOneY = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter x for point 2:");
            double pointTwoX = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y for point 2:");
            double PointTwoY = Convert.ToDouble(Console.ReadLine());
            double k = (pointOneY - PointTwoY)/(pointOneX - pointTwoX);
            double b = PointTwoY - k * pointTwoX;
            Console.WriteLine($"Result: y = {k}*x + {b}");
        }
    }
}
