using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace autoszerelo_szerver.Migrations
{
    /// <inheritdoc />
    public partial class Sixth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MunkaAllapota",
                table: "Munka",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "MunkaOra",
                table: "Munka",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MunkaAllapota",
                table: "Munka");

            migrationBuilder.DropColumn(
                name: "MunkaOra",
                table: "Munka");
        }
    }
}
