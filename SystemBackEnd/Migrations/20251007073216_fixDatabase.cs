using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SystemBackEnd.Migrations
{
    /// <inheritdoc />
    public partial class fixDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "PurchaseItemDetails");

            migrationBuilder.AddColumn<Guid>(
                name: "ItemID",
                table: "PurchaseItemDetails",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemID",
                table: "PurchaseItemDetails");

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "PurchaseItemDetails",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
