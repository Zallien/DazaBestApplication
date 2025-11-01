using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SystemBackEnd.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabase002 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TransactionNumber",
                table: "POSTransactionHeader",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransactionNumber",
                table: "POSTransactionHeader");
        }
    }
}
