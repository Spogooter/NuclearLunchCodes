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
            //x.verticaldraw(Disarray);
            x.horisontaldraw(Disarray);
            Console.WriteLine();
            Console.ReadLine();
        }
        
    }
     class drawarray
    {
        public void verticaldraw(int[] k)
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
        public void horisontaldraw(int[] k)
        {
            int maxvalue = 0;
            // finder den største værdi i k
            foreach (int i in k)
            {
                if (i > maxvalue)
                {
                    maxvalue = i;
                }
            }

            for (int i = 0; i < maxvalue; maxvalue--)
            {
                for (int j = 0; j < k.Length; j++)
                {
                    if (k[j] >= maxvalue)
                    {
                        Console.Write("|");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
