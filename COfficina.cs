using System;

namespace Flotta
{
    public class COfficina
    {
        private string _partitaiva;
        private string _nome;
        private string _numerotel;

        private CVeicolo[] _veicoli;

        public CVeicolo[] Veicoli
        {
            get => _veicoli;
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("I veicoli NON possono essere null");
                }

                _veicoli = value;
            }
        }

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

        public COfficina() : this("N/A", "SCONOSCIUTO", "N/A", new CVeicolo[0]) {}

        public COfficina(string partitaiva, string nome, string numerot, CVeicolo[] veicoli)
        {
            partitaIva = partitaiva;
            Nome = nome;
            numeroTelefono = numerot;
            Veicoli = veicoli;
        }

        public void InviaInRiparazione(CVeicolo veicolo)
        {
            if (veicolo == null)
            {
                throw new ArgumentException("Il veicolo non può essere null");
            }

            Console.WriteLine($"Il veicolo {veicolo.Targa} è stato inviato in riparazione presso {Nome}");
        }

        public void AggiuntiVeicolo(CVeicolo veicolo)
        {
            if (veicolo == null)
            {
                throw new ArgumentException("Il veicolo non può essere null");
            }

            for (int i = 0; i < _veicoli.Length; i++)
            {
                if (_veicoli[i] == veicolo)
                {
                    throw new ArgumentException("Il veicolo è già presente in officina");
                }
            }

            Array.Resize(ref _veicoli, _veicoli.Length+1);
            _veicoli[_veicoli.Length-1] = veicolo;
        }
    }
}