namespace Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int [4,3];

            matriz[0,0] = 10;
            matriz[0,1] = 20;        
            matriz[0,2] = 30;
          
            matriz[1,0] = 40;
            matriz[1,1] = 50;
            matriz[1,2] = 60;
           
            matriz[2,0] = 70;
            matriz[2,1] = 80;
            matriz[2,2] = 90;
           
            matriz[3,0] = 15;
            matriz[3,1] = 25;
            matriz[3,2] = 35;



            for (int linha = 0; linha < 4; linha++) 
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write(matriz[linha,coluna] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine(matriz.GetLength(0));
            Console.WriteLine(matriz.GetLength(1));
        }
    }
}
