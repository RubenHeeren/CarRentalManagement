using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedImageToVehicles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0770a08e-3529-4ccc-ae8e-145059a2192f",
                column: "ConcurrencyStamp",
                value: "cfe7e7dd-149f-48fe-bfec-c471dccaca06");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13cbb285-08fd-4e6c-87dc-a85e520b168e",
                column: "ConcurrencyStamp",
                value: "88f0f036-18c3-4aa0-96f7-984331f3e8e6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "160ff901-ef5f-4512-91eb-361cac1106f4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02d03404-6f09-4b32-80cd-d2ceec1547b7", "AQAAAAEAACcQAAAAELoUXvk5PewXe2vg3MRAWOEUj1o493O12kVO0p33IsG/UOQog3xzvRbxH1hjHH4oCg==", "0249da7c-8e5a-41df-bdff-63010304f0f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "870c51c3-c551-4bdf-b5a7-709f3d41706f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3712abd7-9928-4041-8ef7-5ab0b8698c57", "AQAAAAEAACcQAAAAEFEfg6zLlQVr/Ls9oOaCz9N5JvJbWgaM2eyvZOMioa+SLmD3XLnn7xWJH/ip/3qaPQ==", "13262fbc-6156-4bdf-8530-c9d1bdc0e435" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 10, 16, 1, 0, 618, DateTimeKind.Local).AddTicks(7875), new DateTime(2021, 5, 10, 16, 1, 0, 621, DateTimeKind.Local).AddTicks(4549) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 10, 16, 1, 0, 621, DateTimeKind.Local).AddTicks(6262), new DateTime(2021, 5, 10, 16, 1, 0, 621, DateTimeKind.Local).AddTicks(6276) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 10, 16, 1, 0, 623, DateTimeKind.Local).AddTicks(974), new DateTime(2021, 5, 10, 16, 1, 0, 623, DateTimeKind.Local).AddTicks(1003) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 10, 16, 1, 0, 623, DateTimeKind.Local).AddTicks(1912), new DateTime(2021, 5, 10, 16, 1, 0, 623, DateTimeKind.Local).AddTicks(1931) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 10, 16, 1, 0, 623, DateTimeKind.Local).AddTicks(7433), new DateTime(2021, 5, 10, 16, 1, 0, 623, DateTimeKind.Local).AddTicks(7453) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 10, 16, 1, 0, 623, DateTimeKind.Local).AddTicks(8226), new DateTime(2021, 5, 10, 16, 1, 0, 623, DateTimeKind.Local).AddTicks(8238) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 10, 16, 1, 0, 623, DateTimeKind.Local).AddTicks(8242), new DateTime(2021, 5, 10, 16, 1, 0, 623, DateTimeKind.Local).AddTicks(8244) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 10, 16, 1, 0, 623, DateTimeKind.Local).AddTicks(8247), new DateTime(2021, 5, 10, 16, 1, 0, 623, DateTimeKind.Local).AddTicks(8250) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Vehicles");

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
    }
}
