namespace Exx007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota_final = 60;
            string resultado;

            if (nota_final >= 60)
            {
                resultado = "Aprovado";
            }
            else if (nota_final >= 40 & nota_final < 60)
            {
                resultado = "Recuperação";
            }
            else
            {
                resultado = "Reprovado";
            }


            Console.WriteLine("O aluno está {0}.", resultado);

        }
    }
}
