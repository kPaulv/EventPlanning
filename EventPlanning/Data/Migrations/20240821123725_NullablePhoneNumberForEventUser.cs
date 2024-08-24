using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventPlanning.Data.Migrations
{
    public partial class NullablePhoneNumberForEventUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "EventUser",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a13f68d-a1d0-4d23-869b-458c301ca761",
                column: "ConcurrencyStamp",
                value: "0c14621b-eed8-4d2b-b74a-82d08f521ae0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a14f69d-a2d1-5d34-970b-569c412ca872",
                column: "ConcurrencyStamp",
                value: "074ab704-6a88-4576-ac0f-5de9259be707");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e345687-a24d-4344-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23a15e27-e330-4a0f-8cff-35c3e2bf336c", "AQAAAAEAACcQAAAAEAROnbMqHpDffPl4nsOC3jLc1b/USgqBdofQk7+lqLp5vChGtwb/JkIDT3cJvEQMWw==", "56691153-e4d2-4450-a6b2-16175ee24db5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "EventUser",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a13f68d-a1d0-4d23-869b-458c301ca761",
                column: "ConcurrencyStamp",
                value: "3507de8c-4e8a-45c8-ae07-60ff444923a4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a14f69d-a2d1-5d34-970b-569c412ca872",
                column: "ConcurrencyStamp",
                value: "4f3bfaae-df47-42e1-aadd-cac0689f3432");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e345687-a24d-4344-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d345e71-e1f9-4bf5-9e6a-42b62c6d382c", "AQAAAAEAACcQAAAAEK3uRT5osT8AR0hwnZrFCkslU8kuEzi6x4Ndy1mmKynhq+gfUZdNjrhogBU5rZSbCQ==", "bad2fe5e-8d49-4072-827c-e94c4729f40d" });
        }
    }
}
