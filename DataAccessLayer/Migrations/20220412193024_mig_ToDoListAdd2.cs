using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_ToDoListAdd2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_userMessages_users_UserID",
                table: "userMessages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_userMessages",
                table: "userMessages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_toDoList",
                table: "toDoList");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "userMessages",
                newName: "UserMessages");

            migrationBuilder.RenameTable(
                name: "toDoList",
                newName: "ToDoLists");

            migrationBuilder.RenameIndex(
                name: "IX_userMessages_UserID",
                table: "UserMessages",
                newName: "IX_UserMessages_UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserMessages",
                table: "UserMessages",
                column: "MessageID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ToDoLists",
                table: "ToDoLists",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_UserMessages_Users_UserID",
                table: "UserMessages",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserMessages_Users_UserID",
                table: "UserMessages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserMessages",
                table: "UserMessages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ToDoLists",
                table: "ToDoLists");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "users");

            migrationBuilder.RenameTable(
                name: "UserMessages",
                newName: "userMessages");

            migrationBuilder.RenameTable(
                name: "ToDoLists",
                newName: "toDoList");

            migrationBuilder.RenameIndex(
                name: "IX_UserMessages_UserID",
                table: "userMessages",
                newName: "IX_userMessages_UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_userMessages",
                table: "userMessages",
                column: "MessageID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_toDoList",
                table: "toDoList",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_userMessages_users_UserID",
                table: "userMessages",
                column: "UserID",
                principalTable: "users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
