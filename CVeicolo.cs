using System;

namespace Flotta
{
    public class CVeicolo {
     private string _targa;
     private string _modello;
     private DateTime _data; // DateTime.Now mi indica l'rario attual

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

    
  }
}