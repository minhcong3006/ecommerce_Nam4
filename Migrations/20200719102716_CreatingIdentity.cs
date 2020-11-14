using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab2.Migrations
{
    public partial class CreatingIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9915e822-25db-4d22-b137-4ac57ec01947");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a31a53dd-2ebb-48e9-8fe2-905e19377cca");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "efd3cbe5-4829-4cf9-bdcf-11914382030a", "f47773d8-71c3-486f-af8e-58566a76fdd8", "Visitor", "VISITOR" },
                    { "b12331b2-6200-4335-ad9b-a0b93aa2632a", "966c2831-85f9-4f3e-be95-472700868fd4", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2020, 7, 19, 17, 27, 15, 902, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2020, 7, 19, 17, 27, 15, 902, DateTimeKind.Local).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2020, 7, 19, 17, 27, 15, 902, DateTimeKind.Local).AddTicks(9574));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2020, 7, 19, 17, 27, 15, 902, DateTimeKind.Local).AddTicks(9576));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2020, 7, 19, 17, 27, 15, 902, DateTimeKind.Local).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2020, 7, 19, 17, 27, 15, 902, DateTimeKind.Local).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2020, 7, 19, 17, 27, 15, 902, DateTimeKind.Local).AddTicks(9581));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2020, 7, 19, 17, 27, 15, 902, DateTimeKind.Local).AddTicks(9582));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b12331b2-6200-4335-ad9b-a0b93aa2632a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "efd3cbe5-4829-4cf9-bdcf-11914382030a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a31a53dd-2ebb-48e9-8fe2-905e19377cca", "a9028fac-5cca-497e-80fb-f3e607c6e375", "Visitor", "VISITOR" },
                    { "9915e822-25db-4d22-b137-4ac57ec01947", "b6fd0648-0e0c-4150-bf43-ff2987e04d7a", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2020, 7, 19, 17, 26, 47, 500, DateTimeKind.Local).AddTicks(1922));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2020, 7, 19, 17, 26, 47, 501, DateTimeKind.Local).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2020, 7, 19, 17, 26, 47, 501, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2020, 7, 19, 17, 26, 47, 501, DateTimeKind.Local).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2020, 7, 19, 17, 26, 47, 501, DateTimeKind.Local).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2020, 7, 19, 17, 26, 47, 501, DateTimeKind.Local).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2020, 7, 19, 17, 26, 47, 501, DateTimeKind.Local).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2020, 7, 19, 17, 26, 47, 501, DateTimeKind.Local).AddTicks(4238));
        }
    }
}
