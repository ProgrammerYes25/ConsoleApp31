using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            while(x < 50){
                Console.Clear();
                Console.SetCursorPosition(x, 5);

                if (x % 3 == 0)
                {
                    Console.WriteLine("__0");

                }
                else if (x % 3 == 1)
                {
                    Console.WriteLine("_^0");
                    
                }
                else 
                {
                    Console.WriteLine("^_0");
               
                }

                Thread.Sleep(100);
                x++;
            }
        }
    }
}
