using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedCustomerFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0770a08e-3529-4ccc-ae8e-145059a2192f",
                column: "ConcurrencyStamp",
                value: "cf47e329-db0e-4c27-a713-8e51fefbcce8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13cbb285-08fd-4e6c-87dc-a85e520b168e",
                column: "ConcurrencyStamp",
                value: "dd930683-ff06-4f24-9916-98f3002d4b27");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "160ff901-ef5f-4512-91eb-361cac1106f4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "152b52b5-79ca-4bc2-a590-2ac531386581", "AQAAAAEAACcQAAAAENZXDIj3k/vPKi4gnoaIk8qa4nfJQKL8ZlM/P57+3xcDe288etA0E6pSpvEp+z9nIg==", "445c4f9f-a36c-4886-9979-c878a8ca31d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "870c51c3-c551-4bdf-b5a7-709f3d41706f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f196e8fb-978f-43b0-9c47-9469f9129d71", "AQAAAAEAACcQAAAAEARHgn3coVhqwghDPgwaDxbRJuIFmcBALbegYn4lxiygaG2f3Rtl4D+0042fgwbdhA==", "95e24140-808a-4331-95cf-7d57305bb8d0" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 9, 9, 59, 44, 75, DateTimeKind.Local).AddTicks(1444), new DateTime(2021, 5, 9, 9, 59, 44, 77, DateTimeKind.Local).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 9, 9, 59, 44, 77, DateTimeKind.Local).AddTicks(4596), new DateTime(2021, 5, 9, 9, 59, 44, 77, DateTimeKind.Local).AddTicks(4609) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 9, 9, 59, 44, 78, DateTimeKind.Local).AddTicks(7186), new DateTime(2021, 5, 9, 9, 59, 44, 78, DateTimeKind.Local).AddTicks(7204) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 9, 9, 59, 44, 78, DateTimeKind.Local).AddTicks(7673), new DateTime(2021, 5, 9, 9, 59, 44, 78, DateTimeKind.Local).AddTicks(7683) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 9, 9, 59, 44, 79, DateTimeKind.Local).AddTicks(1382), new DateTime(2021, 5, 9, 9, 59, 44, 79, DateTimeKind.Local).AddTicks(1398) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 9, 9, 59, 44, 79, DateTimeKind.Local).AddTicks(1873), new DateTime(2021, 5, 9, 9, 59, 44, 79, DateTimeKind.Local).AddTicks(1882) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 9, 9, 59, 44, 79, DateTimeKind.Local).AddTicks(1885), new DateTime(2021, 5, 9, 9, 59, 44, 79, DateTimeKind.Local).AddTicks(1887) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 9, 9, 59, 44, 79, DateTimeKind.Local).AddTicks(1890), new DateTime(2021, 5, 9, 9, 59, 44, 79, DateTimeKind.Local).AddTicks(1892) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0770a08e-3529-4ccc-ae8e-145059a2192f",
                column: "ConcurrencyStamp",
                value: "0ed1ae49-b99c-4732-aa88-46f5b4b2e227");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13cbb285-08fd-4e6c-87dc-a85e520b168e",
                column: "ConcurrencyStamp",
                value: "ca5a7db3-370d-4150-a7a0-7224d1c329c7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "160ff901-ef5f-4512-91eb-361cac1106f4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bdbd0087-654f-4edb-b936-7926de80616f", "AQAAAAEAACcQAAAAEGfnScuT/F0HJUdJVmzLDMePh4uoBLXO0EdWjA9zvuObogNsnZbqqUBqvFcYnA7yaw==", "3d4fdd25-0e16-454b-a598-45d34a65fb73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "870c51c3-c551-4bdf-b5a7-709f3d41706f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "161eb0a0-16fe-4b0d-9815-233b40c4835e", "AQAAAAEAACcQAAAAEKcVUItZyDFxK+U2/wZtjHdT2Ui3m87TnplJFbxustbgp6wqfCHfK9JYwQMlWUr20w==", "7b8f3bb4-16d6-4abe-bdba-79c847776872" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 8, 11, 21, 20, 195, DateTimeKind.Local).AddTicks(6475), new DateTime(2021, 5, 8, 11, 21, 20, 197, DateTimeKind.Local).AddTicks(8528) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 8, 11, 21, 20, 197, DateTimeKind.Local).AddTicks(9971), new DateTime(2021, 5, 8, 11, 21, 20, 197, DateTimeKind.Local).AddTicks(9985) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 8, 11, 21, 20, 199, DateTimeKind.Local).AddTicks(2337), new DateTime(2021, 5, 8, 11, 21, 20, 199, DateTimeKind.Local).AddTicks(2353) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 8, 11, 21, 20, 199, DateTimeKind.Local).AddTicks(2965), new DateTime(2021, 5, 8, 11, 21, 20, 199, DateTimeKind.Local).AddTicks(2975) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 8, 11, 21, 20, 199, DateTimeKind.Local).AddTicks(8164), new DateTime(2021, 5, 8, 11, 21, 20, 199, DateTimeKind.Local).AddTicks(8197) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 8, 11, 21, 20, 199, DateTimeKind.Local).AddTicks(8705), new DateTime(2021, 5, 8, 11, 21, 20, 199, DateTimeKind.Local).AddTicks(8715) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 8, 11, 21, 20, 199, DateTimeKind.Local).AddTicks(8718), new DateTime(2021, 5, 8, 11, 21, 20, 199, DateTimeKind.Local).AddTicks(8721) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 8, 11, 21, 20, 199, DateTimeKind.Local).AddTicks(8723), new DateTime(2021, 5, 8, 11, 21, 20, 199, DateTimeKind.Local).AddTicks(8726) });
        }
    }
}
