namespace Ex024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, soma, qtd;
            soma = qtd = 0;

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Digite um valor");
                n = Convert.ToInt32(Console.ReadLine());
                if (n % 2 == 0)
                {
                    soma += n;
                    qtd++;
                }
            }
            Console.WriteLine("A soma dos {0} valores pares é {1}",qtd, soma);
        }
    }
}
