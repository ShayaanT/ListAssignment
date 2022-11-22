using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListAssignment
{
    class Program
    {
        static void Main(string[] args)
        {


            
            int[] multiple = new int[2];
            int multiplier = 0;
            var friends = new List<int>();
            Console.Write("How many friends do you have?");
            int k = Convert.ToInt32(Console.ReadLine());

            for (int x = 1; x <= k; x++)
            {
                friends.Add(x);
            }


            Console.Write("How many rounds of removal?");
            int m = Convert.ToInt32(Console.ReadLine());
            multiple = new int[m];

            for (int y = 0; y < m; y++)
            {
                for (int z = 1; z <= 1; z++)
                {
                    Console.Write("What multiple would you like for round " + (y+1) + " of removal");
                    multiplier = Convert.ToInt32(Console.ReadLine());
                    
                }
                
                multiple[y] = multiplier;

            }

            for (int b = 0; b < multiple.Length; b++)
            {

                for (int a = 0; a < friends.Count; a++)
                {
                    if (friends[a] % multiple[b] == b + b)
                    {
                        friends.RemoveAt(a);
                    }

                }
            }

            for (int c = 0; c < friends.Count; c++)
            {
                Console.WriteLine(friends[c]);
            }

            Console.ReadLine();


        }
    }
}
