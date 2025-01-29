namespace Ex033
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] frutas = { "Maça", "Banana", "Manga", "Uva", "Pêra", "Jaca", "Laranja", "Acerola", "Goiaba", "Limão" };
            double[] preço = { 10, 4, 5, 15, 14, 20, 6, 8, 9, 5 };

            for (int i = 0; i < frutas.Length; i++)
            {
                Console.WriteLine("O preço da " + frutas[i] + " é R$" + preço[i]);
            }
             

        }
    }
}
