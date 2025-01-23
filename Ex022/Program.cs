namespace Ex022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma, qtd;
            soma = qtd = 0;


            for (int i = 1; i <= 500; i++)
            {
                
                if (i % 3 == 0)
                {
                    soma += i;
                    qtd++;
                }  

            }

            Console.WriteLine("A soma dos {0} valores é: {1}", qtd,soma);
 
        }
    }
}
