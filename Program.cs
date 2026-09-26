using System.Runtime.InteropServices;

namespace Flotta {

class Program
{
    static void Main(string[] args)
    {



        CPrenotazione[] prenotazioni =
            {
                new CPrenotazione("COD30", DateTime.Now, DateTime.Now, 250),
                new CPrenotazione("COD30", DateTime.Now, DateTime.Now, 250),
                new CPrenotazione("COD30", DateTime.Now, DateTime.Now, 250),
            };  

        CPrenotazione[] prenotazioni1 =
            {
                new CPrenotazione("COD30", DateTime.Now, DateTime.Now, 250),
                new CPrenotazione("COD30", DateTime.Now, DateTime.Now, 250),
                new CPrenotazione("COD30", DateTime.Now, DateTime.Now, 250),
            };  

        CPrenotazione[] prenotazioni2 =
            {
                new CPrenotazione("COD30", DateTime.Now, DateTime.Now, 250),
                new CPrenotazione("COD30", DateTime.Now, DateTime.Now, 250),
                new CPrenotazione("COD30", DateTime.Now, DateTime.Now, 250),
            };     
         CVeicolo[] flotta =
        {
            new CVeicolo("ABCED", "PANDA", "25 Settembre 2026", "DIESEL", 100,prenotazioni),
            new CVeicolo("DJJWDS", "TESLA", null, "ELETTRICA", 5020, prenotazioni1),
            new CVeicolo("SU281S", "PUNTO", "25 Settembre 2026", "BENZINA", 100, prenotazioni2)
        };

        CDipendenti[] dipendenti =
            {
                new CDipendenti("ABC", "ROSSI", 10,prenotazioni)
            };

        CAzienda azienda = new CAzienda("Rossi Spa", flotta, dipendenti);

        for (int i = 0; i < flotta.Length; i++)
        {
            System.Console.WriteLine(flotta[i]);
        }

        COfficina officina = new COfficina("IT30029429102", "GIANNI OFFICINA", "+39 3925922200", flotta);

        System.Console.WriteLine(azienda.KilometraggioTotale());
        System.Console.WriteLine(azienda.KilometraggioMedio());

        azienda.CercaPerCarburante("DIESEL");

        System.Console.WriteLine(azienda);
    }
  }
}