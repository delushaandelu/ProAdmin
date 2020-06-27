using Microsoft.EntityFrameworkCore.Migrations;

namespace ProAdminWebVersion.Migrations
{
    public partial class cag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GetUsersDetails",
                table: "GetUsersDetails");

            migrationBuilder.RenameTable(
                name: "GetUsersDetails",
                newName: "UsersDetails");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersDetails",
                table: "UsersDetails",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UsersDetails",
                table: "UsersDetails");

            migrationBuilder.RenameTable(
                name: "UsersDetails",
                newName: "GetUsersDetails");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GetUsersDetails",
                table: "GetUsersDetails",
                column: "id");
        }
    }
}
