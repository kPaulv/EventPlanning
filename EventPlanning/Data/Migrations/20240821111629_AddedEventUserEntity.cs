using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventPlanning.Data.Migrations
{
    public partial class AddedEventUserEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParticipantsCount",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "EventUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EventEventUser",
                columns: table => new
                {
                    EventsId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventEventUser", x => new { x.EventsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_EventEventUser_Events_EventsId",
                        column: x => x.EventsId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventEventUser_EventUser_UsersId",
                        column: x => x.UsersId,
                        principalTable: "EventUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_EventEventUser_UsersId",
                table: "EventEventUser",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventEventUser");

            migrationBuilder.DropTable(
                name: "EventUser");

            migrationBuilder.DropColumn(
                name: "ParticipantsCount",
                table: "Events");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a13f68d-a1d0-4d23-869b-458c301ca761",
                column: "ConcurrencyStamp",
                value: "c58c6771-4102-41d9-8759-75de90abbc09");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a14f69d-a2d1-5d34-970b-569c412ca872",
                column: "ConcurrencyStamp",
                value: "aa19d274-6767-4f21-b5d5-324e1c1711f5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e345687-a24d-4344-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92b8b022-0625-48a5-9bef-58b1a753fb66", "AQAAAAEAACcQAAAAEAuEVMJhH4sMKRX5r6MQ5GoSX2oV8W7Dp8Z64oSx1ofH+w2zHMnXCxqGVSq4Zc1biA==", "114deb65-499c-4075-bd8f-fbae6806b63d" });
        }
    }
}
