using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmCollectionAssignment.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                // adds a "addFilms" for every new entry
                name: "addFilms",
                columns: table => new
                {
                    FilmId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Year = table.Column<ushort>(nullable: false),
                    Director = table.Column<string>(nullable: true),
                    Rating = table.Column<string>(nullable: true),
                    Edited = table.Column<bool>(nullable: false),
                    Lent = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_addFilms", x => x.FilmId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "addFilms");
        }
    }
}
