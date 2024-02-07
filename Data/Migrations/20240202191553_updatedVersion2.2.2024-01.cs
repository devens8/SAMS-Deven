using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAMS.Data.Migrations
{
    /// <inheritdoc />
    public partial class updatedVersion22202401 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "roomCodeModels");
        }
    }
}
