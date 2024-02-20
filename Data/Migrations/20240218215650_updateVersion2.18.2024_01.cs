using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAMS.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateVersion2182024_01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_roomLocationInfoModels_teacherInfoModels_RoomAssignedToTeacherID",
                table: "roomLocationInfoModels");

            migrationBuilder.DropIndex(
                name: "IX_roomLocationInfoModels_RoomAssignedToTeacherID",
                table: "roomLocationInfoModels");

            migrationBuilder.DropColumn(
                name: "TeachingScheduleID",
                table: "teacherInfoModels");

            migrationBuilder.DropColumn(
                name: "RoomAssignedToTeacherID",
                table: "roomLocationInfoModels");

            migrationBuilder.RenameColumn(
                name: "role",
                table: "AspNetUsers",
                newName: "Role");

            migrationBuilder.AddColumn<int>(
                name: "RoomAssigned",
                table: "teacherInfoModels",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_teacherInfoModels_RoomAssigned",
                table: "teacherInfoModels",
                column: "RoomAssigned",
                unique: true,
                filter: "[RoomAssigned] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_teacherInfoModels_roomLocationInfoModels_RoomAssigned",
                table: "teacherInfoModels",
                column: "RoomAssigned",
                principalTable: "roomLocationInfoModels",
                principalColumn: "RoomId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_teacherInfoModels_roomLocationInfoModels_RoomAssigned",
                table: "teacherInfoModels");

            migrationBuilder.DropIndex(
                name: "IX_teacherInfoModels_RoomAssigned",
                table: "teacherInfoModels");

            migrationBuilder.DropColumn(
                name: "RoomAssigned",
                table: "teacherInfoModels");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "AspNetUsers",
                newName: "role");

            migrationBuilder.AddColumn<int>(
                name: "TeachingScheduleID",
                table: "teacherInfoModels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RoomAssignedToTeacherID",
                table: "roomLocationInfoModels",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_roomLocationInfoModels_RoomAssignedToTeacherID",
                table: "roomLocationInfoModels",
                column: "RoomAssignedToTeacherID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_roomLocationInfoModels_teacherInfoModels_RoomAssignedToTeacherID",
                table: "roomLocationInfoModels",
                column: "RoomAssignedToTeacherID",
                principalTable: "teacherInfoModels",
                principalColumn: "TeacherID");
        }
    }
}
