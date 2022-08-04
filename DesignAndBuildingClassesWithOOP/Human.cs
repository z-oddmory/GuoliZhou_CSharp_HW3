using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignAndBuildingClassesWithOOP
{
    internal abstract class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Sex { get; set; }
        public string Address { get; set; }

        public virtual void Read()
        {
            Console.WriteLine("Read more, learn more.");
        }
        public Human(string name, int age, int sex, string address)
        {
            Name = name;
            Age = age;
            Sex = sex;
            Address = address;
        }

    }


}
