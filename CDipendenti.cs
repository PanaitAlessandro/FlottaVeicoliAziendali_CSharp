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
    }
}