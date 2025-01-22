namespace Ex012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.Write("Digite o primeiro valor: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine("O primeiro valor é maior.");
            }
            else if (n1 < n2) 
            {
                 Console.WriteLine("O segundo valor é maior.");
            }
            else
            {
                Console.WriteLine("Não existe valor maior, os dois são iguais.");
            }

        }
    }
}
