﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            for(i = 1; i <= 15; i++)
            {
                if((i % 15) == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }

                else if ((i % 5) == 0)
                {
                    Console.WriteLine("Buzz");
                }

                else if ((i % 3) == 0)
                {
                    Console.WriteLine("Fizz");
                }

                else
                {
                    Console.WriteLine(i);
                }


            }



        }
    }
}
