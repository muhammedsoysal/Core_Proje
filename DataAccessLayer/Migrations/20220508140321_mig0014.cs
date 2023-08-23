using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig0014 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_WrriterMessages",
                table: "WrriterMessages");

            migrationBuilder.RenameTable(
                name: "WrriterMessages",
                newName: "WriterMessages");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WriterMessages",
                table: "WriterMessages",
                column: "WriterMessageID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_WriterMessages",
                table: "WriterMessages");

            migrationBuilder.RenameTable(
                name: "WriterMessages",
                newName: "WrriterMessages");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WrriterMessages",
                table: "WrriterMessages",
                column: "WriterMessageID");
        }
    }
}
