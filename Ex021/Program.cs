﻿namespace Ex021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int final;

            Console.WriteLine("Digite um número");
            final = int.Parse(Console.ReadLine());

            for (int i = 1; i <= final; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0}, ",i);
                }
            }
        }
    }
}
