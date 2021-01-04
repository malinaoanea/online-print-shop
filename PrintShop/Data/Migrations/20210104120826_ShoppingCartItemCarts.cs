using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PrintShop.Data.Migrations
{
    public partial class ShoppingCartItemCarts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    ItemId = table.Column<string>(type: "text", nullable: false),
                    CartId = table.Column<string>(type: "text", nullable: true),
                    ClientId = table.Column<string>(type: "text", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ProductId = table.Column<string>(type: "text", nullable: true),
                    ProductId1 = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_CartItems_Products_ProductId1",
                        column: x => x.ProductId1,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    ClientId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductId1",
                table: "CartItems",
                column: "ProductId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");
        }
    }
}
