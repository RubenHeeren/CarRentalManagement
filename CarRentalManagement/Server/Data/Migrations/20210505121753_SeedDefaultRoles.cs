using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "13cbb285-08fd-4e6c-87dc-a85e520b168e", "f4f3311d-8d2b-411d-a0e2-16bf943ae876", "User", "USER" },
                    { "0770a08e-3529-4ccc-ae8e-145059a2192f", "af5b758a-c6f1-4953-9204-77d57f63c9dc", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 5, 14, 17, 52, 898, DateTimeKind.Local).AddTicks(2939), new DateTime(2021, 5, 5, 14, 17, 52, 900, DateTimeKind.Local).AddTicks(8022) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 5, 14, 17, 52, 900, DateTimeKind.Local).AddTicks(9435), new DateTime(2021, 5, 5, 14, 17, 52, 900, DateTimeKind.Local).AddTicks(9449) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 5, 14, 17, 52, 902, DateTimeKind.Local).AddTicks(3366), new DateTime(2021, 5, 5, 14, 17, 52, 902, DateTimeKind.Local).AddTicks(3390) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 5, 14, 17, 52, 902, DateTimeKind.Local).AddTicks(3873), new DateTime(2021, 5, 5, 14, 17, 52, 902, DateTimeKind.Local).AddTicks(3883) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 5, 14, 17, 52, 902, DateTimeKind.Local).AddTicks(8020), new DateTime(2021, 5, 5, 14, 17, 52, 902, DateTimeKind.Local).AddTicks(8036) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 5, 14, 17, 52, 902, DateTimeKind.Local).AddTicks(8511), new DateTime(2021, 5, 5, 14, 17, 52, 902, DateTimeKind.Local).AddTicks(8520) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 5, 14, 17, 52, 902, DateTimeKind.Local).AddTicks(8524), new DateTime(2021, 5, 5, 14, 17, 52, 902, DateTimeKind.Local).AddTicks(8526) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 5, 14, 17, 52, 902, DateTimeKind.Local).AddTicks(8529), new DateTime(2021, 5, 5, 14, 17, 52, 902, DateTimeKind.Local).AddTicks(8531) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0770a08e-3529-4ccc-ae8e-145059a2192f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13cbb285-08fd-4e6c-87dc-a85e520b168e");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 5, 14, 10, 10, 945, DateTimeKind.Local).AddTicks(2559), new DateTime(2021, 5, 5, 14, 10, 10, 947, DateTimeKind.Local).AddTicks(8209) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 5, 14, 10, 10, 947, DateTimeKind.Local).AddTicks(9620), new DateTime(2021, 5, 5, 14, 10, 10, 947, DateTimeKind.Local).AddTicks(9633) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 5, 14, 10, 10, 949, DateTimeKind.Local).AddTicks(2638), new DateTime(2021, 5, 5, 14, 10, 10, 949, DateTimeKind.Local).AddTicks(2656) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 5, 14, 10, 10, 949, DateTimeKind.Local).AddTicks(3317), new DateTime(2021, 5, 5, 14, 10, 10, 949, DateTimeKind.Local).AddTicks(3328) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 5, 14, 10, 10, 949, DateTimeKind.Local).AddTicks(6933), new DateTime(2021, 5, 5, 14, 10, 10, 949, DateTimeKind.Local).AddTicks(6948) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 5, 14, 10, 10, 949, DateTimeKind.Local).AddTicks(7418), new DateTime(2021, 5, 5, 14, 10, 10, 949, DateTimeKind.Local).AddTicks(7428) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 5, 14, 10, 10, 949, DateTimeKind.Local).AddTicks(7431), new DateTime(2021, 5, 5, 14, 10, 10, 949, DateTimeKind.Local).AddTicks(7433) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 5, 14, 10, 10, 949, DateTimeKind.Local).AddTicks(7436), new DateTime(2021, 5, 5, 14, 10, 10, 949, DateTimeKind.Local).AddTicks(7438) });
        }
    }
}
