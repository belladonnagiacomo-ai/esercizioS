using System.ComponentModel;

namespace esercizioS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un numero binario lungo 8 bit");
            string nome = Console.ReadLine();
            double somma = 0, risultato = 0;
            char[] decimale = nome.ToCharArray();
            for(int i = 1; i <= decimale.Length; i++)
            {

                if (decimale[i - 1] == '0')
                {
                    Console.WriteLine("zero");
                }
                else {
                    risultato = Math.Pow(2, decimale.Length - i);
                    somma = somma + risultato;
                }

                    
                
            }
            Console.WriteLine("Il numero convertito e: " + somma);
        }
    }
}
