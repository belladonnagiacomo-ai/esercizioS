using System.ComponentModel;

namespace esercizioS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un numero binario lungo 8 bit");
            string n = Console.ReadLine();
            double somma = 0;
            char[] decimale = n.ToCharArray();
            for(int i = 0; i < decimale.Length; i++)
            {

                double risultato = Math.Pow(2,i);
                Console.WriteLine(somma);
                somma = somma + risultato;
                
            }
            Console.WriteLine("Il numero convertito e: " + somma);
        }
    }
}
