using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Twenty_Crm_Infratstructure.Migrations
{
    /// <inheritdoc />
    public partial class updateuserdetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mobiles_Users_UserId",
                table: "Mobiles");

            migrationBuilder.DropIndex(
                name: "IX_Mobiles_UserId",
                table: "Mobiles");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Mobiles");

            migrationBuilder.CreateIndex(
                name: "IX_Mobiles_UserRef",
                table: "Mobiles",
                column: "UserRef");

            migrationBuilder.AddForeignKey(
                name: "FK_Mobiles_Users_UserRef",
                table: "Mobiles",
                column: "UserRef",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mobiles_Users_UserRef",
                table: "Mobiles");

            migrationBuilder.DropIndex(
                name: "IX_Mobiles_UserRef",
                table: "Mobiles");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Mobiles",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mobiles_UserId",
                table: "Mobiles",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mobiles_Users_UserId",
                table: "Mobiles",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
