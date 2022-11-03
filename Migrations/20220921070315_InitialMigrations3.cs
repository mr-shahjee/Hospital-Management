using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PracticeCrud.Migrations
{
    public partial class InitialMigrations3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "gad7s",
                columns: table => new
                {
                    Gad7Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gad7Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TreatmentStage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Score = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gad7s", x => x.Gad7Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gad7s");
        }
    }
}
