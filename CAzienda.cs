using System;

namespace Flotta
{
    public class CAzienda
    {
        private string _ragionesociale;
        // todo: aggiungere array flotta di CVeicolo
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

        public override string ToString()
        {
            return $"Ragione Sociale: {ragioneSociale}";
        }
    }
}