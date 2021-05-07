using Microsoft.EntityFrameworkCore.Migrations;

namespace feudalismData.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    CharacterId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CharacterName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dynasty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourtesyTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProvinceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.CharacterId);
                });

            migrationBuilder.CreateTable(
                name: "TerrainDetails",
                columns: table => new
                {
                    TerrainDetailId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TerrainDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TravelSpeed = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TerrainDetails", x => x.TerrainDetailId);
                });

            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    ProvinceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TerrainDetailId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CharacterId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProvinceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Population = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.ProvinceId);
                    table.ForeignKey(
                        name: "FK_Provinces_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "CharacterId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Provinces_TerrainDetails_TerrainDetailId",
                        column: x => x.TerrainDetailId,
                        principalTable: "TerrainDetails",
                        principalColumn: "TerrainDetailId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Provinces_CharacterId",
                table: "Provinces",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Provinces_TerrainDetailId",
                table: "Provinces",
                column: "TerrainDetailId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Provinces");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "TerrainDetails");
        }
    }
}
