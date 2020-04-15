using Microsoft.EntityFrameworkCore.Migrations;

namespace ResturantAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appertizer",
                columns: table => new
                {
                    name = table.Column<string>(nullable: false),
                    description = table.Column<string>(nullable: true),
                    allergies = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    ImageSrc = table.Column<string>(nullable: true),
                    category = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appertizer", x => x.name);
                });

            migrationBuilder.CreateTable(
                name: "Dishes",
                columns: table => new
                {
                    name = table.Column<string>(nullable: false),
                    description = table.Column<string>(nullable: true),
                    allergies = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    ImageSrc = table.Column<string>(nullable: true),
                    category = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dishes", x => x.name);
                });

            migrationBuilder.CreateTable(
                name: "Drinks",
                columns: table => new
                {
                    name = table.Column<string>(nullable: false),
                    description = table.Column<string>(nullable: true),
                    allergies = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    ImageSrc = table.Column<string>(nullable: true),
                    category = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drinks", x => x.name);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appertizer");

            migrationBuilder.DropTable(
                name: "Dishes");

            migrationBuilder.DropTable(
                name: "Drinks");
        }
    }
}
