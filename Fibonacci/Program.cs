using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //do not using recursion
            int len = Convert.ToInt32(Console.ReadLine());
            Fibonacci(len);
            //recursion:

        }
        public static int Fibonacci(int length)
        {
            int[] nums = new int[length];
            nums[0] = 1;
            nums[1] = 1;            
            for(int i = 2; i <length; i++)
            {
                nums[i] = nums[i - 1] + nums[i - 2];
            }
            int element = Convert.ToInt32(Console.ReadLine());
            if (element <= length - 1) {
                Console.WriteLine($"The value of nums[element] is {nums[element]}");
                Console.ReadKey();
            }

            return nums[element];
        }
    }
}
