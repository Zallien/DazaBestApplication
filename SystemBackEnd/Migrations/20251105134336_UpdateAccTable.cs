using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SystemBackEnd.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAccTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "FirstTimeLogout",
                table: "Accounts",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstTimeLogout",
                table: "Accounts");
        }
    }
}
