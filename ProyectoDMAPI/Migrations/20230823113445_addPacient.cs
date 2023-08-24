using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoDMAPI.Migrations
{
    /// <inheritdoc />
    public partial class addPacient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "frecuency",
                table: "Medicine",
                newName: "Frecuency");

            migrationBuilder.CreateTable(
                name: "Pacient",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PacientIdentification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PacientName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PacientdAge = table.Column<int>(type: "int", nullable: false),
                    PacientSex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PacientHeight = table.Column<float>(type: "real", nullable: false),
                    PacientWeight = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacient", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Schedule",
                columns: table => new
                {
                    IdSchedule = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScheduleDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ScheduleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScheduleQuantity = table.Column<int>(type: "int", nullable: false),
                    ScheduleDay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScheduleHour = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScheduleFrecuency = table.Column<int>(type: "int", nullable: false),
                    MedicineId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedule", x => x.IdSchedule);
                    table.ForeignKey(
                        name: "FK_Schedule_Medicine_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "Medicine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_MedicineId",
                table: "Schedule",
                column: "MedicineId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pacient");

            migrationBuilder.DropTable(
                name: "Schedule");

            migrationBuilder.RenameColumn(
                name: "Frecuency",
                table: "Medicine",
                newName: "frecuency");
        }
    }
}
