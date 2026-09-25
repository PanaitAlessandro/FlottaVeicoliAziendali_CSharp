using System;

namespace Flotta
{
    public class CVeicolo {
     private string _targa;
     private string _modello;
     private string _data; 

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


    public CVeicolo() : this("N/A", "SCONOSCIUTO", null,"SCONOSCIUTO", 0) {}

    public CVeicolo(string targa, string modello, string data, string tipocarburante,int chilometraggio)
        {
            Targa = targa;
            Modello = modello;
            Data = data;
            tipoCarburante = tipocarburante;
            Chilometraggio = chilometraggio;
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