using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Triangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the angles of traingles\n ");
            Console.WriteLine("Enter Frist Angle\n");
            Double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Second Angle\n");
            Double x2= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Third Angle\n");
            Double x3 = Convert.ToDouble(Console.ReadLine());
            if(x1+x2+x3==180)
            {
                Console.WriteLine("Triangle is valid");
               
            }
            else
            {
                Console.WriteLine("Triangle is not valid");
            }
            Console.ReadLine();
        }
    }
}
