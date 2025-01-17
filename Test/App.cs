using Calculator;
using System;
using System.Runtime.InteropServices;

namespace App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(RuntimeInformation.FrameworkDescription);
            var calc = new Calculator.Calculator();
            Console.WriteLine(calc.Add(1, 2));
            Console.WriteLine("Done!");
        }
    }
}