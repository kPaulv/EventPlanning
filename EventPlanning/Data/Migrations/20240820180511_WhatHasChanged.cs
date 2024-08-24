using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventPlanning.Data.Migrations
{
    public partial class WhatHasChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b568575-e9a8-4f22-bf9f-1af2d56cd60b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85c97308-6173-4974-bf01-112360a7caf6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "02fc2420-7ef5-46dd-b73c-f3bb367ab55f", "7e12abee-4d4a-4271-a48e-ce30f5e33418", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f4eb8ee9-6cc7-409f-89c5-d91f69410262", "45587881-3c0d-41f9-8e17-f122b5d98307", "Guest", "GUEST" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e345687-a24d-4344-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd8cff20-2aba-4612-9a3c-0f21f74dd69b", "AQAAAAEAACcQAAAAEAgSSkmw4SuVuok3uk6lnw8wYKAFWK06BefbbPp1Z2L7co0OYsHDPReyX6lVLzBsqQ==", "dff179d6-dd87-401a-8cc4-a68bde0b6951" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02fc2420-7ef5-46dd-b73c-f3bb367ab55f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4eb8ee9-6cc7-409f-89c5-d91f69410262");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7b568575-e9a8-4f22-bf9f-1af2d56cd60b", "1a61b090-37db-4594-9e36-90d4f1fd80c6", "Guest", "GUEST" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "85c97308-6173-4974-bf01-112360a7caf6", "30bd6db1-1388-42a0-8004-38d86dabc426", "Admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e345687-a24d-4344-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f89d70b8-b5c1-487f-97a8-8fb58c82bd51", "AQAAAAEAACcQAAAAEABO/LmWg4y+Fg7nzG1ks9DrOhDhYnHf50+dQpQdgw3qqahprGcPZtRBL0tp7fLGmA==", "d6859c26-4cd2-43f2-9469-15218e529689" });
        }
    }
}
