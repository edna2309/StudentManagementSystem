using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagementSystem.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "4a15c4bc-ffac-481c-b997-475a1e82c911",
                column: "ConcurrencyStamp",
                value: "a95b9262-dbc6-46ed-b80e-c24d4feb2ede");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "88105423-d222-48ec-85c5-04e4f3cb2aa6",
                column: "ConcurrencyStamp",
                value: "4daf2624-f8ab-481d-b13e-8e2740f5a0cc");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5843c9b4-cb39-4efd-843c-dbaea81c4706",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateModified", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3e8ff69-1a56-4c25-84f0-0d3da7983d87", new DateTime(2023, 8, 24, 14, 10, 6, 660, DateTimeKind.Local).AddTicks(450), new DateTime(2023, 8, 24, 14, 10, 6, 660, DateTimeKind.Local).AddTicks(452), "AQAAAAEAACcQAAAAENnQfXJpU41i9vRKva0H4E51qunqBmmUdehDq90G7LUK06udZP53t4Tw3hm9K+gHFQ==", "de6cff4e-0667-47d5-9349-f0b017897464" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "807d4075-6fa0-465e-aa89-6255708fde21",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateModified", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1fb9d3d4-25f5-4844-8a53-b01df2eaed95", new DateTime(2023, 8, 24, 14, 10, 6, 658, DateTimeKind.Local).AddTicks(9019), new DateTime(2023, 8, 24, 14, 10, 6, 658, DateTimeKind.Local).AddTicks(9059), "AQAAAAEAACcQAAAAEEDx5Ckm2/Dqnu0511nWWAIyPzYUbtNc6l5OcUvw6N/qqg9RKhKAYHFoCEiHfxdqYA==", "c7aa5510-3ada-496b-bbee-a978896cc564" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "4a15c4bc-ffac-481c-b997-475a1e82c911",
                column: "ConcurrencyStamp",
                value: "b2d21600-5d18-4382-b3ba-4725a6dce729");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "88105423-d222-48ec-85c5-04e4f3cb2aa6",
                column: "ConcurrencyStamp",
                value: "c1bf0e4d-ff6d-4517-bb17-b4cf8ff9a29e");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5843c9b4-cb39-4efd-843c-dbaea81c4706",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateModified", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e23a6b3a-39a3-470c-8dac-5c8f03b36c06", new DateTime(2022, 11, 15, 12, 16, 35, 112, DateTimeKind.Local).AddTicks(4278), new DateTime(2022, 11, 15, 12, 16, 35, 112, DateTimeKind.Local).AddTicks(4281), "AQAAAAEAACcQAAAAENzpAHKOVZyYenGtS5tg+Ja4HURgXWwVkx3ioiA718/WwXXOOH+rv3GoZ/ysJWe2fQ==", "b97109c9-9777-43dc-be21-f995c2161ca9" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "807d4075-6fa0-465e-aa89-6255708fde21",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateModified", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4063cf39-16ba-4e60-8394-b01ae7f44408", new DateTime(2022, 11, 15, 12, 16, 35, 106, DateTimeKind.Local).AddTicks(7247), new DateTime(2022, 11, 15, 12, 16, 35, 106, DateTimeKind.Local).AddTicks(7284), "AQAAAAEAACcQAAAAEATHLvzzgOTd7MVVOayJpiYuEC9c/9tWJ9RdjbN4OX+lWvYSlV6RNuKGThIchVaAAg==", "51f55a17-7e38-4b5c-a646-ab1e9127a2a7" });
        }
    }
}
