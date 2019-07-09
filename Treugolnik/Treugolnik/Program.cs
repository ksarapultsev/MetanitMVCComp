using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treugolnik
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            var v = int.Parse(Console.ReadLine());

           
            for (int j = 0; j < v; j++)
            {
                for (int i = 0; i < v; i++)
			{
			 Console.Write("*");
			}
                
                
                    Console.WriteLine();
                }
                
            }

            /*
             
             5
             *
             * *
             * **
             * ***
             * ****
             
              
             * */


        }
    }
}
