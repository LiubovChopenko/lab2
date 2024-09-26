using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1
            double a = 2.8;
            double b = -0.3;
            double x;
            double y;
            Console.WriteLine("Input x");
            x = Convert.ToDouble(Console.ReadLine());
            if (x < 1.2)
            {
                y = a * Math.Pow(x, 2) + b * x;
            }
            else if (x == 1.2)
            {
                y = (a) / (x + Math.Sqrt(x * x + 1));
            }
            else if (x > 1.2) ;
            {
                y = (a + b * x) / (Math.Sqrt(x * x + 1));
            }
            Console.WriteLine($"Значення y при x = {x}: y = {y}");
            
            Console.ReadKey();

  }
                

            }
            }
        
    


