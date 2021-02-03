using Async_Inn.Models;
using Async_Inn.Models.Interfaces;
using Async_Inn.Models.Interfaces.Services;
using System;
using System.Threading.Tasks;
using Xunit;


namespace Async_Inn_Tests
{
    public class Async_Inn_Tests : Mock
    {
        /// <summary>
        /// The below builds an instance of the amenity repository, so we can call it as a helper method in our tests
        /// </summary>
        /// <returns></returns>
        private IAmenity BuildRepository()
        {
            return new AmenityRepository(_db);
        }
      
        [Fact]
        public async Task Can_Get_All_Amenities()
        {
            var repository = BuildRepository();

            var savedAmenities = await repository.GetAmenities();

            Assert.Equal(3, savedAmenities.Count);
            Assert.Equal("Mini Bar", savedAmenities[0].Name);
        }


        [Fact]
        public async Task Can_Update_Amenity()
        {
            var amenityUpdate = new AmenityDTO
            {
                ID = 1,
                Name = "AmenityUpdate",
            };

            var repository = BuildRepository();
            await repository.UpdateAmenity(amenityUpdate);
    
            var result = await repository.GetAmenity(1);
            Assert.Equal(amenityUpdate.Name, result.Name);
        }

    }
}
