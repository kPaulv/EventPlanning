using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventPlanning.Data.Migrations
{
    public partial class ReapplySeedingAdminData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1a13f68d-a1d0-4d23-869b-458c301ca761", "c58c6771-4102-41d9-8759-75de90abbc09", "Admin", "ADMIN" },
                    { "2a14f69d-a2d1-5d34-970b-569c412ca872", "aa19d274-6767-4f21-b5d5-324e1c1711f5", "Guest", "GUEST" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1e345687-a24d-4344-a6c6-9443d048cdb9", 0, "92b8b022-0625-48a5-9bef-58b1a753fb66", "youradmin@mail.com", false, false, null, "YOURADMIN@MAIL.COM", "PAULMAUL", "AQAAAAEAACcQAAAAEAuEVMJhH4sMKRX5r6MQ5GoSX2oV8W7Dp8Z64oSx1ofH+w2zHMnXCxqGVSq4Zc1biA==", null, false, "114deb65-499c-4075-bd8f-fbae6806b63d", false, "paulmaul" });

            migrationBuilder.InsertData(
                table: "EventTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Sport" },
                    { 2, "Music" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1a13f68d-a1d0-4d23-869b-458c301ca761", "1e345687-a24d-4344-a6c6-9443d048cdb9" });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Dresscode", "Location", "Name", "Participants", "TypeId" },
                values: new object[,]
                {
                    { 1, null, null, "Football Match", null, 1 },
                    { 2, null, null, "Test Event", null, 2 }
                });

            migrationBuilder.InsertData(
                table: "eventSubtypes",
                columns: new[] { "Id", "Name", "TypeId" },
                values: new object[,]
                {
                    { 1, "Rock", 2 },
                    { 2, "Classical music", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a14f69d-a2d1-5d34-970b-569c412ca872");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1a13f68d-a1d0-4d23-869b-458c301ca761", "1e345687-a24d-4344-a6c6-9443d048cdb9" });

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "eventSubtypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "eventSubtypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a13f68d-a1d0-4d23-869b-458c301ca761");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e345687-a24d-4344-a6c6-9443d048cdb9");

            migrationBuilder.DeleteData(
                table: "EventTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EventTypes",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
