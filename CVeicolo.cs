using System;

namespace Flotta
{
    public class CVeicolo {
     private string _targa;
     private string _modello;
     private string _data; 

    private string _tipocarburante;
    private int _chilometraggio;

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

    public string Targa
    {
        get => _targa;
        private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Targa non può essere null");
                }
                _targa = value;
            }
    }

    public string Modello
    {
        get => _modello;
        private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Modello non può essere null");
                }
                _modello = value;
            }
    }

    public string Data
    {
        get => _data;
        private set
            {
                _data = value;
            }
    }

    public string tipoCarburante
    {
        get => _tipocarburante;
        private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Il tipo di carburante non può essere null");
                }
                _tipocarburante = value;
            }
    }

    public int Chilometraggio
    {
        get => _chilometraggio;
        private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Chilometraggio non può essere negatico");
                }
                _chilometraggio = value;
            }
    }


    public CVeicolo() : this("N/A", "SCONOSCIUTO", null,"SCONOSCIUTO", 0, new CPrenotazione[0]) {}

    public CVeicolo(string targa, string modello, string data, string tipocarburante,int chilometraggio, CPrenotazione[] prenotazioni)
        {
            Targa = targa;
            Modello = modello;
            Data = data;
            tipoCarburante = tipocarburante;
            Chilometraggio = chilometraggio;
            Prenotazioni = prenotazioni;
        }

    public void AggiungiPrenotazione(CPrenotazione prenotazione)
        {
            if (prenotazione == null)
            {
                throw new ArgumentException("La prenotazione NON può essere null");
            }

            for (int i = 0; i < _prenotazioni.Length; i++)
            {
                if (_prenotazioni[i] == prenotazione)
                {
                    throw new ArgumentException("Questa prenotazione è già presente");
                }
            }
            Array.Resize(ref _prenotazioni, _prenotazioni.Length+1);
            _prenotazioni[_prenotazioni.Length-1] = prenotazione;
        }

        public override string ToString()
        {

            string data;

            if (Data == null)
            {
                data = "mai effettuata";
            } else
            {
                data = Data;
            }
            return $"Targa: {Targa}, Modello: {Modello}, Revisione: {data}, TipoCarburante: {tipoCarburante}, Chilometraggio: {Chilometraggio}";
        }
    }
}