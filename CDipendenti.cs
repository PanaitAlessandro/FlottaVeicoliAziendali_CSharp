using System;

namespace Flotta
{
    public class CDipendenti
    {
        private string _matricola;
        private string _cognome;
        private int _numeropatente;

        private CPrenotazione[] _prenotazioni;

        public CPrenotazione[] Prenotazioni
        {
            get => _prenotazioni;
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("Le prenotazioni non possono essere null");
                }
                _prenotazioni = value;
            }
        }

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

        public int numeroPatente
        {
            get => _numeropatente;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Il numero della patente non può essere negativo");
                }
                _numeropatente = value;
            }
        }

        public CDipendenti() : this("N/A", "SCONOSCIUTO", 1, new CPrenotazione[0]) {}

        public CDipendenti(string matricola, string cognome, int numeropatente, CPrenotazione[] prenotazioni)
        {
            Matricola = matricola;
            Cognome = cognome;
            numeroPatente = numeropatente;
            Prenotazioni = prenotazioni;
        }

        public bool haPatenteValida() // non ho capito cosa si intende nella traccia (non esiste alcuna scadenza di patente), quindi controllo se ha un numero di patente
        {
            return (numeroPatente > 0);
        }

        public override string ToString()
        {
            string testo = $"Matricola: {Matricola}, Cognome: {Cognome}, NumeroPatente: {numeroPatente}";
            testo += $"\n Lista Prenotazioni:";

            for (int i = 0; i < _prenotazioni.Length; i++)
            {
                testo += $"\n Prenotazione[{i}]: {_prenotazioni[i]}";
            }

            return testo;
        }
    }
}