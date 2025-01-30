namespace Ex033
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] frutas = { "Maça", "Banana", "Manga", "Uva", "Pêra", "Jaca", "Laranja", "Acerola", "Goiaba", "Limão" };
            double[] precos = { 10, 4, 5, 15, 14, 20, 6, 8, 9, 5 };

            for (int i = 0; i < frutas.Length; i++)
            {
                Console.WriteLine("O preço da " + frutas[i] + " é R$" + precos[i]);
            }

            Console.WriteLine();
            Console.WriteLine("O maior preço é {0}", precos.Max());
            Console.WriteLine("O menor preço é {0}", precos.Min());
            Console.WriteLine("A média dos preços é {0}", precos.Average());

        }
    }
}
