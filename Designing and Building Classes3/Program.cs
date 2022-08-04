using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designing_and_Building_Classes3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student aStudent = new Student();
            aStudent.Duty();
           

            Instructor aInstructor = new Instructor();

            string s = Convert.ToString(aInstructor.CalSalary(4000, 3000));
            Console.WriteLine(s);
            Console.ReadKey();

        }
    }
}
