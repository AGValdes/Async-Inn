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
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Amenity> Amenities { get; set; }

        public DbSet<RoomAmenity> RoomAmenities { get; set; }

        public DbSet<HotelRoom> HotelRooms { get; set; }
        public AsyncInnDbContext(DbContextOptions options) : base(options)
                {

                }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

             modelBuilder.Entity<RoomAmenity>().HasKey(
 
             roomAmenity => new { roomAmenity.RoomId, roomAmenity.AmenityId }
        );
            modelBuilder.Entity<HotelRoom>().HasKey(

            hotelRoom => new { hotelRoom.RoomId, hotelRoom.HotelId }

        );


            modelBuilder.Entity<Hotel>().HasData(new Hotel { Id = 1,  Name = "Neutral Milk Hotel", City = "Ruston", State = "Louisianna", Country = "United States", StreetAddress = "123 Avery Island St., Ruston, LA 12345" });
            modelBuilder.Entity<Hotel>().HasData(new Hotel { Id = 2, Name = "Grand Budapest Hotel", City = "Somewhere", State = "Ohklahoma", Country = "United States", StreetAddress = "123 West Anderson Dr, Somewhere, OK 23456" });
            modelBuilder.Entity<Hotel>().HasData(new Hotel { Id = 3, Name = "Hotel California", City = "Los Angeles", State = "California", Country = "United States", StreetAddress = "123 Such A Lovely Pl., Los Angeles, CA 90212" });
            modelBuilder.Entity<Room>().HasData(new Room { Id = 1, Name = "Executive Suite", Layout = 2 });
            modelBuilder.Entity<Room>().HasData(new Room { Id = 2, Name = "Honeymoon Suite", Layout = 1 });
            modelBuilder.Entity<Room>().HasData(new Room { Id = 3, Name = "Economy Plus", Layout = 0 });
            modelBuilder.Entity<Amenity>().HasData(new Amenity { Id = 1, Name = "Mini Bar"});
            modelBuilder.Entity<Amenity>().HasData(new Amenity { Id = 2, Name = "Kitchenette" });
            modelBuilder.Entity<Amenity>().HasData(new Amenity { Id = 3, Name = "Desk Work Space" });

        }

    }
}
