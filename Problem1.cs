using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    public class TextInput
    {
        public String str = "";
        public virtual void Add(char c)
        {  
        }
        public string GetValue()
        {
            return str;
        }
    }
    public class NumericInput : TextInput
    {
        public override void Add(char c)
        {
            if(char.IsDigit(c))
            str = str + c;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TextInput input = new NumericInput();
                char choice = '\0';
                do
                {
                    Console.Write("Enter the element : ");
                    char element = Convert.ToChar(Console.ReadLine());
                    input.Add(element);
                    Console.Write("Do you want to enter another element (y/n) : ");
                    choice = Convert.ToChar(Console.ReadLine());
                } while (choice == 'y');
                Console.WriteLine(input.GetValue());
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
