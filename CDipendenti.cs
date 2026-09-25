using System;

namespace Flotta
{
    public class CDipendenti
    {
        private string _matricola;
        private string _cognome;
        private int _numeropatente;

        public string Matricola
        {
            get => _matricola;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Matricol non può essere null");
                }
                _matricola = value;
            }
        }

        public string Cognome
        {
            get => _cognome;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Cognome non può essere null");
                }
                _cognome = value;
            }
        }

        public string numeroPatente
        {
            get => _numeropatente;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Il numero della patente non può essere negativo");
                }
                _numeropatente = value;
            }
        }

        public bool haPatenteValida() {}
    }
}