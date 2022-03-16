using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CustomerServiceApp.Server.Migrations
{
    public partial class CreateServices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83fb00d2-7224-4105-a614-b92540d66ed6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9a3036e-e20f-4f44-b4ca-21efab5d8113");

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getDate()"),
                    ConcurrencyStamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "581764ee-d0d4-4a23-a446-daaef2104283", "335b750b-74af-4172-9243-e8c0d162e1ac", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "92b8b4c1-25d0-4df8-b4c0-d0ebfaf3d61e", "7108cf65-8292-49de-807d-ac210093ca3f", "Admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5bf8f6b4-3e44-43f8-bf14-b5b1298f0bd7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6bc65b54-6d74-4f8d-bc46-b81b1b66a5f8", "AQAAAAEAACcQAAAAEJWnud5m5f9ae5p1EJawl3K8elAFM7CyPtjJAD/tlC+ARwQ3lFygIxbEeiKO8j4h+w==", "d842fb5e-41ec-44a7-8e5d-aea0ebf6accc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "581764ee-d0d4-4a23-a446-daaef2104283");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "92b8b4c1-25d0-4df8-b4c0-d0ebfaf3d61e");

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
    }
}
