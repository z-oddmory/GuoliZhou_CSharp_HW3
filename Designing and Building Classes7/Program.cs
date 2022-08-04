using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designing_and_Building_Classes7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Color newColor = new Color(255,255,255);
            Console.WriteLine(newColor.CalGrey());
            newColor.Red = 400;
            Console.WriteLine(newColor.Red);
            Console.WriteLine(newColor.CalGrey());
            
            Console.ReadKey();
            
            
        }
    }
}
