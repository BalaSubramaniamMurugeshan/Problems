using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the String :");
                String str = Console.ReadLine();
                char[] arr = str.ToCharArray();
                char[] arr1 = arr.Distinct().ToArray();                
                for (int i = 0; i < arr1.Length; i++)
                    Console.Write(arr1[i]);              
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
