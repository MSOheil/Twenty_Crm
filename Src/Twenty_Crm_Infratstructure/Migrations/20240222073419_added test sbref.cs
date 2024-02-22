using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Twenty_Crm_Infratstructure.Migrations
{
    /// <inheritdoc />
    public partial class addedtestsbref : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "SBStateRef",
                table: "Telephones",
                type: "uniqueidentifier",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SBStateRef",
                table: "Telephones");
        }
    }
}
