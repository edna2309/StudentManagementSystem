using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagementSystem.Data.Migrations
{
    public partial class AddedDepartments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "4a15c4bc-ffac-481c-b997-475a1e82c911",
                column: "ConcurrencyStamp",
                value: "bde6e76e-cf84-400d-ad16-3743eb08536d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "88105423-d222-48ec-85c5-04e4f3cb2aa6",
                column: "ConcurrencyStamp",
                value: "bd9778da-70f3-4bc2-a9bf-011de4d9e2a6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8bb3807a-9f64-42a6-9b15-e9ca45435d16",
                column: "ConcurrencyStamp",
                value: "5f49100c-a31d-490d-a759-51e90fff2671");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "37ccb1d3-1a9b-4a38-99de-eb91eeb95adf",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateModified", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a809fec7-060f-4978-9fc7-3a9a0341e85a", new DateTime(2022, 10, 16, 20, 19, 43, 832, DateTimeKind.Local).AddTicks(9927), new DateTime(2022, 10, 16, 20, 19, 43, 832, DateTimeKind.Local).AddTicks(9929), "AQAAAAEAACcQAAAAEL6Hc6yGkxroQxpsdAshJJWq3uxGu8WXTtcxqYtgLw0uCepAhJ2blxf19N0w7PVwdQ==", "74ece44a-e736-454c-b888-9dd0f0a0205b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5843c9b4-cb39-4efd-843c-dbaea81c4706",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateModified", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1520676c-541d-49fa-890b-d15cf1c1e73c", new DateTime(2022, 10, 16, 20, 19, 43, 831, DateTimeKind.Local).AddTicks(8865), new DateTime(2022, 10, 16, 20, 19, 43, 831, DateTimeKind.Local).AddTicks(8867), "AQAAAAEAACcQAAAAEKCxumZXeXb5DBEXxlZc6MTOixvpSwvqdNXQsJnyglrZG1IYMAoJt77gSlO0EJ5hwA==", "5351c3cc-2f1e-4939-b2a0-5bc0049c07c6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "807d4075-6fa0-465e-aa89-6255708fde21",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateModified", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53a95286-b143-4a98-a745-637e89c08460", new DateTime(2022, 10, 16, 20, 19, 43, 830, DateTimeKind.Local).AddTicks(7750), new DateTime(2022, 10, 16, 20, 19, 43, 830, DateTimeKind.Local).AddTicks(7785), "AQAAAAEAACcQAAAAEBG/3w+biA3rIxg/4kFHuDTrzCkYPoU0MKDb5qFM461KGRQXCUjieT5qL4kXbTB03Q==", "59c4c63c-1863-4b09-8ce2-67351fc418a4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "4a15c4bc-ffac-481c-b997-475a1e82c911",
                column: "ConcurrencyStamp",
                value: "2b06815b-8ef8-491d-8e03-9e2f3a21ea7e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "88105423-d222-48ec-85c5-04e4f3cb2aa6",
                column: "ConcurrencyStamp",
                value: "26b238b8-2065-4eb4-9786-2e877225c302");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8bb3807a-9f64-42a6-9b15-e9ca45435d16",
                column: "ConcurrencyStamp",
                value: "7b6f19a8-4025-4e3c-9c0d-1dfdce9fcbac");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "37ccb1d3-1a9b-4a38-99de-eb91eeb95adf",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateModified", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5dae7bd1-daf6-4a24-8436-17228f94b8dd", new DateTime(2022, 10, 15, 13, 17, 5, 275, DateTimeKind.Local).AddTicks(6594), new DateTime(2022, 10, 15, 13, 17, 5, 275, DateTimeKind.Local).AddTicks(6597), "AQAAAAEAACcQAAAAECOjLtUWSY0CBOQa9MriIPbrgRsmdA3mBF+EtRyUkbnwew99Hl4VjRuFRj6rArDqkQ==", "c798fdc9-c3c3-490e-9b40-7444a238d41f" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5843c9b4-cb39-4efd-843c-dbaea81c4706",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateModified", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24f1e9ca-1210-4c0c-9da0-1eb521c4d5c5", new DateTime(2022, 10, 15, 13, 17, 5, 274, DateTimeKind.Local).AddTicks(5586), new DateTime(2022, 10, 15, 13, 17, 5, 274, DateTimeKind.Local).AddTicks(5589), "AQAAAAEAACcQAAAAEF4iKbqwIDMQ1GqYFwcchwb4xCdsWe47WqIu1reZEZP9DrsNu1xHBpP2549YKOe80Q==", "42ce1675-f716-4de4-98f3-a6b7736fd8c8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "807d4075-6fa0-465e-aa89-6255708fde21",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateModified", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c556c9d-c67f-4dee-9e06-75058c82b1a9", new DateTime(2022, 10, 15, 13, 17, 5, 273, DateTimeKind.Local).AddTicks(4535), new DateTime(2022, 10, 15, 13, 17, 5, 273, DateTimeKind.Local).AddTicks(4572), "AQAAAAEAACcQAAAAEFlP8LVoOt0qW0fAb+ISjpYGVynoUvz34nuL2OJNOSrtUoSNF3pnKhQQeJ0vW66pFQ==", "9c594466-9d56-4a21-873e-e627dd8379f5" });
        }
    }
}
