using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace S_CLMS.Migrations
{
    /// <inheritdoc />
    public partial class updatedmodels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Licenses_Products_ProductId",
                table: "Licenses");

            migrationBuilder.DropForeignKey(
                name: "FK_Licenses_Users_UserId",
                table: "Licenses");

            migrationBuilder.AddForeignKey(
                name: "FK_Licenses_Products_ProductId",
                table: "Licenses",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Licenses_Users_UserId",
                table: "Licenses",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Licenses_Products_ProductId",
                table: "Licenses");

            migrationBuilder.DropForeignKey(
                name: "FK_Licenses_Users_UserId",
                table: "Licenses");

            migrationBuilder.AddForeignKey(
                name: "FK_Licenses_Products_ProductId",
                table: "Licenses",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Licenses_Users_UserId",
                table: "Licenses",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
