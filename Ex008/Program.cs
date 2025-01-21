namespace Ex008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            while (true)
            {

                Console.Write("Digite um número: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.WriteLine("o número {0} é par", num);
                }
                else
                {
                    Console.WriteLine("o número {0} é ímpar", num);
                }

                Console.WriteLine("--------------------");
            }
        }
    }
}
