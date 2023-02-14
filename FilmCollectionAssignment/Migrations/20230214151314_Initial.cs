using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmCollectionAssignment.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
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

            migrationBuilder.InsertData(
                table: "addFilms",
                columns: new[] { "FilmId", "Category", "Director", "Edited", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Action/Adventure", "Christopher Nolan", false, null, null, "PG-13", "The Dark Knight", (ushort)2008 });

            migrationBuilder.InsertData(
                table: "addFilms",
                columns: new[] { "FilmId", "Category", "Director", "Edited", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "RomCom", "Damien Chazelle", false, null, null, "PG-13", "la La Land", (ushort)2016 });

            migrationBuilder.InsertData(
                table: "addFilms",
                columns: new[] { "FilmId", "Category", "Director", "Edited", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Action/Adventure", "David Yates", false, null, null, "PG", "Harry Potter and the Half-Blood Prince", (ushort)2009 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "addFilms");
        }
    }
}
