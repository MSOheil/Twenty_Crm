using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Twenty_Crm_Infratstructure.Migrations
{
    /// <inheritdoc />
    public partial class chnagedmobilefileds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MobileType",
                table: "Telephones");

            migrationBuilder.AddColumn<string>(
                name: "PrePhoneNumber",
                table: "Telephones",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrePhoneNumber",
                table: "Telephones");

            migrationBuilder.AddColumn<int>(
                name: "MobileType",
                table: "Telephones",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
