using Microsoft.EntityFrameworkCore.Migrations;

namespace Async_Inn.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Layout",
                table: "Rooms",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "Amenities",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "Layout",
                value: "TWo Bedroom");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "Layout",
                value: "One Bedroom");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "Layout",
                value: "Studio");

            migrationBuilder.CreateIndex(
                name: "IX_Amenities_RoomId",
                table: "Amenities",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Amenities_Rooms_RoomId",
                table: "Amenities",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Amenities_Rooms_RoomId",
                table: "Amenities");

            migrationBuilder.DropIndex(
                name: "IX_Amenities_RoomId",
                table: "Amenities");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Amenities");

            migrationBuilder.AlterColumn<int>(
                name: "Layout",
                table: "Rooms",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "Layout",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "Layout",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "Layout",
                value: 0);
        }
    }
}
