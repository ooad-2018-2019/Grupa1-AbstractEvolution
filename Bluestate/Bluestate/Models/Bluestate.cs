using System.Collections.Generic;

namespace Bluestate.Models
{
    public class Bluestate
    {
        private static Bluestate instanca=new Bluestate();
        private static List<Korisnik> korisnici=new List<Korisnik>();
        private static List<Nekretnina> nekretnine= new List<Nekretnina>();
        private static Admin admin;

        public Bluestate()
        {
            
        }
        public Bluestate(Admin admin)
        {
            Admin = admin;
        }

        public static Bluestate Instanca => instanca;

        public static List<Korisnik> Korisnici => korisnici;

        public static List<Nekretnina> Nekretnine => nekretnine;

        public static Admin Admin
        {
            get => admin;
            set => admin = value;
        }
    }
}