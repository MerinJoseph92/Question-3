using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Int32> numberList = new List<int>();

            Console.WriteLine("Enter the length of the list");
            int lengthOfList = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the numbers");

            do
            {
                try
                {
                    int userInput = int.Parse(Console.ReadLine());
                    numberList.Add(userInput);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter the valid number");
                }
            } while (numberList.Count < lengthOfList);

            HashSet< Int32 > duplicateSet = CheckforDuplicates(numberList);

            Console.WriteLine("Duplicates are : ");
            duplicateSet.ToList<Int32>().ForEach(x => Console.WriteLine(x));
           
            Console.Read();
        }

        public static HashSet<Int32> CheckforDuplicates(List<Int32> numberList)
        {
            var RepeatedNumbersList = new HashSet<Int32>();
            for (int i = 0, count = numberList.Count; i < count; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (numberList[i] == numberList[j])
                    {
                        RepeatedNumbersList.Add(numberList[i]);
                    }
                }
            }
            return RepeatedNumbersList;
        }
    }
  
}
