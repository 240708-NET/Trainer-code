using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HelloEF.Migrations
{
    /// <inheritdoc />
    public partial class ManyToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_Owners_PetOwnerId",
                table: "Pets");

            migrationBuilder.DropIndex(
                name: "IX_Pets_PetOwnerId",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "PetOwnerId",
                table: "Pets");

            migrationBuilder.CreateTable(
                name: "OwnerPet",
                columns: table => new
                {
                    OwnersId = table.Column<int>(type: "int", nullable: false),
                    PetsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OwnerPet", x => new { x.OwnersId, x.PetsId });
                    table.ForeignKey(
                        name: "FK_OwnerPet_Owners_OwnersId",
                        column: x => x.OwnersId,
                        principalTable: "Owners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OwnerPet_Pets_PetsId",
                        column: x => x.PetsId,
                        principalTable: "Pets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OwnerPet_PetsId",
                table: "OwnerPet",
                column: "PetsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OwnerPet");

            migrationBuilder.AddColumn<int>(
                name: "PetOwnerId",
                table: "Pets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pets_PetOwnerId",
                table: "Pets",
                column: "PetOwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_Owners_PetOwnerId",
                table: "Pets",
                column: "PetOwnerId",
                principalTable: "Owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
