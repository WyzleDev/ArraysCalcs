using System;
using System.Collections.Generic;
namespace ArraysCalcs
{
    internal class Program
    {
        static void Main()
        {
            //empty arrays for examples
            List<float> lst1 = new List<float>();
            List<float> lst2 = new List<float>();

            //fill arrays by random number
            for (int i = 0; i <= 4; i++)
            {
                Random rnd = new Random();
                float random = rnd.Next(1, 10);
                lst1.Add(random);
            }
            for (int i = 0; i <= 4; i++)
            {
                Random rnd = new Random();
                float random = rnd.Next(1, 10);
                lst2.Add(random);
            }
            
            //creating list of lists for transpose() func
            List<List<float>> total = new List<List<float>>();
            total.Add(lst1);
            total.Add(lst2);

            //calling all functions
            ArrayCalcs.multiply(lst1, lst2);
            ArrayCalcs.multiply_by_number(lst1, 2);
            ArrayCalcs.transpose(total);

        }
    } 
   

}