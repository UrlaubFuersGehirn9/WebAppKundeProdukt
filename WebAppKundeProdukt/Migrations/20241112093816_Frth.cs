using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppKundeProdukt.Migrations
{
    /// <inheritdoc />
    public partial class Frth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Endpreis",
                table: "Kunde",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Endpreis",
                table: "Kunde");
        }
    }
}
