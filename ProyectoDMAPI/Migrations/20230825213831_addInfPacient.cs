using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoDMAPI.Migrations
{
    /// <inheritdoc />
    public partial class addInfPacient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InfPacient",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InfPacientIdentification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InfPacientName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InfPacientdAge = table.Column<int>(type: "int", nullable: false),
                    InfPacientSex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InfPacientHeight = table.Column<float>(type: "real", nullable: false),
                    InfPacientWeight = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfPacient", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InfPacient");
        }
    }
}
