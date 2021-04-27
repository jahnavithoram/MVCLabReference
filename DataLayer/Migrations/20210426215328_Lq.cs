using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCBasics.Migrations
{
    public partial class Lq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LqStudentModel",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LqStudentModel", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LqStudentModel");
        }
    }
}
