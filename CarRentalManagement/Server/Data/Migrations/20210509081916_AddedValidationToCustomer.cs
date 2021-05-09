using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedValidationToCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0770a08e-3529-4ccc-ae8e-145059a2192f",
                column: "ConcurrencyStamp",
                value: "8caf9c09-171e-4444-bee7-77a7c69854cb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13cbb285-08fd-4e6c-87dc-a85e520b168e",
                column: "ConcurrencyStamp",
                value: "80ade5aa-0e9a-40c1-8ae0-257a608656eb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "160ff901-ef5f-4512-91eb-361cac1106f4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9b380e8-8fa3-4ba5-9842-056e9e37e58e", "AQAAAAEAACcQAAAAEKP16YuWKaD0qcf0f672B4MJQ4rBcZFa7wEbJAc88PY+fofxS9pIMG0gN7tiSmqXhQ==", "a4b48c28-336c-476f-a775-3625bce13dfa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "870c51c3-c551-4bdf-b5a7-709f3d41706f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37713a20-5ad9-45a9-8964-37554b5a2656", "AQAAAAEAACcQAAAAEHtdxgZzg/qy4tAmHVJT0Bhw/VMMNpW5NaBd4bbapHIRxqoOysYkIbDhgZb83X6W7Q==", "56a2d53c-5bdd-4077-8666-9b21f315c3f0" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 9, 10, 19, 15, 529, DateTimeKind.Local).AddTicks(702), new DateTime(2021, 5, 9, 10, 19, 15, 531, DateTimeKind.Local).AddTicks(3693) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 9, 10, 19, 15, 531, DateTimeKind.Local).AddTicks(5234), new DateTime(2021, 5, 9, 10, 19, 15, 531, DateTimeKind.Local).AddTicks(5248) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 9, 10, 19, 15, 532, DateTimeKind.Local).AddTicks(8422), new DateTime(2021, 5, 9, 10, 19, 15, 532, DateTimeKind.Local).AddTicks(8446) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 9, 10, 19, 15, 532, DateTimeKind.Local).AddTicks(8922), new DateTime(2021, 5, 9, 10, 19, 15, 532, DateTimeKind.Local).AddTicks(8932) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 9, 10, 19, 15, 533, DateTimeKind.Local).AddTicks(2568), new DateTime(2021, 5, 9, 10, 19, 15, 533, DateTimeKind.Local).AddTicks(2582) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 9, 10, 19, 15, 533, DateTimeKind.Local).AddTicks(3048), new DateTime(2021, 5, 9, 10, 19, 15, 533, DateTimeKind.Local).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 9, 10, 19, 15, 533, DateTimeKind.Local).AddTicks(3062), new DateTime(2021, 5, 9, 10, 19, 15, 533, DateTimeKind.Local).AddTicks(3064) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 9, 10, 19, 15, 533, DateTimeKind.Local).AddTicks(3067), new DateTime(2021, 5, 9, 10, 19, 15, 533, DateTimeKind.Local).AddTicks(3069) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
