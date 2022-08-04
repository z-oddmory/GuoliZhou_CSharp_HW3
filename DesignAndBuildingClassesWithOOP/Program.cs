using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignAndBuildingClassesWithOOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student aStudent = new Student();
            aStudent.Name = "M";
            aStudent.Age = 23;
            aStudent.Sex = 0;
            aStudent.LoveStudyingOrNot = false;

            Leader aLeader = new Leader();
            aLeader.ExtraBonus = 10000000;

            aStudent.Read();
            Console.ReadKey();
                
        }
    }
}
