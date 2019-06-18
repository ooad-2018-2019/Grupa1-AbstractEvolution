using System.ComponentModel.DataAnnotations;

namespace Bluestate.Models
{
    public abstract class Korisnik
    {
        private string id;
        private string imePrezime;
        private string username;
        private string password;
        private string email;

       /* protected Korisnik(string id, string imePrezime, string username, string password, string email)
        {
            this.id = id;
            this.imePrezime = imePrezime;
            this.username = username;
            this.password = password;
            this.email = email;
        }*/
        
        [ScaffoldColumn(false)]
        public string Id
        {
            get => id;
            set => id = value;
        }
        
        [Required]
        public string ImePrezime
        {
            get => imePrezime;
            set => imePrezime = value;
        }
        
        [Required]
        public string Username
        {
            get => username;
            set => username = value;
        }
        
        [Required]
        public string Password
        {
            get => password;
            set => password = value;
        }
        
        [Required]
        public string Email
        {
            get => email;
            set => email = value;
        }
    }
}