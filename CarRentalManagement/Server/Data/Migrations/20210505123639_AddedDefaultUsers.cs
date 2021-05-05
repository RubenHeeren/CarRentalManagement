using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "160ff901-ef5f-4512-91eb-361cac1106f4", 0, "1aabd5a6-562c-4072-9631-692885cb937e", "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAECub4h0ffOCf2GSPU1/ussyZbBmRvcUuC0vLTl+tlJtinF4dz+M6IbYV+dFNpnGOlQ==", null, false, "5ad6349f-3455-40c0-87b4-cda845fef895", false, "admin@localhost.com" },
                    { "870c51c3-c551-4bdf-b5a7-709f3d41706f", 0, "9aa419ec-5591-4698-ae51-0dd916ebd335", "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEErZmIfoyVkgtePOvBK89opYWDYfWkUr3asnWWhKb/7s2sJJFQ8SU5LXoPTZ+nv7cA==", null, false, "4db69dec-d990-4492-b4d7-677101481478", false, "user@localhost.com" }
                });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0770a08e-3529-4ccc-ae8e-145059a2192f", "160ff901-ef5f-4512-91eb-361cac1106f4" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "13cbb285-08fd-4e6c-87dc-a85e520b168e", "870c51c3-c551-4bdf-b5a7-709f3d41706f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0770a08e-3529-4ccc-ae8e-145059a2192f", "160ff901-ef5f-4512-91eb-361cac1106f4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "13cbb285-08fd-4e6c-87dc-a85e520b168e", "870c51c3-c551-4bdf-b5a7-709f3d41706f" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "160ff901-ef5f-4512-91eb-361cac1106f4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "870c51c3-c551-4bdf-b5a7-709f3d41706f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0770a08e-3529-4ccc-ae8e-145059a2192f",
                column: "ConcurrencyStamp",
                value: "af5b758a-c6f1-4953-9204-77d57f63c9dc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13cbb285-08fd-4e6c-87dc-a85e520b168e",
                column: "ConcurrencyStamp",
                value: "f4f3311d-8d2b-411d-a0e2-16bf943ae876");

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
    }
}
