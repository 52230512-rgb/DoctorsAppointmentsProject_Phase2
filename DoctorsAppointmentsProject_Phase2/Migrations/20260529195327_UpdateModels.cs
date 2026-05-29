using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorsAppointmentsProject_Phase2.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AvailableDay",
                table: "Doctors",
                newName: "Day");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Day",
                table: "Doctors",
                newName: "AvailableDay");
        }
    }
}
