using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeededDefaultCarData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 5, 5, 14, 10, 10, 945, DateTimeKind.Local).AddTicks(2559), new DateTime(2021, 5, 5, 14, 10, 10, 947, DateTimeKind.Local).AddTicks(8209), "Black", "System" },
                    { 2, "System", new DateTime(2021, 5, 5, 14, 10, 10, 947, DateTimeKind.Local).AddTicks(9620), new DateTime(2021, 5, 5, 14, 10, 10, 947, DateTimeKind.Local).AddTicks(9633), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 5, 5, 14, 10, 10, 949, DateTimeKind.Local).AddTicks(2638), new DateTime(2021, 5, 5, 14, 10, 10, 949, DateTimeKind.Local).AddTicks(2656), "BMW", "System" },
                    { 2, "System", new DateTime(2021, 5, 5, 14, 10, 10, 949, DateTimeKind.Local).AddTicks(3317), new DateTime(2021, 5, 5, 14, 10, 10, 949, DateTimeKind.Local).AddTicks(3328), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 5, 5, 14, 10, 10, 949, DateTimeKind.Local).AddTicks(6933), new DateTime(2021, 5, 5, 14, 10, 10, 949, DateTimeKind.Local).AddTicks(6948), "X5", "System" },
                    { 2, "System", new DateTime(2021, 5, 5, 14, 10, 10, 949, DateTimeKind.Local).AddTicks(7418), new DateTime(2021, 5, 5, 14, 10, 10, 949, DateTimeKind.Local).AddTicks(7428), "3 series", "System" },
                    { 3, "System", new DateTime(2021, 5, 5, 14, 10, 10, 949, DateTimeKind.Local).AddTicks(7431), new DateTime(2021, 5, 5, 14, 10, 10, 949, DateTimeKind.Local).AddTicks(7433), "Prius", "System" },
                    { 4, "System", new DateTime(2021, 5, 5, 14, 10, 10, 949, DateTimeKind.Local).AddTicks(7436), new DateTime(2021, 5, 5, 14, 10, 10, 949, DateTimeKind.Local).AddTicks(7438), "Vitz", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
