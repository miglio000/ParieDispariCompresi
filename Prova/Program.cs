using System;
using MetodoParieDispariCompresi;
namespace Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            uint min = Esegui.InserisciInteroPositivo();
            uint max = Esegui.InserisciInteroPositivo();
            Esegui.ContaPariDispari(min, max);
        }
    }
}
