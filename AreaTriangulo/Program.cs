namespace AreaTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============================");
            Console.WriteLine(" Calcular Área do Triângulo");
            Console.WriteLine("============================");
            Console.WriteLine();

            Console.WriteLine("Digite a base do triângulo (m): ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite a altura do triângulo (m): ");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            AreaTriangulo(b, h);
        }

        static void AreaTriangulo(double b, double h)
        {
            double area = b * h / 2;
            Console.WriteLine($"A área do triângulo é {area:F2}m²");
        }
    }
}
