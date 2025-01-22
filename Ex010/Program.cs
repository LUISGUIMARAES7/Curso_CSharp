namespace Ex010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario;

            Console.WriteLine("Digite seu salário: ");
            salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Salário base: {0}", salario);

            if (salario > 2500)
            {
                salario = salario * 0.5 + salario;
                Console.WriteLine("Aumento de 5%");
            }
            else if (salario > 1250)
            {
                salario = salario * 0.10 + salario;
                Console.WriteLine("Aumento de 10%");
            }
            else 
            {
                salario = salario * 0.15 + salario;
                Console.WriteLine("Aumento de 15%");
            }

            Console.WriteLine("Valor final: {0}",salario);
        }
    }
}
