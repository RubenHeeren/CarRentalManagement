using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class MadeDateInNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0770a08e-3529-4ccc-ae8e-145059a2192f",
                column: "ConcurrencyStamp",
                value: "308f92e6-7807-4e7a-9b30-6d7e366ff2d5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13cbb285-08fd-4e6c-87dc-a85e520b168e",
                column: "ConcurrencyStamp",
                value: "86dc1625-e169-480b-908a-9775a2a6f4a3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "160ff901-ef5f-4512-91eb-361cac1106f4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1aabd5a6-562c-4072-9631-692885cb937e", "AQAAAAEAACcQAAAAECub4h0ffOCf2GSPU1/ussyZbBmRvcUuC0vLTl+tlJtinF4dz+M6IbYV+dFNpnGOlQ==", "5ad6349f-3455-40c0-87b4-cda845fef895" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "870c51c3-c551-4bdf-b5a7-709f3d41706f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9aa419ec-5591-4698-ae51-0dd916ebd335", "AQAAAAEAACcQAAAAEErZmIfoyVkgtePOvBK89opYWDYfWkUr3asnWWhKb/7s2sJJFQ8SU5LXoPTZ+nv7cA==", "4db69dec-d990-4492-b4d7-677101481478" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 5, 14, 36, 39, 25, DateTimeKind.Local).AddTicks(1387), new DateTime(2021, 5, 5, 14, 36, 39, 27, DateTimeKind.Local).AddTicks(5493) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 5, 14, 36, 39, 27, DateTimeKind.Local).AddTicks(6923), new DateTime(2021, 5, 5, 14, 36, 39, 27, DateTimeKind.Local).AddTicks(6936) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 5, 14, 36, 39, 29, DateTimeKind.Local).AddTicks(62), new DateTime(2021, 5, 5, 14, 36, 39, 29, DateTimeKind.Local).AddTicks(80) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 5, 14, 36, 39, 29, DateTimeKind.Local).AddTicks(554), new DateTime(2021, 5, 5, 14, 36, 39, 29, DateTimeKind.Local).AddTicks(564) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 5, 14, 36, 39, 29, DateTimeKind.Local).AddTicks(4178), new DateTime(2021, 5, 5, 14, 36, 39, 29, DateTimeKind.Local).AddTicks(4193) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 5, 14, 36, 39, 29, DateTimeKind.Local).AddTicks(4660), new DateTime(2021, 5, 5, 14, 36, 39, 29, DateTimeKind.Local).AddTicks(4669) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 5, 14, 36, 39, 29, DateTimeKind.Local).AddTicks(4672), new DateTime(2021, 5, 5, 14, 36, 39, 29, DateTimeKind.Local).AddTicks(4675) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 5, 14, 36, 39, 29, DateTimeKind.Local).AddTicks(4678), new DateTime(2021, 5, 5, 14, 36, 39, 29, DateTimeKind.Local).AddTicks(4680) });
        }
    }
}
