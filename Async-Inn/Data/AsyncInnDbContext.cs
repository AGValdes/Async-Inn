using Async_Inn.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Data
{
    public class AsyncInnDbContext : IdentityDbContext<ApplicationUser>
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
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<RoomAmenity>().HasKey(
 
             roomAmenity => new { roomAmenity.RoomId, roomAmenity.AmenityId }
        );
            modelBuilder.Entity<HotelRoom>().HasKey(

            hotelRoom => new { hotelRoom.RoomId, hotelRoom.HotelId }

        );


            modelBuilder.Entity<Hotel>().HasData(new Hotel { Id = 1,  Name = "Neutral Milk Hotel", City = "Ruston", State = "Louisianna", Country = "United States", StreetAddress = "123 Avery Island St., Ruston, LA 12345" });
            modelBuilder.Entity<Hotel>().HasData(new Hotel { Id = 2, Name = "Grand Budapest Hotel", City = "Somewhere", State = "Ohklahoma", Country = "United States", StreetAddress = "123 West Anderson Dr, Somewhere, OK 23456" });
            modelBuilder.Entity<Hotel>().HasData(new Hotel { Id = 3, Name = "Hotel California", City = "Los Angeles", State = "California", Country = "United States", StreetAddress = "123 Such A Lovely Pl., Los Angeles, CA 90212" });
            modelBuilder.Entity<Room>().HasData(new Room { Id = 1, Name = "Executive Suite", Layout = "Two Bedroom" });
            modelBuilder.Entity<Room>().HasData(new Room { Id = 2, Name = "Honeymoon Suite", Layout = "One Bedroom" });
            modelBuilder.Entity<Room>().HasData(new Room { Id = 3, Name = "Economy Plus", Layout = "Studio" });
            modelBuilder.Entity<Amenity>().HasData(new Amenity { Id = 1, Name = "Mini Bar"});
            modelBuilder.Entity<Amenity>().HasData(new Amenity { Id = 2, Name = "Kitchenette" });
            modelBuilder.Entity<Amenity>().HasData(new Amenity { Id = 3, Name = "Desk Work Space" });
            modelBuilder.Entity<HotelRoom>().HasData(new HotelRoom { HotelId = 1, RoomId = 3, RoomNumber = 69, Rate = 39.99m, PetFriendly = true });
            modelBuilder.Entity<HotelRoom>().HasData(new HotelRoom { HotelId = 2, RoomId = 2, RoomNumber = 42, Rate = 199.99m, PetFriendly = false });
            modelBuilder.Entity<HotelRoom>().HasData(new HotelRoom { HotelId = 3, RoomId = 1, RoomNumber = 401, Rate = 299.99m, PetFriendly = false });

            SeedRole(modelBuilder, "District Manager", "Create Hotel", "See Hotels", "Update Hotel", "Delete Hotel", "Create HotelRoom", "See HotelRooms", "Update HotelRooms", "Delete HotelRooms", "Create Rooms", "See Rooms", "Update Rooms", "Delete Rooms", "Create Amenity", "See Amenities", "Add Amenity to Room", "Delete Amenity From Room", "Update Amenity", "Delete Amenity", "Create Account for District Manager", "Create Account for Agent", "Create Account for Property Manager" , "Create account for Anonymous User", "Add Room to Hotel") ;
            SeedRole(modelBuilder, "PropertyManager", "See Hotels", "Create HotelRoom", "See HotelRooms", "Update HotelRooms", "See Rooms", "See Amenities", "Add Amenity to Room", "Delete Amenity From Room", "Update Amenity", "Add Room to Hotel");
            SeedRole(modelBuilder, "Agent", "See HotelRooms", "Update HotelRooms", "See Amenities", "Add Amenity to Room", "Delete Amenity From Room");
            SeedRole(modelBuilder, "Anonymous", "See Hotels", "See HotelRooms", "See Rooms", "See Amenities");

     

        }

        private int nextId = 1; // we need this to generate a unique id on our own
        private void SeedRole(ModelBuilder modelBuilder, string roleName, params string[] permissions)
        {
            var role = new IdentityRole
            {
                Id = roleName.ToLower(),
                Name = roleName,
                NormalizedName = roleName.ToUpper(),
                ConcurrencyStamp = Guid.Empty.ToString()
            };

            modelBuilder.Entity<IdentityRole>().HasData(role);

            // Go through the permissions list (the params) and seed a new entry for each
            var roleClaims = permissions.Select(permission =>
            new IdentityRoleClaim<string>
            {
                Id = nextId++,
                RoleId = role.Id,
                ClaimType = "permissions", // This matches what we did in Startup.cs
      ClaimValue = permission
            }).ToArray();

            modelBuilder.Entity<IdentityRoleClaim<string>>().HasData(roleClaims);
        }

    }
}
