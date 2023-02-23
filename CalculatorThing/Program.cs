using System;
using Figgle;

namespace CalculatorThing // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            var num1tmp = Console.ReadLine();
            Console.WriteLine("Enter the second number");
            var num2tmp = Console.ReadLine();
            float num1 = Convert.ToInt64(num1tmp);
            float num2 = Convert.ToInt64(num2tmp);

            //Console.WriteLine(num1 + num2);

            string total = Convert.ToString(num1 + num2);
            Console.WriteLine(FiggleFonts.Ogre.Render(total));
        }
    }
}