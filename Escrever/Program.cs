namespace Escrever
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Escrever("Luís Fernando Guimarães");
            Console.WriteLine();
            Escrever("Curso C#");
            Console.WriteLine();
            Escrever("Olá");
            Console.WriteLine();
        }

        static void Escrever(string texto)
        {
            int tam = texto.Length + 4;
            string linha = new string('=', tam);
            string textoCentralizado = texto.PadLeft(tam - 2).PadRight(tam - 2);

            Console.WriteLine(linha);
            Console.WriteLine(textoCentralizado);
            Console.WriteLine(linha);
        }
    }
}
