namespace Ex011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorCasa, salario, prestacaoMensal;
            int anosEmprestimo, mesesEmprestimo;

            Console.Write("Digite o valor da casa: ");
            valorCasa = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite seu salário: ");
            salario = Convert.ToDouble(Console.ReadLine());

            Console.Write("Quantos anos de empréstimo: ");
            anosEmprestimo = Convert.ToInt32(Console.ReadLine());

            mesesEmprestimo = anosEmprestimo * 12;

            prestacaoMensal = valorCasa / mesesEmprestimo;


            if (prestacaoMensal < salario * 0.30) 
            {
                Console.WriteLine("Empréstimo aceito");
                Console.WriteLine("Parcelas: {0}", mesesEmprestimo);
                Console.WriteLine("Valor: {0} mensais", prestacaoMensal);
            }
            else
            {
                Console.WriteLine("Empréstimo negado");
                Console.WriteLine("O valor das prestações ultrapassa 30% do seu salário.");
            }

        }
    }
}
