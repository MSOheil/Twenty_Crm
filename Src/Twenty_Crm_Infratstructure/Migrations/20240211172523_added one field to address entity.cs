﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Twenty_Crm_Infratstructure.Migrations
{
    /// <inheritdoc />
    public partial class addedonefieldtoaddressentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "SBCityRef",
                table: "Address",
                type: "uniqueidentifier",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SBCityRef",
                table: "Address");
        }
    }
}
