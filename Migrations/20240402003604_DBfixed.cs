using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineShopBackend.Migrations
{
    /// <inheritdoc />
    public partial class DBfixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Waiting_duration",
                table: "OrderStatus",
                newName: "WaitingDuration");

            migrationBuilder.RenameColumn(
                name: "Tarck_location",
                table: "OrderStatus",
                newName: "TarckLocation");

            migrationBuilder.RenameColumn(
                name: "Unit_price",
                table: "OrderDetails",
                newName: "UnitPrice");

            migrationBuilder.RenameColumn(
                name: "Total_amount",
                table: "Bills",
                newName: "TotalAmount");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WaitingDuration",
                table: "OrderStatus",
                newName: "Waiting_duration");

            migrationBuilder.RenameColumn(
                name: "TarckLocation",
                table: "OrderStatus",
                newName: "Tarck_location");

            migrationBuilder.RenameColumn(
                name: "UnitPrice",
                table: "OrderDetails",
                newName: "Unit_price");

            migrationBuilder.RenameColumn(
                name: "TotalAmount",
                table: "Bills",
                newName: "Total_amount");
        }
    }
}
