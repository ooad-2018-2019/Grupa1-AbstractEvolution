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

       /* public List<Reservation> MyReservations() {
            string sportCentre = UserController.selectedSportCentre_MyReservations;
            string sport = UserController.selectedSport_myReservations;
            if (sportCentre != null && sportCentre.Equals("All sport centres")) sportCentre = null;
            if (sport != null && sport.Equals("All sports")) sport = null;
            List<Reservation> reservations = Reservations(LoginController.currentyLoggedPerson);
            if (sportCentre == null && sport == null)
                return reservations;
            if (sportCentre == null && sport != null) {
                for (int i = 0; i < reservations.Count; i++) {
                    Hall h = Hall.Where((Hall hall) => hall.HallID.Equals(reservations[i].HallID)).First();
                    if (!h.Sport.ToString().Equals(sport)) {
                        reservations.Remove(reservations[i]);
                        i--;
                    }
                }
            }
            if (sportCentre != null && sport == null) {
                SportCentre SC = SportCentre.Where((SportCentre SportCentre) => SportCentre.Name.Equals(sportCentre)).First();
                for (int i = 0; i < reservations.Count; i++) {
                    Hall h = Hall.Where((Hall hall) => hall.HallID.Equals(reservations[i].HallID)).First();
                    if (!h.SportCentreID.Equals(SC.SportCentreID)) {
                        reservations.Remove(reservations[i]);
                        i--;
                    }
                }
            } else if (sportCentre != null && sport != null) {
                SportCentre sc = SportCentre.Where((SportCentre SportCentre) => SportCentre.Name.Equals(sportCentre)).First();
                for (int i = 0; i < reservations.Count; i++) {
                    Hall h = Hall.Where((Hall hall) => hall.HallID.Equals(reservations[i].HallID)).First();
                    if (!h.SportCentreID.Equals(sc.SportCentreID) || !h.Sport.ToString().Equals(sport)) {
                        reservations.Remove(reservations[i]);
                        i--;
                    }
                }
            }
            UserController.selectedSportCentre_MyReservations = null;
            UserController.selectedSport_myReservations = null;
            return reservations;
        }

        private int GetSportCentreId(string sportCentre) {
            return SportCentre.Where((SportCentre sportCentr) => sportCentr.Name.Equals(sportCentre)).First().SportCentreID;
        }

        public List<Hall> Halls(DateTime dateTime, string sportCentre, string sport) {
            if (dateTime == null || sportCentre == null || sport == null)
                return new List<Hall>();
            int sportCentreID = GetSportCentreId(sportCentre);
            List<Hall> halls = Hall.Where((Hall hall) => sportCentreID.Equals(hall.SportCentreID) && hall.Sport.ToString().Equals(sport)).ToList();
            return halls;
        }

        public List<string> ReservedTimes(List<Hall> halls) {
            List<string> reservedTimes = new List<string>();
            DateTime dateTime = UserController.selectedDate;
            foreach (Hall hall in halls) {
                List<Reservation> reservations = Reservation.Where((Reservation reservation) => reservation.HallID.Equals(hall.HallID) && reservation.DateTime.Date == dateTime.Date).ToList();
                foreach (Reservation reservation in reservations) {
                    reservedTimes.Add(reservation.DateTime.ToShortTimeString());
                }
            }
            return reservedTimes;
        }

        public int GetHallID(string sportCentre, string sport) {
            int sportCentreID = GetSportCentreId(sportCentre);
            return Hall.Where((Hall hall) => sportCentreID.Equals(hall.SportCentreID) && hall.Sport.ToString().Equals(sport)).First().HallID;
        }*/
    }
}