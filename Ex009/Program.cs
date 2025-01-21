namespace Ex009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ladoA, ladoB, ladoC;

            while (true)
            {

                Console.Write("Digite o valor do lado A: ");
                ladoA = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o valor do lado B: ");
                ladoB = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o valor do lado C: ");
                ladoC = Convert.ToInt32(Console.ReadLine());

                if (ladoA < ladoB + ladoC && ladoB < ladoA + ladoC && ladoC < ladoA + ladoB)
                {
                    Console.Write("O valores informados formam um triângulo: ");

                    if (ladoA == ladoB && ladoB == ladoC)
                    {
                        Console.WriteLine("Equilátero");
                    }
                    else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
                    {
                        Console.WriteLine("Isósceles");
                    }
                    else
                    {
                        Console.WriteLine("Escaleno");
                    }
                }
                else
                {
                    Console.WriteLine("O valores informados não formam um triângulo.");
                }

                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            }

        }               
    }
}
