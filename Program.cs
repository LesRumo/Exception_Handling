using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                Console.WriteLine("Enter ur first num ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter ur sec num ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("num1 divided by num2 = ");
                Console.WriteLine(num1 / num2);

            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("thats not a digit");

            }

            Console.ReadLine();


        }
    }
}
