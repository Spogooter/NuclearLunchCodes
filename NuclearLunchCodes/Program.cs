using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuclearLunchCodes
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] Disarray = new int[] { 8, 12, 3, 20, 7, 8, 12, 15, 2, 10, 33, 14, 3, 20 };
            drawarray x = new drawarray();
            x.draw(Disarray);
            Console.WriteLine();
            Console.ReadLine();
        }
        
    }
     class drawarray
    {
        public void draw(int[] k)
        {
            
            for (int i = 0; i < k.Length; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < k[i]; j++)
                {
                    Console.Write("-");
                }

            }
        }
    }
}
