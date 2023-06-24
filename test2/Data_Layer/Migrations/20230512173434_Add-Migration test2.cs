using Microsoft.EntityFrameworkCore.Migrations;

namespace Data_Layer.Migrations
{
    public partial class AddMigrationtest2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InterestUser_Users_UsersUniqueNumber",
                table: "InterestUser");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_UserUniqueNumber",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "UserUniqueNumber",
                table: "Users",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "UniqueNumber",
                table: "Users",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_Users_UserUniqueNumber",
                table: "Users",
                newName: "IX_Users_UserID");

            migrationBuilder.RenameColumn(
                name: "UsersUniqueNumber",
                table: "InterestUser",
                newName: "UsersID");

            migrationBuilder.RenameIndex(
                name: "IX_InterestUser_UsersUniqueNumber",
                table: "InterestUser",
                newName: "IX_InterestUser_UsersID");

            migrationBuilder.AddForeignKey(
                name: "FK_InterestUser_Users_UsersID",
                table: "InterestUser",
                column: "UsersID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_UserID",
                table: "Users",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InterestUser_Users_UsersID",
                table: "InterestUser");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_UserID",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Users",
                newName: "UserUniqueNumber");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Users",
                newName: "UniqueNumber");

            migrationBuilder.RenameIndex(
                name: "IX_Users_UserID",
                table: "Users",
                newName: "IX_Users_UserUniqueNumber");

            migrationBuilder.RenameColumn(
                name: "UsersID",
                table: "InterestUser",
                newName: "UsersUniqueNumber");

            migrationBuilder.RenameIndex(
                name: "IX_InterestUser_UsersID",
                table: "InterestUser",
                newName: "IX_InterestUser_UsersUniqueNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_InterestUser_Users_UsersUniqueNumber",
                table: "InterestUser",
                column: "UsersUniqueNumber",
                principalTable: "Users",
                principalColumn: "UniqueNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_UserUniqueNumber",
                table: "Users",
                column: "UserUniqueNumber",
                principalTable: "Users",
                principalColumn: "UniqueNumber",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
