using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designing_and_Building_Classes2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student aStudent = new Student();
            Instructor aInstructor = new Instructor();
            aStudent.Duty();
            aInstructor.Duty();
            Console.ReadKey();
        }
    }
}
