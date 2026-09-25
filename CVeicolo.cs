using System;

namespace Flotta
{
    public class CVeicolo {
     private string _targa;
     private string _modello;
     private DateTime _data; // DateTime.Now mi indica l'rario attual // data: data ultima revisione

    private string _tipocarburante;
    private int _chilometraggio;

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

    public DateTime Data
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


    public CVeicolo() : this("N/A", "SCONOSCIUTO", "SCONOSCIUTO", 0) {}

    public CVeicolo(string targa, string modello, string tipocarburante,int chilometraggio)
        {
            Targa = targa;
            Modello = modello;
            tipoCarburante = tipocarburante;
            Chilometraggio = chilometraggio;
        }

        public override string ToString()
        {
            return $"Targa: {Targa}, Modello: {Modello}, TipoCarburante: {tipoCarburante}, Chilometraggio: {Chilometraggio}";
        }
    
  }
}