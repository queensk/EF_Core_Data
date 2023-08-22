using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreOneToOneDemo.Migrations
{
    /// <inheritdoc />
    public partial class Schema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_People_Id",
                table: "Addresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_People",
                table: "People");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.RenameTable(
                name: "People",
                newName: "Person, Schema = public");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "Address, Schema = public");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Person, Schema = public",
                table: "Person, Schema = public",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address, Schema = public",
                table: "Address, Schema = public",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Address, Schema = public_Person, Schema = public_Id",
                table: "Address, Schema = public",
                column: "Id",
                principalTable: "Person, Schema = public",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address, Schema = public_Person, Schema = public_Id",
                table: "Address, Schema = public");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Person, Schema = public",
                table: "Person, Schema = public");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address, Schema = public",
                table: "Address, Schema = public");

            migrationBuilder.RenameTable(
                name: "Person, Schema = public",
                newName: "People");

            migrationBuilder.RenameTable(
                name: "Address, Schema = public",
                newName: "Addresses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_People",
                table: "People",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_People_Id",
                table: "Addresses",
                column: "Id",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
