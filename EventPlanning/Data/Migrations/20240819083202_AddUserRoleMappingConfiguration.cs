using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventPlanning.Data.Migrations
{
    public partial class AddUserRoleMappingConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca9e45d0-785b-408b-a5df-568d4c075e6f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "62265c3a-4399-4277-ab10-c6a360ef7177", "c688f7b3-ac15-47eb-8b9e-2bdb8639b051", "Guest", "GUEST" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1e345687-a24d-4344-a6c6-9443d048cdb9", 0, "e5fdaf00-362f-4aa2-9f1f-dbd753f80933", "youradmin@mail.com", false, false, null, "YOURADMIN@MAIL.COM", "PAULMAUL", "AQAAAAEAACcQAAAAEN8N/CrpKLSAnqqPtasyVFqATuelr94o1ifLFnNLsVGvoBwUBhjFcjp7wOCKmcXI5w==", null, false, "0e4b0d35-37a2-49a6-a81a-21ed75ad0cc3", false, "paulmaul" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1a13f68d-a1d0-4d23-869b-458c301ca761", "1e345687-a24d-4344-a6c6-9443d048cdb9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62265c3a-4399-4277-ab10-c6a360ef7177");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1a13f68d-a1d0-4d23-869b-458c301ca761", "1e345687-a24d-4344-a6c6-9443d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e345687-a24d-4344-a6c6-9443d048cdb9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ca9e45d0-785b-408b-a5df-568d4c075e6f", "030f96b3-341f-464e-b064-8f234e461ea1", "Guest", "Guest" });
        }
    }
}
