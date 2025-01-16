namespace Ex004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.Write("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine("{0}x{1}={2}", numero, i, numero * i);
            //}

            Console.WriteLine("{0} x 0 = {1}", numero, numero * 0);
            Console.WriteLine("{0} x 1 = {1}", numero, numero * 1);
            Console.WriteLine("{0} x 2 = {1}", numero, numero * 2);
            Console.WriteLine("{0} x 3 = {1}", numero, numero * 3);
            Console.WriteLine("{0} x 4 = {1}", numero, numero * 4);
            Console.WriteLine("{0} x 5 = {1}", numero, numero * 5);
            Console.WriteLine("{0} x 6 = {1}", numero, numero * 6);
            Console.WriteLine("{0} x 7 = {1}", numero, numero * 7);
            Console.WriteLine("{0} x 8 = {1}", numero, numero * 8);
            Console.WriteLine("{0} x 9 = {1}", numero, numero * 9);
            Console.WriteLine("{0} x 10 = {1}", numero, numero * 10);



        }
    }
}
