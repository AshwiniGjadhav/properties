using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student { Rollno = 2,Name = "viraj",Percentage = 58};
            Student s1 = new Student ();

             s1.Rollno = 1;
             s1.Name = "onkar";     
              s1.Percentage = 56;

            //Console.WriteLine($"details {1.Rollno} {s1.Name} {s1.Percentage}");
            Console.WriteLine(s);
            Console.WriteLine(s1);  
        }
    }
}
