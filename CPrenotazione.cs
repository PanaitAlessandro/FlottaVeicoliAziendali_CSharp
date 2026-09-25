using System;

namespace Flotta
{
    public class CPrenotazione
    {
        private string _codice;
        private DateTime _datainizio {get; private set;}
        private DateTime _datafine {get; private set;}
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

    }
}