namespace Ex032
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] num = new int[5] ;

            //num[0] = 10 ; 
            //num[1] = 20 ; 
            //num[2] = 30 ; 
            //num[3] = 50 ; 
            //num[4] = 60 ;

            //Console.WriteLine(num[4]);

            //int[] n = new int[5] {70, 80, 90, 100, 110 };

            //Console.WriteLine(n[2]);

            //int[] numero = { 12, 21, 23, 43, 34, 34 };

            //Console.WriteLine(numero[2]);

            //Random random = new Random();
            //int[] vetor = new int[10];

            //for (int i = 0; i < 10; i++)
            //{
            //    vetor[i] = random.Next(1,100);
            //    Console.WriteLine(vetor[i]);
            //}

            //Console.WriteLine();

            //double[] reais = new double[10];

            //for (int i = 0; i < 10; i++)
            //{
            //    reais[i] = random.NextDouble() * 10000;
            //    Console.WriteLine(reais[i].ToString("P2") );
            //}

            string[] nomes = { "Maria", "João", "Carlos", "José", "Neymar", "Cristiano" };

            for (int i = 0; i < nomes.Length; i++)
            {
                if (i < nomes.Length - 1)
                {
                    Console.Write(nomes[i] + ", ");
                }
                else
                {
                    Console.Write(nomes[i] + ".");
                }

            }




        }
    }
}
