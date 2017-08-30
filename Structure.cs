using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleProgramming
{
    class Structure
    {
        static void Main(string[] arg)
        {
            Student s = new Student();
            s.age = 20;
            s.name = "sufyan";
            s.Display();
           
            Console.ReadKey();

        }

        struct Student
        {
            public int age;
            public string name;

           public void Display()
            {
                Console.WriteLine("{0}",age);
                Console.WriteLine("my name is {0}", name);
                
               

            }
        }
        
    }
}
