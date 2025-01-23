namespace Ex020
{
    internal class Program
    {
        static void Main(string[] args)
        {
         

            for (int i = 10; i >= 0; i--)
            {
                Thread.Sleep(1000);
                Console.WriteLine(i);
                
            }

            Console.WriteLine("Feliz Ano Novo!!!");


        }
    }
}
