using Microsoft.EntityFrameworkCore.Migrations;

namespace MasaBomby.BazaDanych.Migrations
{
    public partial class INitDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TypeOfUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOfUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    CharRepresentation = table.Column<string>(type: "TEXT", nullable: true),
                    RodzajeJednostekId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Units_TypeOfUnits_RodzajeJednostekId",
                        column: x => x.RodzajeJednostekId,
                        principalTable: "TypeOfUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Convertors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Multiplier = table.Column<double>(type: "REAL", nullable: false),
                    UnitFromId = table.Column<int>(type: "INTEGER", nullable: false),
                    UnitToId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Convertors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Convertors_Units_UnitFromId",
                        column: x => x.UnitFromId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Convertors_Units_UnitToId",
                        column: x => x.UnitToId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Convertors_UnitFromId",
                table: "Convertors",
                column: "UnitFromId");

            migrationBuilder.CreateIndex(
                name: "IX_Convertors_UnitToId",
                table: "Convertors",
                column: "UnitToId");

            migrationBuilder.CreateIndex(
                name: "IX_Units_RodzajeJednostekId",
                table: "Units",
                column: "RodzajeJednostekId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Convertors");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "TypeOfUnits");
        }
    }
}
