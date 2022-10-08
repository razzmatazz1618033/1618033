using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _1618033
{   
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your Numbers: ");
            var input = Console.ReadLine();
            var numbers = input.Split(',');

            foreach (var s in numbers)
            {
                Console.WriteLine(int.Parse(s)); // Вытаскивает число из строчки
            }
            Console.ReadLine();
        }
    }
}
