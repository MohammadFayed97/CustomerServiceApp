using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CustomerServiceApp.Server.Migrations
{
    public partial class CreateCustomers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "581764ee-d0d4-4a23-a446-daaef2104283");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "92b8b4c1-25d0-4df8-b4c0-d0ebfaf3d61e");

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getDate()"),
                    ConcurrencyStamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customer_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e06d20f8-68f2-4edf-b25e-6db37f216ac3", "c9a69e3c-b3fc-4104-b91a-3c46f98c1dd5", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f10309ea-8fb8-4cbd-b328-a8fba5d142c1", "73064d35-81cf-4858-ae3c-79f99e0a32e5", "Admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5bf8f6b4-3e44-43f8-bf14-b5b1298f0bd7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78f9762b-e55f-458e-83de-a7b21b510ccb", "AQAAAAEAACcQAAAAENlBiXFT2lM75WBhD11yAvsUHusz8E0mZ1d8k/Chl4dPFXAB4QhEWYY5p1UTuQe/fw==", "b8c52549-e2aa-4c5a-b641-7b8a2cbdca3e" });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_CityId",
                table: "Customer",
                column: "CityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e06d20f8-68f2-4edf-b25e-6db37f216ac3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f10309ea-8fb8-4cbd-b328-a8fba5d142c1");

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
    }
}
