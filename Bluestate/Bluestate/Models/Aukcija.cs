using System;
using System.Collections.Generic;

namespace Bluestate.Models
{
    public class Aukcija
    {
        private Prodavac prodavac;
        private int najvecaPonuda;
        private DateTime pocetak;
        private DateTime kraj;
        private List<Korisnik> ucesnici;

        public Prodavac Prodavac
        {
            get => prodavac;
            set => prodavac = value;
        }

        public int NajvecaPonuda
        {
            get => najvecaPonuda;
            set => najvecaPonuda = value;
        }

        public DateTime Pocetak
        {
            get => pocetak;
            set => pocetak = value;
        }

        public DateTime Kraj
        {
            get => kraj;
            set => kraj = value;
        }

        public List<Korisnik> Ucesnici
        {
            get => ucesnici;
            set => ucesnici = value;
        }
    }
}