using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorsOffice.Migrations
{
    public partial class PatientBirthdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PatientBirthdate",
                table: "Patients",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PatientBirthdate",
                table: "Patients");
        }
    }
}
