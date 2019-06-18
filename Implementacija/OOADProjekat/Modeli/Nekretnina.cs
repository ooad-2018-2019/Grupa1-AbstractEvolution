namespace OOADProjekat.Modeli
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

        protected Nekretnina(string id, string naziv, double cijena, Prodavac prodavac, string adresa, int kvadratura, string opis)
        {
            this.id = id;
            this.naziv = naziv;
            this.cijena = cijena;
            this.prodavac = prodavac;
            this.adresa = adresa;
            this.kvadratura = kvadratura;
            this.opis = opis;
        }

        public string Id
        {
            get => id;
            set => id = value;
        }

        public string Naziv
        {
            get => naziv;
            set => naziv = value;
        }

        public double Cijena
        {
            get => cijena;
            set => cijena = value;
        }

        public Prodavac Prodavac
        {
            get => prodavac;
            set => prodavac = value;
        }

        public string Adresa
        {
            get => adresa;
            set => adresa = value;
        }

        public int Kvadratura
        {
            get => kvadratura;
            set => kvadratura = value;
        }

        public string Opis
        {
            get => opis;
            set => opis = value;
        }
    }
}