namespace Ex024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string genero;

            Console.Write("Digite o seu gênero: ");
            genero = Console.ReadLine().ToUpper();

            int n, soma, qtd;
            soma = qtd = 0;

            while (genero != "F" && genero != "M")
            {
                Console.Write("Digite o seu gênero: ");
                genero = Console.ReadLine();
            }

            Console.WriteLine("Ok");
        }
    }
}
