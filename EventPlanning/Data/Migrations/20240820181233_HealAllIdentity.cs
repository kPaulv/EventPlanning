using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventPlanning.Data.Migrations
{
    public partial class HealAllIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02fc2420-7ef5-46dd-b73c-f3bb367ab55f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4eb8ee9-6cc7-409f-89c5-d91f69410262");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "02fc2420-7ef5-46dd-b73c-f3bb367ab55f", "7e12abee-4d4a-4271-a48e-ce30f5e33418", "Admin", "ADMIN" },
                    { "f4eb8ee9-6cc7-409f-89c5-d91f69410262", "45587881-3c0d-41f9-8e17-f122b5d98307", "Guest", "GUEST" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1e345687-a24d-4344-a6c6-9443d048cdb9", 0, "fd8cff20-2aba-4612-9a3c-0f21f74dd69b", "youradmin@mail.com", false, false, null, "YOURADMIN@MAIL.COM", "PAULMAUL", "AQAAAAEAACcQAAAAEAgSSkmw4SuVuok3uk6lnw8wYKAFWK06BefbbPp1Z2L7co0OYsHDPReyX6lVLzBsqQ==", null, false, "dff179d6-dd87-401a-8cc4-a68bde0b6951", false, "paulmaul" });

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
    }
}
