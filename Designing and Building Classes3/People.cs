using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designing_and_Building_Classes3
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
        public virtual void CalSalary()
        {
            Console.WriteLine("What is your Salary?");
        }
    }
    public class Student : People
    {
        private int sId;
        
        public int Id
        {
            get { return sId; }
            private set { sId = value; } 
        }
        //public override void duty()
        //{
        //    //base.duty();
        //    console.writeline("i'm learning");
        //}
        //if we commet these codes, the Student could still have the behavior Duty()
        //or if we choose to use override, the Student can use its own behavior.
    }
    public class Instructor : People
    {
        private int hireId;
        public int tId
        {
            get { return hireId; }
            set { hireId = value; }
        }
        public override void Duty()
        {
            //base.Duty();
            Console.WriteLine("I'm teaching");
        }
        public decimal CalSalary(decimal a, decimal b)
        {
            //base.Duty();
            return a + b;
        }
    }


}
