using Async_Inn.Data;
using Async_Inn.Models;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Async_Inn_Tests
{ 
    public abstract class Mock : IDisposable
    {
        private readonly SqliteConnection _connection;
        protected readonly AsyncInnDbContext _db;

        public Mock()
        {
            _connection = new SqliteConnection("Filename=:memory:");
            _connection.Open();
            _db = new AsyncInnDbContext(
                new DbContextOptionsBuilder<AsyncInnDbContext>()
                .UseSqlite(_connection)
                .Options);
            _db.Database.EnsureCreated();
        }

        public void Dispose()
        {
            _db?.Dispose();
            _connection?.Dispose();
        }
       [Fact]
        protected async Task<Amenity> CreateAndSaveTestAmenity()
        {
            var amenity = new Amenity()
            {
                Id = 5,
                Name = "Test"
            };
            _db.Add(amenity);
            await _db.SaveChangesAsync();
            Assert.NotEqual(0, amenity.Id);
            return amenity;
        }
        [Fact]
        protected async Task<Room> CreateAndSaveTestRoom()
        {
            var room = new Room()
            {
                Id = 5,
                Name = "Test",
                Layout = "Test"
            };
            _db.Add(room);
            await _db.SaveChangesAsync();
            Assert.NotEqual(0, room.Id);
            return room;
        }
    }   
}
