using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoDMAPI.Migrations
{
    /// <inheritdoc />
    public partial class addSchedule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_Medicine_MedicineId",
                table: "Schedule");

            migrationBuilder.DropIndex(
                name: "IX_Schedule_MedicineId",
                table: "Schedule");

            migrationBuilder.DropColumn(
                name: "MedicineId",
                table: "Schedule");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "MedicineId",
                table: "Schedule",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_MedicineId",
                table: "Schedule",
                column: "MedicineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_Medicine_MedicineId",
                table: "Schedule",
                column: "MedicineId",
                principalTable: "Medicine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
