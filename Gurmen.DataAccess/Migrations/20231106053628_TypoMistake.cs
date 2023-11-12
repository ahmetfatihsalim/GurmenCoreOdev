using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gurmen.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class TypoMistake : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Surame",
                table: "Person",
                newName: "Surname");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "Person",
                newName: "Surame");
        }
    }
}
