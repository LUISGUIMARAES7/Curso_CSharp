namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Luís";
            Saudacao(nome);

            Soma(5, 7);

            SomaVariosNum(1, 2, 3, 4, 5, 6);
        }

        static void Saudacao(string nome)
        {
            Console.WriteLine($"Olá {nome}, seja bem-vindo!");
        }

        static void Soma(int a, int b)
        {
            int res = a + b;
            Console.WriteLine($"A soma de {a} + {b} é igual a {res}");
        }

        static void SomaVariosNum(params int[] a)
        {
            int soma = 0;
            foreach (int i in a)
            {
                soma += i;
            }
            Console.WriteLine($"A soma dos valores é {soma}");
        }
    }

    
}
