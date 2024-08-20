using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventPlanning.Data.Migrations
{
    public partial class ApplyRolesChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72130c6e-e049-4265-bf85-abbd63bdf126");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "acd6f66d-8891-4b05-8926-68b9ae268690");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "72130c6e-e049-4265-bf85-abbd63bdf126", "8f163e4f-b52e-4fe8-8ff6-e8e422f7cb82", "Guest", "GUEST" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "acd6f66d-8891-4b05-8926-68b9ae268690", "9f037844-ec9c-4e3e-9b61-9d7a8c04c674", "Admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e345687-a24d-4344-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d30c90fe-024f-4c2a-84c5-40d296715da8", "AQAAAAEAACcQAAAAEEW5kRO1j9oVl+MUZ1pZ95u7DsLkFLtP8Bbzi3jdRTI41vbpdTXql+mKUZ+II+IB+Q==", "4516fd1c-176b-4c8e-a944-57898108cd62" });
        }
    }
}
