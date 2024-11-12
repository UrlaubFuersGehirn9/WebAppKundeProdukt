using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppKundeProdukt.Migrations
{
    /// <inheritdoc />
    public partial class Thrd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Gesamtpreis",
                table: "Warenkorbposition",
                type: "float",
                nullable: true,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gesamtpreis",
                table: "Warenkorbposition");
        }
    }
}
