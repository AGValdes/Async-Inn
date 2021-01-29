using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models.Interfaces
{
    public interface IRoom
    {
        Task<Room> CreateRoom(Room room);
        Task<Room> GetRoom(int Id);
        Task<List<Room>> GetRooms();
        Task<Room> UpdateRoom(int Id, Room room);
        Task DeleteRoom(int Id);

        //new methods required in the service to add and remove amenities
        Task AddAmenityToRoom(int roomId, int amenityId);

        Task RemoveAmenityFromRoom(int roomId, int amenityId);

    }
}
