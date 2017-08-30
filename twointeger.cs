using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleProgramming
{
    class twointeger
    {
        static void Main(string[] arg)
        {
            int a;
            int b;
            Console.WriteLine("enter two integer ");
            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("result is " + (a + b));
            Console.ReadKey();
        }
    }
}
