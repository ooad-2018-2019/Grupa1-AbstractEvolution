using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bluestate.Controllers;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace Bluestate.Models {
    public class DatabaseContext : DbContext {
        public static DatabaseContext instance;

        public static DatabaseContext getInstance() {
            return instance;
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) {
            instance = this;
        }

        public DbSet<Admin> Administrator { get; set; }
        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<Nekretnina> Nekretnina { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Admin>().ToTable("Administrator");
            modelBuilder.Entity<Korisnik>().ToTable("Korisnik");
            modelBuilder.Entity<Nekretnina>().ToTable("Nekretnina");
        }

        public Nekretnina GetNekretnina(int id) {
            return Nekretnina.Find(id);
        }

        public string GetUsername(string email)
        {
            var persons = Korisnik.Where((Korisnik person) => person.Email.Equals(email));
            return !persons.Any() ? null : persons.First().Username;
        }

        public void UpdatePassword(string username, string etPassword) {
            var user = Korisnik.First(person => person.Username.Equals(username));
            user.Password = etPassword;
            SaveChanges();
        }

     
    }
}