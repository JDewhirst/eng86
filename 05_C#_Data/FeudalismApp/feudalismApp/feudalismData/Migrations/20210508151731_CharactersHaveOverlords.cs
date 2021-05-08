using Microsoft.EntityFrameworkCore.Migrations;

namespace feudalismData.Migrations
{
    public partial class CharactersHaveOverlords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OverlordId",
                table: "Characters",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Characters_OverlordId",
                table: "Characters",
                column: "OverlordId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Characters_OverlordId",
                table: "Characters",
                column: "OverlordId",
                principalTable: "Characters",
                principalColumn: "CharacterId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Characters_OverlordId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_OverlordId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "OverlordId",
                table: "Characters");
        }
    }
}
