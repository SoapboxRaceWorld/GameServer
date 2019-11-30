using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SBRW.Data.Migrations
{
    public partial class CreateBasicCarEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "owned_cars",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OwnershipType = table.Column<string>(nullable: false),
                    Heat = table.Column<float>(nullable: false),
                    ExpirationDate = table.Column<DateTimeOffset>(nullable: false),
                    PersonaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_owned_cars", x => x.ID);
                    table.ForeignKey(
                        name: "FK_owned_cars_personas_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "personas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "custom_car",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    ResalePrice = table.Column<int>(nullable: false),
                    Rating = table.Column<float>(nullable: false),
                    BaseCarHash = table.Column<int>(nullable: false),
                    PhysicsProfileHash = table.Column<int>(nullable: false),
                    OwnedCarId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_custom_car", x => x.ID);
                    table.ForeignKey(
                        name: "FK_custom_car_owned_cars_OwnedCarId",
                        column: x => x.OwnedCarId,
                        principalTable: "owned_cars",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_custom_car_OwnedCarId",
                table: "custom_car",
                column: "OwnedCarId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_owned_cars_PersonaId",
                table: "owned_cars",
                column: "PersonaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "custom_car");

            migrationBuilder.DropTable(
                name: "owned_cars");
        }
    }
}
