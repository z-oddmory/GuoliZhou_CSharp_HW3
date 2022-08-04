using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = GenerateNumbers();
            Reverse(numbers);
            PrintNumbers(numbers);

        }
        public static int[] GenerateNumbers()
        {
            int start = Convert.ToInt32(Console.ReadLine());//?
            int end = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            List<int> numbers = new List<int>();
            for(int i = start; i <= end; i++)
            {
                numbers.Add(i);
            }
            int[] ans = numbers.ToArray();
            return ans;
        }

        public static int[] Reverse(int[] anArray)
        {
            //int[] newArray = new int[anArray.Length];
            for(int i = 0; i < anArray.Length/2; i++)//i < anArray.Length/2

            {
                //Console.WriteLine($"> the anArray[i] is {anArray[i]}");
                int temp = anArray[i];
                //Console.WriteLine($">> the temp is {temp}");
                //Console.WriteLine($">>> the anArray[anArray.Length - i - 1] is {anArray[anArray.Length - i - 1]}");
                anArray[i] = anArray[anArray.Length - i - 1];
                //Console.WriteLine($">>>> the anArray[i] is {anArray[i]}");
                anArray[anArray.Length - i - 1] = temp;
                //Console.WriteLine($">>>>> the anArray[anArray.Length - i - 1] is {anArray[anArray.Length - i - 1]}");
            }
            for (int i = 0; i < anArray.Length; i++)
            {
                Console.WriteLine("_______________________________");
                Console.WriteLine(anArray[i]);
            }
            Console.ReadKey();
            return anArray;
        }


        public static string PrintNumbers(int[] anArray)
        {
            
            string s = string.Join(" ", anArray);
            Console.WriteLine(s);
            Console.ReadKey();
            return s;
        }
    }
}
