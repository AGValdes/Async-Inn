using Microsoft.EntityFrameworkCore.Migrations;

namespace Async_Inn.Migrations
{
    public partial class Migrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "HotelRooms",
                columns: new[] { "RoomId", "HotelId", "PetFriendly", "Rate", "RoomNumber" },
                values: new object[] { 3, 1, true, 39.99m, 69 });

            migrationBuilder.InsertData(
                table: "HotelRooms",
                columns: new[] { "RoomId", "HotelId", "PetFriendly", "Rate", "RoomNumber" },
                values: new object[] { 2, 2, false, 199.99m, 42 });

            migrationBuilder.InsertData(
                table: "HotelRooms",
                columns: new[] { "RoomId", "HotelId", "PetFriendly", "Rate", "RoomNumber" },
                values: new object[] { 1, 3, false, 299.99m, 401 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HotelRooms",
                keyColumns: new[] { "RoomId", "HotelId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "HotelRooms",
                keyColumns: new[] { "RoomId", "HotelId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "HotelRooms",
                keyColumns: new[] { "RoomId", "HotelId" },
                keyValues: new object[] { 3, 1 });
        }
    }
}
