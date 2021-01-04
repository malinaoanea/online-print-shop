using Microsoft.EntityFrameworkCore.Migrations;

namespace PrintShop.Data.Migrations
{
    public partial class ShoppingCartItemCarts1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "CartItems",
                newName: "CartItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CartItemId",
                table: "CartItems",
                newName: "ItemId");
        }
    }
}
