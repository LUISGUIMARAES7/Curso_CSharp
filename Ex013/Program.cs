namespace Ex013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anoAtual = 2024;
            int anoNasc, idade;

            Console.WriteLine("Digite seu ano de nascimento");
            anoNasc = Convert.ToInt32(Console.ReadLine());

            idade = anoAtual - anoNasc;

            if (idade < 18)
            {
                Console.WriteLine("Você ainda não tem idade para se alistar");
                Console.WriteLine("Faltam {0} anos", 18 - idade);

            }
            else if (idade == 18)
            {
                Console.WriteLine("Parabéns, você tem 18 anos e está na hora de se alistar!");
            }
            else 
            {
                Console.WriteLine("Você");
            }
        }
    }
}
