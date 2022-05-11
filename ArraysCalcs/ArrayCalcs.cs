using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysCalcs
{
    public class ArrayCalcs
    {
        //function that multiply two arrays 
        static public List<float> multiply(List<float> lst1, List<float> lst2)
        {
            //creating a result list
            List<float> result = new List<float>();

            //iterate over the values of two arrays
            for (int i = 0; i <= lst1.Count-1; i++) //iteraiting over first array
            {
                for (int j = 0; j <= lst2.Count-1; j++) //iteraiting over second array
                {
                    result.Add(lst1[i] * lst2[j]); //Multiply item of first array by item of second array
                }
            }
            for (int i = 0; i <= result.Count-1; i++) //cycle that return string with items of lists
            { 
                Console.Write(result[i] + " ");
            }
            Console.WriteLine("//Massive multiplied by other massive");
            return result;

        }
        //function that mutliplys array by number
        static public List<float> multiply_by_number(List<float> lst, float n)
        {
            Console.WriteLine(); // no comments :D

            //creating a result list
            List<float> result = new List<float>();

            //iteraiting over array and multiply his values by number
            for (int i = 0; i <= lst.Count - 1; i++)
            {
                result.Add(lst[i]*n);
            }

            //cycle that return string with items of lists
            for (int i = 0; i <= result.Count - 1; i++)
            {
                
                Console.Write(result[i] + " ");
            }
            Console.WriteLine("//Massive multiplied by number");
            return result;
        }
        //Function that transpose arrays
        public static List<List<T>> transpose<T>(List<List<T>> lists)
        {
            var longest = lists.Any() ? lists.Max(l => l.Count) : 0;
            List<List<T>> outer = new List<List<T>>(longest);
            for (int i = 0; i < longest; i++)
                outer.Add(new List<T>(lists.Count));
            for (int j = 0; j < lists.Count; j++)
                for (int i = 0; i < longest; i++)
                    outer[i].Add(lists[j].Count > i ? lists[j][i] : default(T));
            return outer;
        }

    }
}
