using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Twenty_Crm_Infratstructure.Migrations
{
    /// <inheritdoc />
    public partial class Updategroupleader : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Banks_Users_UserId",
                table: "Banks");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyToUsers_Users_UserRef",
                table: "CompanyToUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupLeaders_Users_UserRef",
                table: "GroupLeaders");

            migrationBuilder.DropForeignKey(
                name: "FK_Mobiles_Companies_CompanyId",
                table: "Mobiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Mobiles_Users_UserRef",
                table: "Mobiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Companies_CompanyId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "SubGroupUser");

            migrationBuilder.DropIndex(
                name: "IX_Mobiles_UserRef",
                table: "Mobiles");

            migrationBuilder.DropIndex(
                name: "IX_GroupLeaders_UserRef",
                table: "GroupLeaders");

            migrationBuilder.DropIndex(
                name: "IX_CompanyToUsers_UserRef",
                table: "CompanyToUsers");

            migrationBuilder.DropIndex(
                name: "IX_Banks_UserId",
                table: "Banks");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserRef",
                table: "GroupLeaders");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Banks");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "Users",
                newName: "SubGroupId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_CompanyId",
                table: "Users",
                newName: "IX_Users_SubGroupId");

            migrationBuilder.RenameColumn(
                name: "Base64CertificateFile",
                table: "Skills",
                newName: "CertificateFileAddress");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "Mobiles",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Mobiles_CompanyId",
                table: "Mobiles",
                newName: "IX_Mobiles_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "RefreshToken",
                table: "Users",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProfileImage",
                table: "Users",
                type: "nvarchar(600)",
                maxLength: 600,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(170)",
                maxLength: 170,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(170)",
                maxLength: 170,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FatherName",
                table: "Users",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Users",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyCreated",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedCompany",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HashedPassword",
                table: "Users",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UserRef",
                table: "Telephones",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "OperatorRef",
                table: "Telephones",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "CityRef",
                table: "Telephones",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<int>(
                name: "MobileType",
                table: "Telephones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FileType",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "GroupLeaders",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "CompanyToUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UserToGroup",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserRef = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GropuRef = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(140)", maxLength: 140, nullable: true),
                    BaseStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserToGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserToGroup_GroupLeaders_GropuRef",
                        column: x => x.GropuRef,
                        principalTable: "GroupLeaders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserToGroup_Users_UserRef",
                        column: x => x.UserRef,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_GroupLeaders_UserId",
                table: "GroupLeaders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyToUsers_UserId",
                table: "CompanyToUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserToGroup_GropuRef",
                table: "UserToGroup",
                column: "GropuRef");

            migrationBuilder.CreateIndex(
                name: "IX_UserToGroup_UserRef",
                table: "UserToGroup",
                column: "UserRef");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyToUsers_Users_UserId",
                table: "CompanyToUsers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GroupLeaders_Users_UserId",
                table: "GroupLeaders",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Mobiles_Users_UserId",
                table: "Mobiles",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_SubGroups_SubGroupId",
                table: "Users",
                column: "SubGroupId",
                principalTable: "SubGroups",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyToUsers_Users_UserId",
                table: "CompanyToUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupLeaders_Users_UserId",
                table: "GroupLeaders");

            migrationBuilder.DropForeignKey(
                name: "FK_Mobiles_Users_UserId",
                table: "Mobiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_SubGroups_SubGroupId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "UserToGroup");

            migrationBuilder.DropIndex(
                name: "IX_GroupLeaders_UserId",
                table: "GroupLeaders");

            migrationBuilder.DropIndex(
                name: "IX_CompanyToUsers_UserId",
                table: "CompanyToUsers");

            migrationBuilder.DropColumn(
                name: "CompanyCreated",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreatedCompany",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "HashedPassword",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MobileType",
                table: "Telephones");

            migrationBuilder.DropColumn(
                name: "FileType",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "GroupLeaders");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "CompanyToUsers");

            migrationBuilder.RenameColumn(
                name: "SubGroupId",
                table: "Users",
                newName: "CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_SubGroupId",
                table: "Users",
                newName: "IX_Users_CompanyId");

            migrationBuilder.RenameColumn(
                name: "CertificateFileAddress",
                table: "Skills",
                newName: "Base64CertificateFile");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Mobiles",
                newName: "CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_Mobiles_UserId",
                table: "Mobiles",
                newName: "IX_Mobiles_CompanyId");

            migrationBuilder.AlterColumn<string>(
                name: "RefreshToken",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProfileImage",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(600)",
                oldMaxLength: 600,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(170)",
                oldMaxLength: 170,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(170)",
                oldMaxLength: 170,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FatherName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UserRef",
                table: "Telephones",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "OperatorRef",
                table: "Telephones",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CityRef",
                table: "Telephones",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserRef",
                table: "GroupLeaders",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Banks",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SubGroupUser",
                columns: table => new
                {
                    SubGroupsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubGroupUser", x => new { x.SubGroupsId, x.UserId });
                    table.ForeignKey(
                        name: "FK_SubGroupUser_SubGroups_SubGroupsId",
                        column: x => x.SubGroupsId,
                        principalTable: "SubGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubGroupUser_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mobiles_UserRef",
                table: "Mobiles",
                column: "UserRef");

            migrationBuilder.CreateIndex(
                name: "IX_GroupLeaders_UserRef",
                table: "GroupLeaders",
                column: "UserRef");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyToUsers_UserRef",
                table: "CompanyToUsers",
                column: "UserRef");

            migrationBuilder.CreateIndex(
                name: "IX_Banks_UserId",
                table: "Banks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SubGroupUser_UserId",
                table: "SubGroupUser",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Banks_Users_UserId",
                table: "Banks",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyToUsers_Users_UserRef",
                table: "CompanyToUsers",
                column: "UserRef",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupLeaders_Users_UserRef",
                table: "GroupLeaders",
                column: "UserRef",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Mobiles_Companies_CompanyId",
                table: "Mobiles",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Mobiles_Users_UserRef",
                table: "Mobiles",
                column: "UserRef",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Companies_CompanyId",
                table: "Users",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");
        }
    }
}
