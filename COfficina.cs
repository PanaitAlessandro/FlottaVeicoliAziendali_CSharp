using System;

namespace Flotta
{
    public class COfficina
    {
        private string _partitaiva;
        private string _nome;
        private string _numerotel;

        private CVeicolo[] _veicoli;

        public string partitaIva
        {
            get => _partitaiva;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("La partita IVA non può essere null");
                }
                _partitaiva = value;
            }
        }

        public string Nome
        {
            get => _nome;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Il nome non può essere null");
                }
                _nome = value;
            }
        }

        public string numeroTelefono
        {
            get => _numerotel;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Il numero di telefono non può essere null");
                }
                _numerotel = value;
            }
        }

        public COfficina() : this("N/A", "SCONOSCIUTO", "N/A") {}

        public COfficina(string partitaiva, string nome, string numerot)
        {
            partitaIva = partitaiva;
            Nome = nome;
            numeroTelefono = numerot;
        }

        public void InviaInRiparazione(CVeicolo veicolo)
        {
            if (veicolo == null)
            {
                throw new ArgumentException("Il veicolo non può essere null");
            }

            Console.WriteLine($"Il veicolo {veicolo.Targa} è stato inviato in riparazione presso {Nome}");
        }
    }
}