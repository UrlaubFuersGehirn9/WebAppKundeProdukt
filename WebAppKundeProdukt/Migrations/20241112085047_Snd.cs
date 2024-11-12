using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppKundeProdukt.Migrations
{
    /// <inheritdoc />
    public partial class Snd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Preis",
                table: "Produkt",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Preis",
                table: "Produkt");
        }
    }
}
