using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Letgo.DataAccess.Migrations
{
    public partial class DummyDataAdded4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 20, 7, 35, 541, DateTimeKind.Local).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 20, 7, 35, 541, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 20, 7, 35, 541, DateTimeKind.Local).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 20, 7, 35, 541, DateTimeKind.Local).AddTicks(8054));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 20, 7, 35, 541, DateTimeKind.Local).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 20, 7, 35, 541, DateTimeKind.Local).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 20, 7, 35, 541, DateTimeKind.Local).AddTicks(8058));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 20, 7, 35, 541, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 20, 7, 35, 541, DateTimeKind.Local).AddTicks(8061));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 20, 7, 35, 541, DateTimeKind.Local).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 20, 7, 35, 541, DateTimeKind.Local).AddTicks(8064));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 20, 7, 35, 541, DateTimeKind.Local).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 20, 7, 35, 541, DateTimeKind.Local).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 20, 7, 35, 541, DateTimeKind.Local).AddTicks(8068));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 20, 7, 35, 541, DateTimeKind.Local).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 20, 7, 35, 541, DateTimeKind.Local).AddTicks(8071));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 20, 7, 35, 541, DateTimeKind.Local).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 20, 7, 35, 541, DateTimeKind.Local).AddTicks(8073));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 20, 7, 35, 541, DateTimeKind.Local).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 20, 7, 35, 541, DateTimeKind.Local).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 20, 7, 35, 541, DateTimeKind.Local).AddTicks(8078));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 20, 7, 35, 541, DateTimeKind.Local).AddTicks(8079));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "Color", "CreatedDate", "Description", "ImageUrl", "Name", "Price", "StockQuantity", "UserId" },
                values: new object[,]
                {
                    { 24, 17, 6, "Blue", new DateTime(2023, 5, 29, 20, 7, 35, 541, DateTimeKind.Local).AddTicks(8081), "Arçelik Fırın özel üretim", "https://cdn.cimri.io/image/1200x1200/arelikminimidifrnlarfiyatlar_419046742.jpg", "Arçelik Fırın", 149.99m, 8, 1 },
                    { 25, 19, 6, "Blue", new DateTime(2023, 5, 29, 20, 7, 35, 541, DateTimeKind.Local).AddTicks(8082), "Dyson süpürge özel üretim", "https://dyson-h.assetsadobe2.com/is/image/content/dam/dyson/leap-petite-global/markets/turkey/fc/V10.jpg?$responsive$&cropPathE=desktop&fit=stretch,1&wid=1920", "Dyson süpürge", 149.99m, 8, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2023, 5, 29, 20, 7, 35, 541, DateTimeKind.Local).AddTicks(7947));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2023, 5, 29, 20, 7, 35, 541, DateTimeKind.Local).AddTicks(7959));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 20, 3, 57, 501, DateTimeKind.Local).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 20, 3, 57, 501, DateTimeKind.Local).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 20, 3, 57, 501, DateTimeKind.Local).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 20, 3, 57, 501, DateTimeKind.Local).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 20, 3, 57, 501, DateTimeKind.Local).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 20, 3, 57, 501, DateTimeKind.Local).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 20, 3, 57, 501, DateTimeKind.Local).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 20, 3, 57, 501, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 20, 3, 57, 501, DateTimeKind.Local).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 20, 3, 57, 501, DateTimeKind.Local).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 20, 3, 57, 501, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 20, 3, 57, 501, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 20, 3, 57, 501, DateTimeKind.Local).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 20, 3, 57, 501, DateTimeKind.Local).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 20, 3, 57, 501, DateTimeKind.Local).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 20, 3, 57, 501, DateTimeKind.Local).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 20, 3, 57, 501, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 20, 3, 57, 501, DateTimeKind.Local).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 20, 3, 57, 501, DateTimeKind.Local).AddTicks(6694));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 20, 3, 57, 501, DateTimeKind.Local).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 20, 3, 57, 501, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 20, 3, 57, 501, DateTimeKind.Local).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2023, 5, 29, 20, 3, 57, 501, DateTimeKind.Local).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2023, 5, 29, 20, 3, 57, 501, DateTimeKind.Local).AddTicks(6612));
        }
    }
}
