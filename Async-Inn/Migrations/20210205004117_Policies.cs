using Microsoft.EntityFrameworkCore.Migrations;

namespace Async_Inn.Migrations
{
    public partial class Policies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[,]
                {
                    { 1, "permissions", "Create Hotel", "district manager" },
                    { 23, "permissions", "See Hotels", "propertymanager" },
                    { 24, "permissions", "Create HotelRoom", "propertymanager" },
                    { 25, "permissions", "See HotelRooms", "propertymanager" },
                    { 26, "permissions", "Update HotelRooms", "propertymanager" },
                    { 27, "permissions", "See Rooms", "propertymanager" },
                    { 28, "permissions", "See Amenities", "propertymanager" },
                    { 29, "permissions", "Add Amenity to Room", "propertymanager" },
                    { 22, "permissions", "Create account for Anonymous User", "district manager" },
                    { 30, "permissions", "Delete Amenity From Room", "propertymanager" },
                    { 32, "permissions", "See HotelRooms", "agent" },
                    { 33, "permissions", "Update HotelRooms", "agent" },
                    { 34, "permissions", "See Amenities", "agent" },
                    { 35, "permissions", "Add Amenity to Room", "agent" },
                    { 36, "permissions", "Delete Amenity From Room", "agent" },
                    { 37, "permissions", "See Hotels", "anonymous" },
                    { 38, "permissions", "See HotelRooms", "anonymous" },
                    { 31, "permissions", "Update Amenity", "propertymanager" },
                    { 21, "permissions", "Create Account for Property Manager", "district manager" },
                    { 20, "permissions", "Create Account for Agent", "district manager" },
                    { 19, "permissions", "Create Account for District Manager", "district manager" },
                    { 2, "permissions", "See Hotels", "district manager" },
                    { 3, "permissions", "Update Hotel", "district manager" },
                    { 4, "permissions", "Delete Hotel", "district manager" },
                    { 5, "permissions", "Create HotelRoom", "district manager" },
                    { 6, "permissions", "See HotelRooms", "district manager" },
                    { 7, "permissions", "Update HotelRooms", "district manager" },
                    { 8, "permissions", "Delete HotelRooms", "district manager" },
                    { 9, "permissions", "Create Rooms", "district manager" },
                    { 10, "permissions", "See Rooms", "district manager" },
                    { 11, "permissions", "Update Rooms", "district manager" },
                    { 12, "permissions", "Delete Rooms", "district manager" },
                    { 13, "permissions", "Create Amenity", "district manager" },
                    { 14, "permissions", "See Amenities", "district manager" },
                    { 15, "permissions", "Add Amenity to Room", "district manager" },
                    { 16, "permissions", "Delete Amenity From Room", "district manager" },
                    { 17, "permissions", "Update Amenity", "district manager" },
                    { 18, "permissions", "Delete Amenity", "district manager" },
                    { 39, "permissions", "See Rooms", "anonymous" },
                    { 40, "permissions", "See Amenities", "anonymous" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 40);
        }
    }
}
