using System.Runtime.InteropServices;

namespace Flotta {

class Program
{
    static void Main(string[] args)
    {

        CVeicolo[] flotta =
        {
            new CVeicolo("ABCED", "PANDA", "25 Settembre 2026", "DIESEL", 100),
            new CVeicolo("DJJWDS", "TESLA", null, "ELETTRICA", 5020),
            new CVeicolo("SU281S", "PUNTO", "25 Settembre 2026", "BENZINA", 100)
        };

        CDipendenti[] dipendenti =
            {
                new CDipendenti("ABC", "ROSSI", 10)
            };

        CAzienda azienda = new CAzienda("Rossi Spa", flotta, dipendenti);

        for (int i = 0; i < flotta.Length; i++)
        {
            System.Console.WriteLine(flotta[i]);
        }

        System.Console.WriteLine(azienda.KilometraggioTotale());
        System.Console.WriteLine(azienda.KilometraggioMedio());

        azienda.CercaPerCarburante("DIESEL");

        System.Console.WriteLine(azienda);
    }
  }
}