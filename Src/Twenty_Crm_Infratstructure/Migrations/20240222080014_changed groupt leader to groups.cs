using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Twenty_Crm_Infratstructure.Migrations
{
    /// <inheritdoc />
    public partial class changedgrouptleadertogroups : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GroupLeaders_Users_UserId",
                table: "GroupLeaders");

            migrationBuilder.DropForeignKey(
                name: "FK_SubGroups_GroupLeaders_GroupLeaderRef",
                table: "SubGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_UserToGroup_GroupLeaders_GropuRef",
                table: "UserToGroup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GroupLeaders",
                table: "GroupLeaders");

            migrationBuilder.RenameTable(
                name: "GroupLeaders",
                newName: "Groups");

            migrationBuilder.RenameIndex(
                name: "IX_GroupLeaders_UserId",
                table: "Groups",
                newName: "IX_Groups_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Groups",
                table: "Groups",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Users_UserId",
                table: "Groups",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubGroups_Groups_GroupLeaderRef",
                table: "SubGroups",
                column: "GroupLeaderRef",
                principalTable: "Groups",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserToGroup_Groups_GropuRef",
                table: "UserToGroup",
                column: "GropuRef",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Users_UserId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_SubGroups_Groups_GroupLeaderRef",
                table: "SubGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_UserToGroup_Groups_GropuRef",
                table: "UserToGroup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Groups",
                table: "Groups");

            migrationBuilder.RenameTable(
                name: "Groups",
                newName: "GroupLeaders");

            migrationBuilder.RenameIndex(
                name: "IX_Groups_UserId",
                table: "GroupLeaders",
                newName: "IX_GroupLeaders_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GroupLeaders",
                table: "GroupLeaders",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GroupLeaders_Users_UserId",
                table: "GroupLeaders",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubGroups_GroupLeaders_GroupLeaderRef",
                table: "SubGroups",
                column: "GroupLeaderRef",
                principalTable: "GroupLeaders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserToGroup_GroupLeaders_GropuRef",
                table: "UserToGroup",
                column: "GropuRef",
                principalTable: "GroupLeaders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
