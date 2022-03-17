using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CustomerServiceApp.Server.Migrations
{
    public partial class AddRefreshToken : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bcc030e6-683d-451b-8e1f-da7febb801aa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5c68697-7505-46bc-8600-77eaf32e028b");

            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "31352acf-d303-4a60-aadc-a111716a1153", "67133709-0fe8-421c-99da-bbd9f1728858", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "823ab1a7-ec0c-4ceb-85ab-5872770b93a0", "30a9e973-f82a-456e-85bb-a63737d57fe2", "User", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5bf8f6b4-3e44-43f8-bf14-b5b1298f0bd7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c71cc5ba-7687-4789-bc7f-6405fdb001cb", "AQAAAAEAACcQAAAAEOK2q5RWSVPhSXJ2teVBxVMmf3xMP/L2771zjIU06HbTMsN3VS3HIOfGRhNRkEtP2A==", "07719a77-c740-463b-9324-7681e5f38e0e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31352acf-d303-4a60-aadc-a111716a1153");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "823ab1a7-ec0c-4ceb-85ab-5872770b93a0");

            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers");

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
    }
}
