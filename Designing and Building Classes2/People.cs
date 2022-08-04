using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designing_and_Building_Classes2
{
    public class People
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public virtual void Duty()
        {
            Console.WriteLine("What is your duty?");
        }
    }
    public class Student : People
    {
        public override void Duty()
        {
            //base.Duty();
            Console.WriteLine("I'm learning");
        }

    }
    public class Instructor : People
    {
        public override void Duty()
        {
            //base.Duty();
            Console.WriteLine("I'm teaching");
        }
    }
}
