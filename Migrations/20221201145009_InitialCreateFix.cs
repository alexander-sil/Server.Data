using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BorrowingPersonId",
                table: "Entries");

            migrationBuilder.AddColumn<int>(
                name: "Person",
                table: "Entries",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Entries_Person",
                table: "Entries",
                column: "Person");

            migrationBuilder.AddForeignKey(
                name: "FK_Entries_People_Person",
                table: "Entries",
                column: "Person",
                principalTable: "People",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entries_People_Person",
                table: "Entries");

            migrationBuilder.DropIndex(
                name: "IX_Entries_Person",
                table: "Entries");

            migrationBuilder.DropColumn(
                name: "Person",
                table: "Entries");

            migrationBuilder.AddColumn<int>(
                name: "BorrowingPersonId",
                table: "Entries",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
