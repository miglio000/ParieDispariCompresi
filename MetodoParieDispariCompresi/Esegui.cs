using System;

namespace MetodoParieDispariCompresi
{
    public class Esegui
    {
        public static uint InserisciInteroPositivo()
        {
            Console.WriteLine("Inserisci un numero intero - positivo: ");
            uint n = uint.Parse(Console.ReadLine());
            return n;
        }
        public static void ContaPariDispari(uint n1, uint n2)
        {
            uint c_pari=0, c_dispari=0;
            uint min = Math.Min(n1, n2);
            uint max = Math.Max(n1, n2);
       
            for(uint i = min; i <= max; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($" {i} è pari");
                    c_pari++;
                }
                else
                {
                    Console.WriteLine($"{i} è dispari");
                    c_dispari++;
                }
            }
            Console.WriteLine($"I pari sono {c_pari} e i dispari sono {c_dispari}");
        }
    }
}
