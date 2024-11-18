using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppKundeProdukt.Migrations
{
    /// <inheritdoc />
    public partial class Sxth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gesamtpreis",
                table: "Warenkorbposition");

            migrationBuilder.DropColumn(
                name: "Endpreis",
                table: "Kunde");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Gesamtpreis",
                table: "Warenkorbposition",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Endpreis",
                table: "Kunde",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
