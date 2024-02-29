using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Travel_Manager.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "37a1f098-a98e-4627-927f-ebdf7ec69f40", null, "seller", "seller" },
                    { "52f7ab50-a9b5-4f43-aa96-309a2444f0d7", null, "admin", "admin" },
                    { "e3301369-5cc3-4145-ad17-ef4afe92abef", null, "client", "client" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37a1f098-a98e-4627-927f-ebdf7ec69f40");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52f7ab50-a9b5-4f43-aa96-309a2444f0d7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3301369-5cc3-4145-ad17-ef4afe92abef");
        }
    }
}
