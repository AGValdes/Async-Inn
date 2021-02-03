using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models.Interfaces
{
    public interface IRoom
    {
        Task<RoomDTO> CreateRoom(RoomDTO roomDTO);
        Task<RoomDTO> GetRoom(int Id);
        Task<List<RoomDTO>> GetRooms();
        Task<Room> UpdateRoom(RoomDTO roomDTO);
        Task DeleteRoom(int Id);

        //new methods required in the service to add and remove amenities
        Task AddAmenityToRoom(int roomId, int amenityId);

        Task RemoveAmenityFromRoom(int roomId, int amenityId);

    }
}
