using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void starPrint(int num)
            {
                int empty = num - 1;

                for (int i = 0; i < num; i++)
                {
                    for (int a = 0; a < empty; a++)
                        Console.Write(" ");
                    for (int a = 0; a <= i; a++)
                        Console.Write("* ");

                    Console.Write("\n");
                    empty--;
                }
                empty = 0;

                for (int i = num; i > 0; i--)
                {
                  
                    for (int a = 0; a < empty; a++)
                        Console.Write(" ");
                    for (int a= 0; a< i; a++)
                        Console.Write("* ");

                    Console.Write("\n");
                    empty++;
                }
            }

            // we call the function starPrint
            starPrint(5);

            
        }
    }
    }

