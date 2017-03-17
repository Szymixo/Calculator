using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace Calculator
{
    class calc
    {
        static void Main(string[] args)
        {
            float a, b, result;
			
            Console.WriteLine("Type your first number:");
            a = Convert.ToInt32(Console.ReadLine());
			
            Console.WriteLine("Type yout second number:");
            b = Convert.ToInt32(Console.ReadLine());
			
            result = a + b;
            Console.WriteLine(a + "+" + b + " = " + result);
			
            result = a - b;
            Console.WriteLine(a + "-" + b + " = " + result);
			
            result = a * b;
            Console.WriteLine(a + "*" + b + " = " + result);
			
			result = a / b;
			Console.WriteLine(a + ":" + b + " = " + result);
			
            Console.ReadKey();
            Console.Clear();
        }
    }
}