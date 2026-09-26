using System;
using System.Threading.Tasks.Dataflow;

namespace Flotta
{
    public class CPrenotazione
    {
        private string _codice;
        public DateTime dataInizio {get; private set;}
        public DateTime dataFine {get; private set;}
        private int _kmpercorsi;

        public string Codice
        {
            get => _codice;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Codice non può essere null");
                }
                _codice = value;
            }
        }

        public int kmPercorsi
        {
            get => _kmpercorsi;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("I kilometri non possono essere negativi");
                }
                _kmpercorsi = value;
            }
        }

        public CPrenotazione() : this("SCONOSCIUTO", DateTime.Now, DateTime.Now, 0) {}

        public CPrenotazione(string codice, DateTime datainizio, DateTime datafine, int km)
        {
            Codice = codice;

            if(datainizio>datafine)
            {
                throw new ArgumentException("la data di inizio non può essere maggiore di quella finale");
            }
            dataInizio = datainizio;
            dataFine = datafine;
            kmPercorsi = km;
        }

        public int CalcolaGiorni()
        {
            return (dataFine.Date-dataInizio.Date).Days; // Days prende solo i giorni interi, .Date toglie l'ora e da i giorni di calendario
        }

        public override string ToString()
        {
            return $"Codice: {Codice}, DataInizio: {dataInizio}, DataFine: {dataFine}, KmPercorsi: {kmPercorsi}";
        }

    }
}