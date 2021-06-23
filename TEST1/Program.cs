using System;
using System.Collections.Generic;

namespace TEST1
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "TODAY TODAY IS A GOOD DAY";
            count(str);
        }

        static void count(string str)
        {
            SortedDictionary<string, int> word = new SortedDictionary<string, int>();
            string[] arr = str.Split(' ');   //splitting 

            for (int i = 0; i < arr.Length; i++)
            {

                // Condition to check if the
                // array element is present
                // the hash-map
                if (word.ContainsKey(arr[i]))
                {
                    word[arr[i]] = word[arr[i]] + 1;
                }
                else
                {
                    word.Add(arr[i], 1);
                }
            }
            foreach (KeyValuePair<String, int> entry in word)
            {
                Console.WriteLine(entry.Key + " - " +
                                  entry.Value);
            }
        }
    }
}


    
   

      

      



