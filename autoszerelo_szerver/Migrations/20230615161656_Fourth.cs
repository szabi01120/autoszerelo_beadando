using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace autoszerelo_szerver.Migrations
{
    /// <inheritdoc />
    public partial class Fourth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sulyossag",
                table: "Munka",
                newName: "HibaSulyossaga");

            migrationBuilder.RenameColumn(
                name: "Nev",
                table: "Munka",
                newName: "UgyfelNeve");

            migrationBuilder.RenameColumn(
                name: "Leiras",
                table: "Munka",
                newName: "MunkaKategoria");

            migrationBuilder.RenameColumn(
                name: "Kategoria",
                table: "Munka",
                newName: "HibaLeiras");

            migrationBuilder.RenameColumn(
                name: "Ev",
                table: "Munka",
                newName: "GyartasiEv");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UgyfelNeve",
                table: "Munka",
                newName: "Nev");

            migrationBuilder.RenameColumn(
                name: "MunkaKategoria",
                table: "Munka",
                newName: "Leiras");

            migrationBuilder.RenameColumn(
                name: "HibaSulyossaga",
                table: "Munka",
                newName: "Sulyossag");

            migrationBuilder.RenameColumn(
                name: "HibaLeiras",
                table: "Munka",
                newName: "Kategoria");

            migrationBuilder.RenameColumn(
                name: "GyartasiEv",
                table: "Munka",
                newName: "Ev");
        }
    }
}
