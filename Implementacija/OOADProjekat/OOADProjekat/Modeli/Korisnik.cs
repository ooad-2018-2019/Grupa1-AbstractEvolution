namespace OOADProjekat.Modeli
{
    public abstract class Korisnik
    {
        private string id;
        private string imePrezime;
        private string username;
        private string password;
        private string email;

        protected Korisnik(string id, string imePrezime, string username, string password, string email)
        {
            this.id = id;
            this.imePrezime = imePrezime;
            this.username = username;
            this.password = password;
            this.email = email;
        }

        public string Id
        {
            get => id;
            set => id = value;
        }

        public string ImePrezime
        {
            get => imePrezime;
            set => imePrezime = value;
        }

        public string Username
        {
            get => username;
            set => username = value;
        }

        public string Password
        {
            get => password;
            set => password = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }
    }
}