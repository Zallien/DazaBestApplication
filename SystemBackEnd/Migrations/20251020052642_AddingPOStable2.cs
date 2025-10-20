using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SystemBackEnd.Migrations
{
    /// <inheritdoc />
    public partial class AddingPOStable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "POSTransactionHistory",
                columns: table => new
                {
                    Row = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TransactionHeaderId = table.Column<Guid>(type: "TEXT", nullable: false),
                    TransactionHistoryId = table.Column<Guid>(type: "TEXT", nullable: false),
                    TransactionHistoryTitle = table.Column<string>(type: "TEXT", nullable: true),
                    TransactionHistoryDetails = table.Column<string>(type: "TEXT", nullable: true),
                    TransactionHistoryDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_POSTransactionHistory", x => x.Row);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "POSTransactionHistory");
        }
    }
}
