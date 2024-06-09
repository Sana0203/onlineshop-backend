using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineShopBackend.Migrations
{
    /// <inheritdoc />
    public partial class DBfixed5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Products",
                newName: "ProductCategoriesId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                newName: "IX_Products_ProductCategoriesId");

            migrationBuilder.RenameColumn(
                name: "Expiry_date",
                table: "CustomerCards",
                newName: "ExpiryDate");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_ProductCategoriesId",
                table: "Products",
                column: "ProductCategoriesId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_ProductCategoriesId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "ProductCategoriesId",
                table: "Products",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ProductCategoriesId",
                table: "Products",
                newName: "IX_Products_CategoryId");

            migrationBuilder.RenameColumn(
                name: "ExpiryDate",
                table: "CustomerCards",
                newName: "Expiry_date");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
