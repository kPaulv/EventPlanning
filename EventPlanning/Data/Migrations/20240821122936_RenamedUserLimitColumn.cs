using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventPlanning.Data.Migrations
{
    public partial class RenamedUserLimitColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ParticipantsCount",
                table: "Events",
                newName: "UserLimit");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserLimit",
                table: "Events",
                newName: "ParticipantsCount");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a13f68d-a1d0-4d23-869b-458c301ca761",
                column: "ConcurrencyStamp",
                value: "61fc6bca-bc18-49c5-b325-d203919465d7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a14f69d-a2d1-5d34-970b-569c412ca872",
                column: "ConcurrencyStamp",
                value: "76e7395b-3470-4d4c-abac-59b84ae7b796");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e345687-a24d-4344-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bac443d6-00d1-45cf-a16f-487db84be641", "AQAAAAEAACcQAAAAEBvHNP8eax6uhQLb9t5vUeCSWUN81gpYbESG2aGZVRJohfNpI99GXXd5gshugg//bg==", "57c99ec2-a64b-463b-b6ef-1c576a80bdf1" });
        }
    }
}
