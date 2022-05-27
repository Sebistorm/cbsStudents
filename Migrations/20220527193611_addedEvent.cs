using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class addedEvent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    StartDate = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    StartTime = table.Column<string>(type: "TEXT", nullable: false),
                    EndTime = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d15a3dd-fb32-4e8c-b4d2-15850942f54c", "AQAAAAEAACcQAAAAEIksvv8JpB8rddlSDJVOH/md13PtZE7Nyr+5iA5O7cku4SwOvaEDH9jGUPPMaBBOAg==", "b363c8a3-9382-4e27-9a5c-303065332e1e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "290cbc4e-b9e6-4ad9-b5c0-da71d48a8160", "AQAAAAEAACcQAAAAEJnPLo2C2rGKvhwy+QiYqrJK2Le4NjW65xnm2JgzfnaK1CKW0Ys9ws7SBJES0lseAg==", "7daef2df-da6b-4d4c-9f26-8821f7ec6595" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 27, 21, 36, 11, 147, DateTimeKind.Local).AddTicks(6063));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 27, 21, 36, 11, 147, DateTimeKind.Local).AddTicks(6068));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 27, 21, 36, 11, 147, DateTimeKind.Local).AddTicks(6074));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 27, 21, 36, 11, 147, DateTimeKind.Local).AddTicks(6077));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 5, 27, 21, 36, 11, 147, DateTimeKind.Local).AddTicks(5974));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 5, 27, 21, 36, 11, 147, DateTimeKind.Local).AddTicks(6021));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 5, 27, 21, 36, 11, 147, DateTimeKind.Local).AddTicks(6025));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea6e0e8b-5c42-49dd-81a4-4e2d51402328", "AQAAAAEAACcQAAAAEAtw7H60mzjhPwaZ+NqRkAjZ4aeSde5fu3YGLSI94/mU/6WuVkBLkykIKECj4a1BxQ==", "3022a109-4222-44bc-a24c-7af9e69df2d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6dc398c9-9202-49b1-b82a-b5e1efd6838b", "AQAAAAEAACcQAAAAEJJ6LmqTnZ+ADQg+V3hgbbOL7y45YvStRo+ySZYGZIEFjHcV0qG8c3I5x06VKudZ1Q==", "26034978-c05a-40e5-92d2-3a5262682eb6" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 4, 25, 10, 6, 46, 740, DateTimeKind.Local).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "TimeStamp",
                value: new DateTime(2022, 4, 25, 10, 6, 46, 740, DateTimeKind.Local).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "TimeStamp",
                value: new DateTime(2022, 4, 25, 10, 6, 46, 740, DateTimeKind.Local).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "TimeStamp",
                value: new DateTime(2022, 4, 25, 10, 6, 46, 740, DateTimeKind.Local).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 4, 25, 10, 6, 46, 739, DateTimeKind.Local).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 4, 25, 10, 6, 46, 740, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 4, 25, 10, 6, 46, 740, DateTimeKind.Local).AddTicks(30));
        }
    }
}
