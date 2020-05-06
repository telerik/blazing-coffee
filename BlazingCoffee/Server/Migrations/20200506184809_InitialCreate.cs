using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazingCoffee.Server.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TeamId = table.Column<int>(nullable: false),
                    FullName = table.Column<string>(nullable: true),
                    JobTitle = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    IsOnline = table.Column<bool>(nullable: false),
                    Rating = table.Column<int>(nullable: false),
                    Target = table.Column<int>(nullable: false),
                    Budget = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    ImgId = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
