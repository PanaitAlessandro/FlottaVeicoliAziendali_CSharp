using System;

namespace Flotta
{
    public class CAzienda
    {
        private string _ragionesociale;
        // todo: aggiungere array flotta di CVeicolo (DONE)
        private CVeicolo[] _flotta;
        private CDipendenti[] _dipendenti;

        public CVeicolo[] Flotta
        {
            get => _flotta;
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("La flotta non può essere null");
                }
            _flotta = value;
            }
        }

        public CDipendenti[] Dipendenti
        {
            get => _dipendenti;
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("I dipendenti non possono essere null");
                }
            _dipendenti = value;
            }
        }

        public string ragioneSociale
        {
            get => _ragionesociale;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("la ragione sociale no può essere nulla"); // non voglio che _ragionesociale = null
                }
                _ragionesociale = value;
            }
        }

        public CAzienda() : this("SCONOSCIUTA", new CVeicolo[0], new CDipendenti[0]) {}

        public CAzienda(string ragionesociale, CVeicolo[] flotta, CDipendenti[] dipendenti)
        {
            ragioneSociale = ragionesociale;
            Flotta = flotta;
            Dipendenti = dipendenti;
        }

        public void CercaPerCarburante(string tipoAlimentazione)
        {
            for (int i = 0; i < _flotta.Length; i++)
            {
                if (tipoAlimentazione == _flotta[i].tipoCarburante)
                {
                    System.Console.WriteLine($"Trovato: {_flotta[i]} ");
                }
            }
        }

        public int KilometraggioTotale()
        {
            int somma = 0;
            for (int i = 0; i < _flotta.Length; i++)
            {
                somma += _flotta[i].Chilometraggio;
            }
            return somma;
        }

        public double KilometraggioMedio()
        {
            double media = 0;
            for (int i = 0; i < _flotta.Length; i++)
            {
                media += _flotta[i].Chilometraggio;
            }
            media = media / _flotta.Length;
            return media;
        }

        public override string ToString()
        {
            string testo = $"Ragione Sociale: {ragioneSociale}";

            for (int i = 0; i < _flotta.Length; i++)
            {
                testo += $"\n{_flotta[i].Modello}: {_flotta[i].Targa}";
            }

            for (int i = 0; i < _dipendenti.Length; i++)
            {
                testo += $"\nDipendente {i}: {_dipendenti[i]}";
            }

            return testo;
        }
    }
}