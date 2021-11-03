using System;
using System.Text;
namespace _1859_Sorting_the_Sentence_String_Easy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String : ");
            string input = Console.ReadLine();
            string result = SortString(input);
            Console.WriteLine(result);
        }
        public static string SortString(string s) 
        {
            string[] splitString = s.Split(" ");
            string[] sortedResult = new string[splitString.Length];
            StringBuilder result = new StringBuilder();
            string temp;
            int index = 0;
            for(int str = 0; str < splitString.Length; str++) 
            {
                temp = splitString[str];
                index = Int32.Parse(temp[temp.Length - 1].ToString());
                sortedResult[index-1] = splitString[str];
            }
            for (int str = 0; str < sortedResult.Length; str++) 
            {
                index = 0;
                while (index < sortedResult[str].Length - 1) 
                {
                    result.Append(sortedResult[str][index]);
                    index++;
                }
                if (str != sortedResult.Length - 1) 
                {
                    result.Append(" ");
                }
            }
            return result.ToString();


        }
    }
}
