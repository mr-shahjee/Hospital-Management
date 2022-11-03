using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PracticeCrud.Migrations
{
    public partial class initialMigrations2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "schemaName",
                table: "schemas",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "schemaName",
                table: "schemas");
        }
    }
}
