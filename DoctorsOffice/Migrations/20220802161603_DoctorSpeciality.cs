using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorsOffice.Migrations
{
    public partial class DoctorSpeciality : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DoctorSpecialty",
                table: "Doctors",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DoctorSpecialty",
                table: "Doctors");
        }
    }
}
