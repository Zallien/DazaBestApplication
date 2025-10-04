using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SystemBackEnd.Migrations
{
    /// <inheritdoc />
    public partial class AddPurcahsesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PurcahseItemHeader",
                columns: table => new
                {
                    Row = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Purchaseheaderid = table.Column<Guid>(type: "TEXT", nullable: false),
                    Purchasenumber = table.Column<string>(type: "TEXT", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Addedby = table.Column<Guid>(type: "TEXT", nullable: false),
                    Dateverified = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Verifiedby = table.Column<Guid>(type: "TEXT", nullable: false),
                    Isverified = table.Column<bool>(type: "INTEGER", nullable: false),
                    Grandtotal = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurcahseItemHeader", x => x.Row);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseItemDetails",
                columns: table => new
                {
                    Row = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Purchaseheaderid = table.Column<Guid>(type: "TEXT", nullable: false),
                    Purchasedetailsid = table.Column<Guid>(type: "TEXT", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    Priceperunit = table.Column<decimal>(type: "TEXT", nullable: false),
                    MyProperty = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseItemDetails", x => x.Row);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PurcahseItemHeader");

            migrationBuilder.DropTable(
                name: "PurchaseItemDetails");
        }
    }
}
