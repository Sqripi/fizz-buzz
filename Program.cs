﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 101; i++)
            {
                if ((i % 3 == 0) & (i % 5 == 0))
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else 
                {
                    if ((i % 3) == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else
                    {
                        if ((i % 5) == 0)
                        {
                            Console.WriteLine("buzz");
                        }
                        else
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
                

            }
            Console.ReadLine();

        }
    }
}
