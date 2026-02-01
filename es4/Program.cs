using static System.Runtime.InteropServices.JavaScript.JSType;

namespace es4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dammi una frase");
            string frase = Console.ReadLine();
            string[] parole = frase.Split(" ");
            for (int i = parole.Length - 1; i >= 0; i--)
            {

                Console.Write(parole[i]);
                Console.Write("  ");

            }
        }
    }
}
