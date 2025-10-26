using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SystemBackEnd.Migrations
{
    /// <inheritdoc />
    public partial class AddMigrationProjectSystemBackEnd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Row = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AccountId = table.Column<Guid>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    IsOwner = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Row);
                });

            migrationBuilder.CreateTable(
                name: "ItemAdjustmentDetails",
                columns: table => new
                {
                    Row = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ReferenceDetailsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ReferenceHeaderId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ItemId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Reason = table.Column<string>(type: "TEXT", nullable: true),
                    RemovedQuantity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemAdjustmentDetails", x => x.Row);
                });

            migrationBuilder.CreateTable(
                name: "ItemAdjustmentHeader",
                columns: table => new
                {
                    Row = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ReferenceHeaderId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ReferenceNumber = table.Column<string>(type: "TEXT", nullable: true),
                    DateOperated = table.Column<DateTime>(type: "TEXT", nullable: false),
                    OperatedBy = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemAdjustmentHeader", x => x.Row);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "ItemAdjustmentDetails");

            migrationBuilder.DropTable(
                name: "ItemAdjustmentHeader");
        }
    }
}
