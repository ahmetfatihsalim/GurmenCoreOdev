using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Gurmen.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedPersonTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "ID", "Age", "Gender", "Name", "Surame" },
                values: new object[,]
                {
                    { 1, 20, 0, "Ahmet", "Salim" },
                    { 2, 24, 0, "Fatih", "Salim" },
                    { 3, 1000, 0, "Ali", "Yıldırım" },
                    { 4, 25, 1, "İrem", "Selin" },
                    { 5, 32, 0, "Veli", "Tunç" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "ID",
                keyValue: 5);
        }
    }
}
