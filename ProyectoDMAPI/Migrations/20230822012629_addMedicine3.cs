using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoDMAPI.Migrations
{
    /// <inheritdoc />
    public partial class addMedicine3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "frecuency",
                table: "Medicine",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "frecuency",
                table: "Medicine");
        }
    }
}
