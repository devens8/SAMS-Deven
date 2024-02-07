using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAMS.Data.Migrations
{
    /// <inheritdoc />
    public partial class updated_version_2624_01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "roomCodeModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_chosenBellSchedModels",
                table: "chosenBellSchedModels");

            migrationBuilder.RenameTable(
                name: "chosenBellSchedModels",
                newName: "ChosenBellSchedModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChosenBellSchedModel",
                table: "ChosenBellSchedModel",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "roomQRCodeModels",
                columns: table => new
                {
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roomQRCodeModels", x => x.RoomId);
                    table.ForeignKey(
                        name: "FK_roomQRCodeModels_roomLocationInfoModels_RoomId",
                        column: x => x.RoomId,
                        principalTable: "roomLocationInfoModels",
                        principalColumn: "RoomId");
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "roomQRCodeModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChosenBellSchedModel",
                table: "ChosenBellSchedModel");

            migrationBuilder.RenameTable(
                name: "ChosenBellSchedModel",
                newName: "chosenBellSchedModels");

            migrationBuilder.AddPrimaryKey(
                name: "PK_chosenBellSchedModels",
                table: "chosenBellSchedModels",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "roomCodeModels",
                columns: table => new
                {
                    RoomID = table.Column<int>(type: "int", nullable: false),
                    RoomCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roomCodeModels", x => x.RoomID);
                    table.ForeignKey(
                        name: "FK_roomCodeModels_roomLocationInfoModels_RoomID",
                        column: x => x.RoomID,
                        principalTable: "roomLocationInfoModels",
                        principalColumn: "RoomId");
                });
        }
    }
}
