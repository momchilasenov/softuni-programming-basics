﻿using System;

namespace _03._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string command = Console.ReadLine();
            int sumPrime = 0;
            int sumNotPrime = 0;

            while (command != "stop")
            { 
                int number = int.Parse(command);
                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    command = Console.ReadLine();
                    continue;
                }
                int count = 0; 

                
                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0) 
                    {
                        count++; 
                    }

                }
                if (count == 2) 
                {
                    sumPrime += number;
                }
                else
                {
                    sumNotPrime += number;
                }

                command = Console.ReadLine(); 
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNotPrime}");
        }
    }
}
