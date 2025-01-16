using System;

namespace Ex005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int nota1, nota2;

            //Console.WriteLine("Digite a primeira nota: ");
            //nota1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Digite a segunda nota: ");
            //nota2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("A média é {0}",(nota1 + nota2) / 2);

            double media, n1, n2;

            Console.Write("Digite a primeira nota: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a primeira nota: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            media = (n1 + n2) / 2;

            Console.WriteLine("A média é: {0}", media);

        }
    }
}
