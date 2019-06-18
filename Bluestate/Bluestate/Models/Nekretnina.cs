using System.ComponentModel.DataAnnotations;

namespace Bluestate.Models
{
    public abstract class Nekretnina
    {
        private string id;
        private string naziv;
        private double cijena;
        private Prodavac prodavac;
        private string adresa;
        private int kvadratura;
        private string opis;

       /* protected Nekretnina(string id, string naziv, double cijena, Prodavac prodavac, string adresa, int kvadratura, string opis)
        {
            this.id = id;
            this.naziv = naziv;
            this.cijena = cijena;
            this.prodavac = prodavac;
            this.adresa = adresa;
            this.kvadratura = kvadratura;
            this.opis = opis;
        }*/
        
        [ScaffoldColumn(false)]
        public string Id
        {
            get => id;
            set => id = value;
        }

        [Required]
        public string Naziv
        {
            get => naziv;
            set => naziv = value;
        }

        [Required]
        public double Cijena
        {
            get => cijena;
            set => cijena = value;
        }

        [Required]
        public Prodavac Prodavac
        {
            get => prodavac;
            set => prodavac = value;
        }

        [Required]
        public string Adresa
        {
            get => adresa;
            set => adresa = value;
        }

        [Required]
        public int Kvadratura
        {
            get => kvadratura;
            set => kvadratura = value;
        }

        [Required]
        public string Opis
        {
            get => opis;
            set => opis = value;
        }
    }
}