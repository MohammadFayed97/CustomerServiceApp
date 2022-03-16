using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CustomerServiceApp.Server.Migrations
{
    public partial class CreateCity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c78db4aa-d217-44ea-9af7-b2886e372309");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cef82d61-b380-4036-9b71-8e3b233b3ec2");

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getDate()"),
                    ConcurrencyStamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "83fb00d2-7224-4105-a614-b92540d66ed6", "f1fd9d76-1521-49fe-82ce-a5074610d352", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c9a3036e-e20f-4f44-b4ca-21efab5d8113", "62fee9a8-1f66-4378-9e5e-7c81a8a43405", "User", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5bf8f6b4-3e44-43f8-bf14-b5b1298f0bd7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0ae3ca3-9068-4eb0-aba2-6c491166577a", "AQAAAAEAACcQAAAAEPsx0T1I2DrEUaNKYiNvGZFDpBkAGML2MLNKORTFVQyvqbGeLsSDuAIXqNul5rVX4g==", "7bcaad2a-b560-431b-b479-6a6f463db86a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83fb00d2-7224-4105-a614-b92540d66ed6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9a3036e-e20f-4f44-b4ca-21efab5d8113");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c78db4aa-d217-44ea-9af7-b2886e372309", "e2bccb7a-7925-47e6-b8eb-70c4ca9a1e9b", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cef82d61-b380-4036-9b71-8e3b233b3ec2", "a22e434f-b36a-4100-88a4-17b8d6367e58", "Admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5bf8f6b4-3e44-43f8-bf14-b5b1298f0bd7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41412fab-c9b0-4b89-a855-7096c2dda875", "AQAAAAEAACcQAAAAEKjVKQhqlNbD2vceF1aEXY3TKPqvjDIOgo32V01xALQq4625AWQShCQSzNbcyNcSPw==", "aa049020-b91e-4372-bd48-2091a6163bf2" });
        }
    }
}
