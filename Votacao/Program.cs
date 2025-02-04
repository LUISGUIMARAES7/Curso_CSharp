namespace Votacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual seu ano de nascimento? ");
            int nasc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(Voto(nasc));

        }

        static string Voto(int ano)
        {
            DateTime dataAtual = DateTime.Now;
            int anoAtual = dataAtual.Year;

            int idade = anoAtual - ano;
            if (idade < 16)
            {
                return $"Com {idade} anos você não vota!";
            }
            else if (idade >= 18 && idade < 70)
            {
                return $"Com {idade} anos você vota!";
            }
            else
            {
                return $"Com {idade} anos seu voto é opcional!";
            }
        }
    }
}
