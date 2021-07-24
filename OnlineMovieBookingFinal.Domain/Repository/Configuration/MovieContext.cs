using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using OnlineMovieBooking.Domain.Repository.Entities;

namespace OnlineMovieBookingFinal.Domain.Repository.Configuration
{
    public class MovieContext : DbContext
    {
        public MovieContext():base()
        {

        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CinemaHall> CinemaHalls { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<ShowSeat> ShowSeats { get; set; }
        public DbSet<Show> Shows { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
    }
}