﻿using System;

namespace BaseLab4
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Введите число");
            int N = int.Parse(Console.ReadLine());
            bool[] A = new bool[N];
            double sqrt = Math.Sqrt(N) + 1;
            for (int i = 2; i < N - 1; i++)
            {
                if (!A[i])
                {
                    for (int j = i * i; j < N; j +=i)
                    {
                        A[j] = true; 

                    }
                }
            }
            Console.WriteLine();

            for (int i =2; i < N; i++)
            {
                if (!A[i])
                    Console.Write("{0} ", i);
            }
            
        }
    }
}
