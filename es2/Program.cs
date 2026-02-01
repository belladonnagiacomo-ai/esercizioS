namespace es2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci una stringa");
            string s = Console.ReadLine();
            char[] stringhe = s.ToCharArray();
            double metà = stringhe.Length / 2;
            for (int i = 0;i < metà; i++)
            {
                Console.Write(stringhe[i]);

            }
            Console.WriteLine("--------------");
            for (double i = metà; i < stringhe.Length; i++)
            {
                
                Console.Write(stringhe[(int)i]);
            }

        }
    }
}
