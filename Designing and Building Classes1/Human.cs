using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designing_and_Building_Classes1
{
    internal abstract class Human
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public int Sex { get; set; }
        public string Address { get; set; }

        public virtual void Read()
        {
            Console.WriteLine("Read more,learn more.");
        }
    }

    internal class Leader: Human
    {
        public decimal MyProperty { get; set; }
        public override void Read()
        {
            //base.Read();
            Console.WriteLine("Reading 100 books during a year.");
        }
    }

    internal class Student : Human
    {
        public bool LoveStudying { get; set; }
        //public override void Read()
        //{
        //    //base.Read();
        //    Console.WriteLine("Reading 500 books during a year.");
        //}
    }


}
