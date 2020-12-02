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
        public static void ContaPariDispari(uint min, uint max)
        {
            int c_pari, c_dispari;
            do
            {
                Console.WriteLine("Inserisci il valore minimo: ");
                min = InserisciInteroPositivo();
                Console.WriteLine("Inserisci il valore massimo: ");
                max = InserisciInteroPositivo();
            } while (min <= max && min<0 && max <0);
       
            for(uint i=min; i==max;i++)
            {
                int resto = i % 2 == 0;
                
            }
        }
    }
}
