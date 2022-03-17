using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CustomerServiceApp.Server.Migrations
{
    public partial class SuppertDisplayOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0377715d-0175-48b8-bf6d-492b42b317c7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "254e0abb-346b-498e-8570-f0ea529aa59c");

            migrationBuilder.AddColumn<int>(
                name: "DisplayOrder",
                table: "Service",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DisplayOrder",
                table: "CustomerRequest",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DisplayOrder",
                table: "Customer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DisplayOrder",
                table: "City",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bcc030e6-683d-451b-8e1f-da7febb801aa", "42266a9c-b8b5-4c23-9509-a89095fdec77", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c5c68697-7505-46bc-8600-77eaf32e028b", "1a0a4599-add2-4dcf-a730-7b29a54bf0f3", "User", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5bf8f6b4-3e44-43f8-bf14-b5b1298f0bd7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "002c2039-9bf0-4301-9651-0cd534d9b358", "AQAAAAEAACcQAAAAEIUYJ2sBqV5heX9lCKwJV3wzMCuVNYGTqNidn1wLyBLYomm6LCOLVKwZOOqBR8c4Dw==", "69357535-edc1-437f-a40a-4ccdb9e7f782" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bcc030e6-683d-451b-8e1f-da7febb801aa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5c68697-7505-46bc-8600-77eaf32e028b");

            migrationBuilder.DropColumn(
                name: "DisplayOrder",
                table: "Service");

            migrationBuilder.DropColumn(
                name: "DisplayOrder",
                table: "CustomerRequest");

            migrationBuilder.DropColumn(
                name: "DisplayOrder",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "DisplayOrder",
                table: "City");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0377715d-0175-48b8-bf6d-492b42b317c7", "69189409-456d-4451-85cd-add4e5c82d52", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "254e0abb-346b-498e-8570-f0ea529aa59c", "d8e3f08d-7395-4fd2-8168-d6c452f471b1", "User", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5bf8f6b4-3e44-43f8-bf14-b5b1298f0bd7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3f405bb-1a70-49da-a837-807e9ec7b829", "AQAAAAEAACcQAAAAEJ1kdZl6oo15V0tsQHGHK6xEB6J3GSfale/x9kGZ+tZTTYOFBi+7XhXDAR1e3fwXVw==", "d4a983fc-bdc8-4476-bd20-fc5511a7e851" });
        }
    }
}
