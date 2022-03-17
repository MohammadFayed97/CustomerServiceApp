using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CustomerServiceApp.Server.Migrations
{
    public partial class CreateCustomerRequests : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e06d20f8-68f2-4edf-b25e-6db37f216ac3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f10309ea-8fb8-4cbd-b328-a8fba5d142c1");

            migrationBuilder.CreateTable(
                name: "CustomerRequest",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getDate()"),
                    ConcurrencyStamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerRequest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerRequest_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomerRequest_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_CustomerRequest_CustomerId",
                table: "CustomerRequest",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerRequest_ServiceId",
                table: "CustomerRequest",
                column: "ServiceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerRequest");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0377715d-0175-48b8-bf6d-492b42b317c7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "254e0abb-346b-498e-8570-f0ea529aa59c");

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
        }
    }
}
