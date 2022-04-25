using Async_Inn.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Data
{
    public class AsyncInnDbContext : DbContext
    {
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelRoom> HotelRooms { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Amenity> Amenities { get; set; }
        public DbSet<AmenityRoom> AmenitiesRoom { get; set; }



        public AsyncInnDbContext(DbContextOptions options) : base(options)
        {


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hotel>().HasData(
              new Hotel { Id = 1, Name = "W Amman", StreetAddress = "13 Rafiq Al Hariri Ave,", City = "Amman", State = "Amman", Country = "Jordan", Phone = "06 530 1111" },
              new Hotel { Id = 2, Name = "Fairmont", StreetAddress = "6 Beirut Street - Fifth Circle", City = "Amman", State = "Amman", Country = "Jordan", Phone = "06 510 6000" },
              new Hotel { Id = 3, Name = "Rotana", StreetAddress = "Al Sawoda Street - Abdali ", City = "Amman", State = "Amman", Country = "Jordan", Phone = "06 520 8888" }

            );


            modelBuilder.Entity<Amenity>().HasData(
              new Amenity { Id = 1, Name = "Coffee maker" },
              new Amenity { Id = 2, Name = "Ocean view" },
              new Amenity { Id = 3, Name = "Air conditioning" },
              new Amenity { Id = 4, Name = "Mini Bar" }

            );



            modelBuilder.Entity<Room>().HasData(
                new Room { Id = 1, Name = "Studio", Layout = 0 },
                new Room { Id = 2, Name = "One Bedroom", Layout = 1 },
                new Room { Id = 3, Name = "Two Bedroom", Layout = 2 }

              );


            modelBuilder.Entity<HotelRoom>().HasKey(

                           hotelroom => new { hotelroom.RoomNum, hotelroom.HotelId }
                           );
            modelBuilder.Entity<AmenityRoom>().HasKey(
                roomamenity => new { roomamenity.AmenetiesID, roomamenity.RoomID }
                );
        }
    }
}