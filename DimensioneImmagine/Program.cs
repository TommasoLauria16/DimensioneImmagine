using System;

namespace DimensioneImmagine
{
    class Program
    {
        static void Main(string[] args)
        {
            double bianconero, menocolori, piucolori, truecolor;
            Console.WriteLine("\n Bianco nero, 256 colori, 65000 colori, true color");
            Console.WriteLine("inserisci la dimensione verticale dell'immagine di cui vuoi sapere la dimensione");
            double dimmaginev = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("inserisci la dimensione orizzontale dell'immagine di cui vuoi sapere la dimensione");
            double dimmagineo = Convert.ToDouble(Console.ReadLine());
            bianconero = dimmagineo * dimmaginev / (1024*8);
            menocolori = dimmagineo * dimmaginev / 1024;
            piucolori = dimmagineo * dimmaginev * 2 / 1024;
            truecolor = dimmagineo * dimmaginev * 3 / 1024;
            Console.WriteLine($"la dimensione di memoria è:\nIn bianco nero {bianconero} KB;\nIn 256 colori {menocolori} KB;" +
                $"\nIn 65000 colori {piucolori} KB;\nIn True color {truecolor} KB");
        }
    }
}
