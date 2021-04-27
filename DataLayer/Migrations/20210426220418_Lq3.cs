using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCBasics.Migrations
{
    public partial class Lq3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Class",
                table: "LqStudentModel",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EnglishM",
                table: "LqStudentModel",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MathsM",
                table: "LqStudentModel",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "LqStudentModel",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RollNo",
                table: "LqStudentModel",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ScienceM",
                table: "LqStudentModel",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Sec",
                table: "LqStudentModel",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Class",
                table: "LqStudentModel");

            migrationBuilder.DropColumn(
                name: "EnglishM",
                table: "LqStudentModel");

            migrationBuilder.DropColumn(
                name: "MathsM",
                table: "LqStudentModel");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "LqStudentModel");

            migrationBuilder.DropColumn(
                name: "RollNo",
                table: "LqStudentModel");

            migrationBuilder.DropColumn(
                name: "ScienceM",
                table: "LqStudentModel");

            migrationBuilder.DropColumn(
                name: "Sec",
                table: "LqStudentModel");
        }
    }
}
