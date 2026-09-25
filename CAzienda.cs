using System;

namespace Flotta
{
    public class CAzienda
    {
        private string _ragionesociale;
        // todo: aggiungere array flotta di CVeicoli

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

        public CAzienda(string ragionesociale)
        {
            ragioneSociale = ragionesociale;
        }

        public override string ToString()
        {
            return $"Ragione Sociale: {ragioneSociale}";
        }
    }
}