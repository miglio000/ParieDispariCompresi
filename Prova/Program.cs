using System;
using MetodoParieDispariCompresi;
namespace Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n1 = Esegui.InserisciInteroPositivo();
            uint n2 = Esegui.InserisciInteroPositivo();
            Esegui.ContaPariDispari(n1);
        }
    }
}
