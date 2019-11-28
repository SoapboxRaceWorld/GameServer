using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SBRW.Data.Migrations
{
    public partial class CreatePersonaEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "personas",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Cash = table.Column<double>(nullable: false),
                    Boost = table.Column<double>(nullable: false),
                    IconIndex = table.Column<int>(nullable: false),
                    Motto = table.Column<string>(nullable: true),
                    Level = table.Column<int>(nullable: false),
                    Reputation = table.Column<double>(nullable: false),
                    ReputationAtLevel = table.Column<double>(nullable: false),
                    Rating = table.Column<double>(nullable: false),
                    Score = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_personas_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_personas_Name",
                table: "personas",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_personas_UserId",
                table: "personas",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "personas");
        }
    }
}
