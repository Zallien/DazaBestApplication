using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SystemBackEnd.Migrations
{
    /// <inheritdoc />
    public partial class AddingPOStable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "POSPaymentTransaction",
                columns: table => new
                {
                    Row = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TransactionHeaderId = table.Column<Guid>(type: "TEXT", nullable: false),
                    PaymentTransactionId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Subtotal = table.Column<decimal>(type: "TEXT", nullable: false),
                    Discount = table.Column<decimal>(type: "TEXT", nullable: false),
                    Total = table.Column<decimal>(type: "TEXT", nullable: false),
                    PaymentAmount = table.Column<decimal>(type: "TEXT", nullable: false),
                    PaymentMethod = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_POSPaymentTransaction", x => x.Row);
                });

            migrationBuilder.CreateTable(
                name: "POSTransactionDetails",
                columns: table => new
                {
                    Row = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TransactionHeaderId = table.Column<Guid>(type: "TEXT", nullable: false),
                    TransactionDetailsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ProductId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_POSTransactionDetails", x => x.Row);
                });

            migrationBuilder.CreateTable(
                name: "POSTransactionHeader",
                columns: table => new
                {
                    Row = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TransactionHeaderId = table.Column<Guid>(type: "TEXT", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TransactionBy = table.Column<Guid>(type: "TEXT", nullable: false),
                    Grandtotal = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_POSTransactionHeader", x => x.Row);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "POSPaymentTransaction");

            migrationBuilder.DropTable(
                name: "POSTransactionDetails");

            migrationBuilder.DropTable(
                name: "POSTransactionHeader");
        }
    }
}
