namespace Ex031
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string senha = "123"; 
            string senhaDigitada;
            int tentativas = 0;

            do
            {
                Console.Clear();   
                Console.Write("Digite a senha: ");
                senhaDigitada = Console.ReadLine();
                tentativas++;
                if ( senhaDigitada != senha & tentativas < 3)
                {
                    Console.WriteLine("Senha incorreta");
                    Console.WriteLine("Você ainda tem " + (3 - tentativas) + " tentativas");
                    Console.ReadKey();
                } 
                else if ( senhaDigitada == senha)
                {
                    Console.Clear();
                    Console.WriteLine("Senha correta! - Tentativas: " + tentativas);
                    return;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Senha incorreta. Seu acesso está bloqueado.");
                    return;
                }
            } while (senhaDigitada != senha);

            
            

           
        }
    }
}
