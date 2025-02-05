namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite sua altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double indice = peso / (altura * altura);

            Console.WriteLine($"Seu IMC é {indice:F2}");
        }

    }
}
