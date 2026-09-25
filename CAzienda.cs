using System;

namespace Flotta
{
    public class CAzienda
    {
        private string _ragionesociale;
        // todo: aggiungere array flotta di CVeicolo (DONE)
        private CVeicolo[] _flotta;

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

        public CAzienda() : this("SCONOSCIUTA") {}

        public CAzienda(string ragionesociale, CVeicolo[] flotta)
        {
            ragioneSociale = ragionesociale;
            Flotta = flotta;
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
        }

        public double KilometraggioMedio()
        {
            double media = 0;
            for (int i = 0; i < _flotta.Length; i++)
            {
                media += _flotta[i].Chilometraggio;
            }
            media / _flotta.Length;
            return media;
        }

        public override string ToString()
        {
            return $"Ragione Sociale: {ragioneSociale}";
        }
    }
}