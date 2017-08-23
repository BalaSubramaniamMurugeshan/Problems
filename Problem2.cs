using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        public IEnumerable<Tuple<int, int>> FindTwoSum(List<int> list,int sum)
        {
            List <Tuple<int, int>> AnswerList = new List <Tuple<int, int>>();
            for (int i = 0; i < list.Count; i++)            
                for (int j = 0; j < list.Count; j++)                
                    if (list[i] + list[j] == sum)                    
                        AnswerList.Add(new Tuple<int, int>(list[i], list[j]));      
            foreach (var element in AnswerList)            
               yield return element;            
        }
        static void Main(string[] args)
        {
            try
            {
                Program obj = new Program();
                Console.WriteLine("Enter the number of elements in the list :");
                int num = int.Parse(Console.ReadLine());
                List<int> list = new List<int>();
                Console.WriteLine("Enter the elements of the list :");
                for(int i=0;i<num;i++)
                {
                    int element = int.Parse(Console.ReadLine());
                    list.Add(element);
                }
                Console.WriteLine("Enter the sum to be found :");
                int sum = int.Parse(Console.ReadLine());
                Console.WriteLine("The elements that sum up to given value are ");
                var Answers = obj.FindTwoSum(list,sum);
                foreach (var tuple in Answers)
                    Console.WriteLine(tuple);
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
