using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Letgo.DataAccess.Migrations
{
    public partial class DummyDataAddede : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "Color", "CreatedDate", "Description", "ImageUrl", "Name", "Price", "StockQuantity", "UserId" },
                values: new object[,]
                {
                    { 16, 20, 1, "Black", new DateTime(2023, 5, 29, 20, 3, 57, 501, DateTimeKind.Local).AddTicks(6688), "Yeni nesil akıllı telefon", "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/samsung/thumb/135498-1_large.jpg", "Akıllı Telefon", 2999.99m, 10, 1 },
                    { 17, 25, 2, "Red", new DateTime(2023, 5, 29, 20, 3, 57, 501, DateTimeKind.Local).AddTicks(6690), "Şık ve modern kadın ceketi", "https://cdn.sorsware.com/oxxo/ContentImages/Product/23y/23YOX-POLDUZCEK1/klasik-blazer-ceket_sulphur-sari_1_detay.jpg", "Kadın Ceketi", 149.99m, 20, 1 },
                    { 18, 27, 3, "White", new DateTime(2023, 5, 29, 20, 3, 57, 501, DateTimeKind.Local).AddTicks(6691), "Şık ve rahat yatak odası takımı", "https://www.berkemobilya.com.tr/media/catalog/product/cache/1/image/2000x1120/8cda07290adf5b61edee0d4066c5caef/_/y/_yatak.jpg", "Yatak Odası Takımı", 2999.99m, 5, 1 },
                    { 19, 27, 3, "Green", new DateTime(2023, 5, 29, 20, 3, 57, 501, DateTimeKind.Local).AddTicks(6692), "Renkli ve desenli dekoratif yastık", "https://m.media-amazon.com/images/I/81P8HGmxw7L._AC_UF1000,1000_QL80_.jpg", "Dekoratif Yastık", 49.99m, 12, 1 },
                    { 20, 28, 4, "White", new DateTime(2023, 5, 29, 20, 3, 57, 501, DateTimeKind.Local).AddTicks(6694), "Heyecan dolu bilim kurgu romanı", "https://img-s1.onedio.com/id-553e1d9380b8f1f91ff0ee0b/rev-0/w-600/h-600/f-jpg/s-a04463fda12368eb6adbb3a9001fc6d3fce31517.jpg", "Bilim Kurgu Romanı", 29.99m, 4, 1 },
                    { 21, 28, 4, "White", new DateTime(2023, 5, 29, 20, 3, 57, 501, DateTimeKind.Local).AddTicks(6695), "Heyecan dolu bilim kurgu romanı", "https://cdn.bkmkitap.com/Data/EditorFiles/Blog/blog-urunler/marsli-andy-weir.jpg", "Bilim Kurgu Romanı 2", 29.99m, 4, 1 },
                    { 22, 22, 5, "Blue", new DateTime(2023, 5, 29, 20, 3, 57, 501, DateTimeKind.Local).AddTicks(6696), "Konforlu ve şık spor ayakkabı", "https://akn-ss.b-cdn.net/products/2022/01/28/340690/5f2e615e-3ed0-47eb-a7b8-7022d59dc0d3_size1400x1400_quality100.jpg", "Spor Ayakkabı", 149.99m, 8, 1 },
                    { 23, 22, 5, "Blue", new DateTime(2023, 5, 29, 20, 3, 57, 501, DateTimeKind.Local).AddTicks(6697), "Konforlu ve şık spor ayakkabı", "https://akn-ss.b-cdn.net/products/2023/01/30/747531/0ce73cac-6f98-4056-b846-4f7d8cada4e7_size1400x1400_quality100.jpg", "Spor Ayakkabı 2", 149.99m, 8, 1 }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "TagName" },
                values: new object[,]
                {
                    { 1, "Kadın" },
                    { 2, "Erkek" },
                    { 3, "Anne" },
                    { 4, "Çocuk" },
                    { 5, "Ev & Mobilya" },
                    { 6, "Ayakkabı & Çanta" },
                    { 7, "Elektronik" },
                    { 8, "Spor & Outdoor" },
                    { 9, "Çok Satanlar" }
                });

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

            migrationBuilder.InsertData(
                table: "ProductTags",
                columns: new[] { "ProductId", "TagId" },
                values: new object[,]
                {
                    { 1, 7 },
                    { 2, 7 },
                    { 3, 7 },
                    { 4, 2 },
                    { 5, 1 },
                    { 6, 8 },
                    { 7, 5 },
                    { 8, 5 },
                    { 9, 9 },
                    { 10, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 6, 8 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 9, 9 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 19, 2, 13, 584, DateTimeKind.Local).AddTicks(4505));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 19, 2, 13, 584, DateTimeKind.Local).AddTicks(4508));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 19, 2, 13, 584, DateTimeKind.Local).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 19, 2, 13, 584, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 19, 2, 13, 584, DateTimeKind.Local).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 19, 2, 13, 584, DateTimeKind.Local).AddTicks(4512));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 19, 2, 13, 584, DateTimeKind.Local).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 19, 2, 13, 584, DateTimeKind.Local).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 19, 2, 13, 584, DateTimeKind.Local).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 19, 2, 13, 584, DateTimeKind.Local).AddTicks(4518));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 19, 2, 13, 584, DateTimeKind.Local).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 19, 2, 13, 584, DateTimeKind.Local).AddTicks(4520));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 19, 2, 13, 584, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 5, 29, 19, 2, 13, 584, DateTimeKind.Local).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2023, 5, 29, 19, 2, 13, 584, DateTimeKind.Local).AddTicks(4407));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2023, 5, 29, 19, 2, 13, 584, DateTimeKind.Local).AddTicks(4420));
        }
    }
}
