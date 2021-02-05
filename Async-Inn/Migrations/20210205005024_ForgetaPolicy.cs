using Microsoft.EntityFrameworkCore.Migrations;

namespace Async_Inn.Migrations
{
    public partial class ForgetaPolicy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ClaimValue", "RoleId" },
                values: new object[] { "Add Room to Hotel", "district manager" });

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 24,
                column: "ClaimValue",
                value: "See Hotels");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 25,
                column: "ClaimValue",
                value: "Create HotelRoom");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 26,
                column: "ClaimValue",
                value: "See HotelRooms");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 27,
                column: "ClaimValue",
                value: "Update HotelRooms");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 28,
                column: "ClaimValue",
                value: "See Rooms");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 29,
                column: "ClaimValue",
                value: "See Amenities");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 30,
                column: "ClaimValue",
                value: "Add Amenity to Room");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 31,
                column: "ClaimValue",
                value: "Delete Amenity From Room");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ClaimValue", "RoleId" },
                values: new object[] { "Update Amenity", "propertymanager" });

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ClaimValue", "RoleId" },
                values: new object[] { "Add Room to Hotel", "propertymanager" });

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 34,
                column: "ClaimValue",
                value: "See HotelRooms");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 35,
                column: "ClaimValue",
                value: "Update HotelRooms");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 36,
                column: "ClaimValue",
                value: "See Amenities");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ClaimValue", "RoleId" },
                values: new object[] { "Add Amenity to Room", "agent" });

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ClaimValue", "RoleId" },
                values: new object[] { "Delete Amenity From Room", "agent" });

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 39,
                column: "ClaimValue",
                value: "See Hotels");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 40,
                column: "ClaimValue",
                value: "See HotelRooms");

            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[,]
                {
                    { 42, "permissions", "See Amenities", "anonymous" },
                    { 41, "permissions", "See Rooms", "anonymous" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ClaimValue", "RoleId" },
                values: new object[] { "See Hotels", "propertymanager" });

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 24,
                column: "ClaimValue",
                value: "Create HotelRoom");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 25,
                column: "ClaimValue",
                value: "See HotelRooms");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 26,
                column: "ClaimValue",
                value: "Update HotelRooms");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 27,
                column: "ClaimValue",
                value: "See Rooms");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 28,
                column: "ClaimValue",
                value: "See Amenities");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 29,
                column: "ClaimValue",
                value: "Add Amenity to Room");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 30,
                column: "ClaimValue",
                value: "Delete Amenity From Room");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 31,
                column: "ClaimValue",
                value: "Update Amenity");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ClaimValue", "RoleId" },
                values: new object[] { "See HotelRooms", "agent" });

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ClaimValue", "RoleId" },
                values: new object[] { "Update HotelRooms", "agent" });

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 34,
                column: "ClaimValue",
                value: "See Amenities");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 35,
                column: "ClaimValue",
                value: "Add Amenity to Room");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 36,
                column: "ClaimValue",
                value: "Delete Amenity From Room");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ClaimValue", "RoleId" },
                values: new object[] { "See Hotels", "anonymous" });

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ClaimValue", "RoleId" },
                values: new object[] { "See HotelRooms", "anonymous" });

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 39,
                column: "ClaimValue",
                value: "See Rooms");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 40,
                column: "ClaimValue",
                value: "See Amenities");
        }
    }
}
