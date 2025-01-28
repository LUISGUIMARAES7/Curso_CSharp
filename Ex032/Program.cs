namespace Ex032
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5] ;

            num[0] = 10 ; 
            num[1] = 20 ; 
            num[2] = 30 ; 
            num[3] = 50 ; 
            num[4] = 60 ;

            Console.WriteLine(num[4]);

            int[] n = new int[5] {70, 80, 90, 100, 110 };

            Console.WriteLine(n[2]);

            int[] numero = { 12, 21, 23, 43, 34, 34 };

            Console.WriteLine(numero[2]);
        }
    }
}
