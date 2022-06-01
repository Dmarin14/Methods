using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            Console.Write("Enter your favorite color: ");
            string favColor = Console.ReadLine();
            Console.Write("Enter your favorite animal: ");
            string favAnimal = Console.ReadLine();
            Console.Write("Enter your favorite band: ");
            string favBand = Console.ReadLine();

            Console.WriteLine($"Hello, {userName} your favorite color is: {favColor}, your favorite animal is: {favAnimal}," +
                $"and your favorite band is: {favBand}");
           

            int testMethod = Add(6, 7, 9, 4, 2, 3);
            Console.WriteLine(testMethod);

            Console.ReadLine();

        }

        public static int Add(params int[] numbers)
        {
            int total = 0;
            for (int i = 0; i < numbers.Length; i++)
                total += numbers[i];
            return total;
        }

       public static int Multiply(params int[] numbers)
        {
            int total = 0;
            for (int i = 0; i < numbers.Length; i++)    
                total *= numbers[i];
            return total;
        }
    }
}
