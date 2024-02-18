using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Twenty_Crm_Infratstructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdatestateRef : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Telephones_Cities_CityRef",
                table: "Telephones");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "WorkPlaces");

            migrationBuilder.DropColumn(
                name: "ModifyDate",
                table: "WorkPlaces");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Websites");

            migrationBuilder.DropColumn(
                name: "ModifyDate",
                table: "Websites");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "UserToRoles");

            migrationBuilder.DropColumn(
                name: "ModifyDate",
                table: "UserToRoles");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "UserToGroup");

            migrationBuilder.DropColumn(
                name: "ModifyDate",
                table: "UserToGroup");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ModifyDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "UserBodyInformation");

            migrationBuilder.DropColumn(
                name: "ModifyDate",
                table: "UserBodyInformation");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ModifyDate",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Telephones");

            migrationBuilder.DropColumn(
                name: "ModifyDate",
                table: "Telephones");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "SubGroups");

            migrationBuilder.DropColumn(
                name: "ModifyDate",
                table: "SubGroups");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "States");

            migrationBuilder.DropColumn(
                name: "ModifyDate",
                table: "States");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "ModifyDate",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "RoleToClaims");

            migrationBuilder.DropColumn(
                name: "ModifyDate",
                table: "RoleToClaims");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "ModifyDate",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Religions");

            migrationBuilder.DropColumn(
                name: "ModifyDate",
                table: "Religions");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "ModifyDate",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Passports");

            migrationBuilder.DropColumn(
                name: "ModifyDate",
                table: "Passports");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Operators");

            migrationBuilder.DropColumn(
                name: "ModifyDate",
                table: "Operators");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Mobiles");

            migrationBuilder.DropColumn(
                name: "ModifyDate",
                table: "Mobiles");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Marriages");

            migrationBuilder.DropColumn(
                name: "ModifyDate",
                table: "Marriages");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Licenses");

            migrationBuilder.DropColumn(
                name: "ModifyDate",
                table: "Licenses");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "InternationalCertificates");

            migrationBuilder.DropColumn(
                name: "ModifyDate",
                table: "InternationalCertificates");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "GroupLeaders");

            migrationBuilder.DropColumn(
                name: "ModifyDate",
                table: "GroupLeaders");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "ModifyDate",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Counties");

            migrationBuilder.DropColumn(
                name: "ModifyDate",
                table: "Counties");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "CompanyToUsers");

            migrationBuilder.DropColumn(
                name: "ModifyDate",
                table: "CompanyToUsers");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "CompanyToCustomers");

            migrationBuilder.DropColumn(
                name: "ModifyDate",
                table: "CompanyToCustomers");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "ModifyDate",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "ModifyDate",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "ModifyDate",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Banks");

            migrationBuilder.DropColumn(
                name: "ModifyDate",
                table: "Banks");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "BankBranches");

            migrationBuilder.DropColumn(
                name: "ModifyDate",
                table: "BankBranches");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "BankAccounts");

            migrationBuilder.DropColumn(
                name: "ModifyDate",
                table: "BankAccounts");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "ModifyDate",
                table: "Address");

            migrationBuilder.RenameColumn(
                name: "CityRef",
                table: "Telephones",
                newName: "StateRef");

            migrationBuilder.RenameIndex(
                name: "IX_Telephones_CityRef",
                table: "Telephones",
                newName: "IX_Telephones_StateRef");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "WorkPlaces",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(140)",
                oldMaxLength: 140,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Websites",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(140)",
                oldMaxLength: 140,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "UserToRoles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(140)",
                oldMaxLength: 140,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "UserToGroup",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(140)",
                oldMaxLength: 140,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(140)",
                oldMaxLength: 140,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "UserBodyInformation",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(140)",
                oldMaxLength: 140,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Titles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(140)",
                oldMaxLength: 140,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Telephones",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(140)",
                oldMaxLength: 140,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "SubGroups",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(140)",
                oldMaxLength: 140,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "States",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(140)",
                oldMaxLength: 140,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Skills",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(140)",
                oldMaxLength: 140,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "RoleToClaims",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(140)",
                oldMaxLength: 140,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(140)",
                oldMaxLength: 140,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Religions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(140)",
                oldMaxLength: 140,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(140)",
                oldMaxLength: 140,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Passports",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(140)",
                oldMaxLength: 140,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Operators",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(140)",
                oldMaxLength: 140,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Mobiles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(140)",
                oldMaxLength: 140,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Marriages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(140)",
                oldMaxLength: 140,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Licenses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(140)",
                oldMaxLength: 140,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "InternationalCertificates",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(140)",
                oldMaxLength: 140,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "GroupLeaders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(140)",
                oldMaxLength: 140,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Country",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(140)",
                oldMaxLength: 140,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "CompanyToUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(140)",
                oldMaxLength: 140,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "CompanyToCustomers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(140)",
                oldMaxLength: 140,
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "TitleRef",
                table: "Companies",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(140)",
                oldMaxLength: 140,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Claims",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(140)",
                oldMaxLength: 140,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(140)",
                oldMaxLength: 140,
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Telephones_Cities_StateRef",
                table: "Telephones",
                column: "StateRef",
                principalTable: "Cities",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Telephones_Cities_StateRef",
                table: "Telephones");

            migrationBuilder.RenameColumn(
                name: "StateRef",
                table: "Telephones",
                newName: "CityRef");

            migrationBuilder.RenameIndex(
                name: "IX_Telephones_StateRef",
                table: "Telephones",
                newName: "IX_Telephones_CityRef");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "WorkPlaces",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "WorkPlaces",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifyDate",
                table: "WorkPlaces",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Websites",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Websites",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifyDate",
                table: "Websites",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "UserToRoles",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "UserToRoles",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifyDate",
                table: "UserToRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "UserToGroup",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "UserToGroup",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifyDate",
                table: "UserToGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Users",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Users",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifyDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "UserBodyInformation",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "UserBodyInformation",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifyDate",
                table: "UserBodyInformation",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Titles",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Titles",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifyDate",
                table: "Titles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Telephones",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Telephones",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifyDate",
                table: "Telephones",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "SubGroups",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "SubGroups",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifyDate",
                table: "SubGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "States",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "States",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifyDate",
                table: "States",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Skills",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Skills",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifyDate",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "RoleToClaims",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "RoleToClaims",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifyDate",
                table: "RoleToClaims",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Roles",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Roles",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifyDate",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Religions",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Religions",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifyDate",
                table: "Religions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Posts",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Posts",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifyDate",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Passports",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Passports",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifyDate",
                table: "Passports",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Operators",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Operators",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifyDate",
                table: "Operators",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Mobiles",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Mobiles",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifyDate",
                table: "Mobiles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Marriages",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Marriages",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifyDate",
                table: "Marriages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Licenses",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Licenses",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifyDate",
                table: "Licenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "InternationalCertificates",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "InternationalCertificates",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifyDate",
                table: "InternationalCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "GroupLeaders",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "GroupLeaders",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifyDate",
                table: "GroupLeaders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Country",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Country",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifyDate",
                table: "Country",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Counties",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifyDate",
                table: "Counties",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "CompanyToUsers",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "CompanyToUsers",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifyDate",
                table: "CompanyToUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "CompanyToCustomers",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "CompanyToCustomers",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifyDate",
                table: "CompanyToCustomers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<Guid>(
                name: "TitleRef",
                table: "Companies",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Companies",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Companies",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifyDate",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Claims",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Claims",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifyDate",
                table: "Claims",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Cities",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Cities",
                type: "nvarchar(140)",
                maxLength: 140,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifyDate",
                table: "Cities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Banks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifyDate",
                table: "Banks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "BankBranches",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifyDate",
                table: "BankBranches",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "BankAccounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifyDate",
                table: "BankAccounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Address",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifyDate",
                table: "Address",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_Telephones_Cities_CityRef",
                table: "Telephones",
                column: "CityRef",
                principalTable: "Cities",
                principalColumn: "Id");
        }
    }
}
