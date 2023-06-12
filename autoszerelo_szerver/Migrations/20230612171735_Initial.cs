using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace autoszerelo_szerver.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Munka",
                columns: table => new
                {
                    Nev = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Tipus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rendszam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ev = table.Column<int>(type: "int", nullable: false),
                    Kategoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Leiras = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sulyossag = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Munka", x => x.Nev);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Munka");
        }
    }
}
