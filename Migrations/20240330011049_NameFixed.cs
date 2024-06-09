using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineShopBackend.Migrations
{
    /// <inheritdoc />
    public partial class NameFixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerCards_Customers_customerId",
                table: "CustomerCards");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Orders_orderId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Products_productId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Bills_billId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_CustomerCards_customerCardId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_categoryId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "rating",
                table: "Products",
                newName: "Rating");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Products",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Products",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "categoryId",
                table: "Products",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_categoryId",
                table: "Products",
                newName: "IX_Products_CategoryId");

            migrationBuilder.RenameColumn(
                name: "date",
                table: "Payments",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "customerCardId",
                table: "Payments",
                newName: "CustomerCardId");

            migrationBuilder.RenameColumn(
                name: "billId",
                table: "Payments",
                newName: "BillId");

            migrationBuilder.RenameColumn(
                name: "amount",
                table: "Payments",
                newName: "Amount");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_customerCardId",
                table: "Payments",
                newName: "IX_Payments_CustomerCardId");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_billId",
                table: "Payments",
                newName: "IX_Payments_BillId");

            migrationBuilder.RenameColumn(
                name: "waiting_duration",
                table: "OrderStatus",
                newName: "Waiting_duration");

            migrationBuilder.RenameColumn(
                name: "tarck_location",
                table: "OrderStatus",
                newName: "Tarck_location");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "OrderStatus",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "reason",
                table: "OrderStatus",
                newName: "Reason");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "OrderStatus",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "date",
                table: "OrderStatus",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "unit_price",
                table: "OrderDetails",
                newName: "Unit_price");

            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "OrderDetails",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "productId",
                table: "OrderDetails",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "orderId",
                table: "OrderDetails",
                newName: "OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_productId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_orderId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_OrderId");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "Customers",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "customerId",
                table: "CustomerCards",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerCards_customerId",
                table: "CustomerCards",
                newName: "IX_CustomerCards_CustomerId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Categories",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Categories",
                newName: "Description");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerCards_Customers_CustomerId",
                table: "CustomerCards",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Orders_OrderId",
                table: "OrderDetails",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Products_ProductId",
                table: "OrderDetails",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Bills_BillId",
                table: "Payments",
                column: "BillId",
                principalTable: "Bills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_CustomerCards_CustomerCardId",
                table: "Payments",
                column: "CustomerCardId",
                principalTable: "CustomerCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerCards_Customers_CustomerId",
                table: "CustomerCards");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Orders_OrderId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Products_ProductId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Bills_BillId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_CustomerCards_CustomerCardId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Rating",
                table: "Products",
                newName: "rating");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Products",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Products",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Products",
                newName: "categoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                newName: "IX_Products_categoryId");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Payments",
                newName: "date");

            migrationBuilder.RenameColumn(
                name: "CustomerCardId",
                table: "Payments",
                newName: "customerCardId");

            migrationBuilder.RenameColumn(
                name: "BillId",
                table: "Payments",
                newName: "billId");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Payments",
                newName: "amount");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_CustomerCardId",
                table: "Payments",
                newName: "IX_Payments_customerCardId");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_BillId",
                table: "Payments",
                newName: "IX_Payments_billId");

            migrationBuilder.RenameColumn(
                name: "Waiting_duration",
                table: "OrderStatus",
                newName: "waiting_duration");

            migrationBuilder.RenameColumn(
                name: "Tarck_location",
                table: "OrderStatus",
                newName: "tarck_location");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "OrderStatus",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "Reason",
                table: "OrderStatus",
                newName: "reason");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "OrderStatus",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "OrderStatus",
                newName: "date");

            migrationBuilder.RenameColumn(
                name: "Unit_price",
                table: "OrderDetails",
                newName: "unit_price");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "OrderDetails",
                newName: "quantity");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "OrderDetails",
                newName: "productId");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "OrderDetails",
                newName: "orderId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_productId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_orderId");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Customers",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "CustomerCards",
                newName: "customerId");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerCards_CustomerId",
                table: "CustomerCards",
                newName: "IX_CustomerCards_customerId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Categories",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Categories",
                newName: "description");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerCards_Customers_customerId",
                table: "CustomerCards",
                column: "customerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Orders_orderId",
                table: "OrderDetails",
                column: "orderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Products_productId",
                table: "OrderDetails",
                column: "productId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Bills_billId",
                table: "Payments",
                column: "billId",
                principalTable: "Bills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_CustomerCards_customerCardId",
                table: "Payments",
                column: "customerCardId",
                principalTable: "CustomerCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_categoryId",
                table: "Products",
                column: "categoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
