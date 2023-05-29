using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Letgo.DataAccess.Migrations
{
    public partial class DummyDataAdded2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 25, "Zara markası", "Zara" },
                    { 26, "Ikea markası", "Ikea" },
                    { 27, "H&M Home markası", "H&M Home" },
                    { 28, "Can Yayınları markası", "Can Yayınları" },
                    { 29, "ProForm markası", "ProForm" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "Color", "CreatedDate", "Description", "ImageUrl", "Name", "Price", "StockQuantity", "UserId" },
                values: new object[,]
                {
                    { 1, 23, 1, "White", new DateTime(2023, 5, 29, 19, 2, 13, 584, DateTimeKind.Local).AddTicks(4505), "Sony PlayStation 5 oyun konsolu", "https://ayb.akinoncdn.com/products/2022/03/22/69499/ac28180f-78cf-4519-88a3-f4fc3facd572_size780x780_quality60_cropCenter.jpg", "Sony PlayStation 5", 499.99m, 20, 1 },
                    { 2, 20, 1, "White", new DateTime(2023, 5, 29, 19, 2, 13, 584, DateTimeKind.Local).AddTicks(4508), "Apple MacBook Pro dizüstü bilgisayar", "https://st-troy.mncdn.com/mnresize/1500/1500/Content/media/ProductImg/original/mnej3tua-637909908281168286.jpg", "Apple MacBook Pro", 2999.99m, 30, 1 },
                    { 3, 1, 1, "Black", new DateTime(2023, 5, 29, 19, 2, 13, 584, DateTimeKind.Local).AddTicks(4509), "Samsung Galaxy S21 akıllı telefon", "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/samsung/thumb/131806-1-2_large.jpg", "Samsung Galaxy S21", 1999.99m, 50, 1 },
                    { 4, 4, 2, "Blue", new DateTime(2023, 5, 29, 19, 2, 13, 584, DateTimeKind.Local).AddTicks(4510), "Yüksek bel skinny jean modeli", "https://cdn.qukasoft.com/f/864889/b3NLVUoyVTArYkI4Tmk4Z1RvTTZKYms9/images/urunler/ultra-yuksek-bel-skinny-jean-95293.webp", "Yüksek Bel Skinny Jean", 89.99m, 50, 1 },
                    { 6, 2, 2, "Black", new DateTime(2023, 5, 29, 19, 2, 13, 584, DateTimeKind.Local).AddTicks(4512), "Şık ve dayanıklı deri ceket", "https://static.ticimax.cloud/30422/uploads/urunresimleri/buyuk/erkek-siyah-deri-mont-siyah-d8-4e9.jpg", "Deri Ceket", 249.99m, 25, 1 },
                    { 11, 21, 5, "Blue", new DateTime(2023, 5, 29, 19, 2, 13, 584, DateTimeKind.Local).AddTicks(4519), "Kaliteli ve dayanıklı spor matı", "https://cdn03.ciceksepeti.com/cicek/kcm87519614-1/XL/cift-tarafli-8mm-pilates-minderi-egzersiz-minderi-yoga-mati-pilates-mati-pembe-kcm87519614-1-3bc468bddca7405a8d4b4d595c014983.jpg", "Spor Matı", 49.99m, 20, 1 },
                    { 13, 17, 6, "White", new DateTime(2023, 5, 29, 19, 2, 13, 584, DateTimeKind.Local).AddTicks(4521), "Enerji verimli buzdolabı", "https://www.arcelik.com.tr/medias/7282120192-LO1-20200409-154345.png?context=bWFzdGVyfGltYWdlc3wyMDM0Nzc0fGltYWdlL3BuZ3xoZWQvaGM1LzExMjk5NTM1MTkyMDk0LzcyODIxMjAxOTJfTE8xXzIwMjAwNDA5XzE1NDM0NS5wbmd8YWE0YjNlMzQ4NzBhY2QwYWM1ODYyYjhlZjE5Y2Q4MDQ5N2VhY2M4ZjM4NWUxMWMwNzBiMGI2NTdhYTMxZjVhZA", "Buzdolabı", 2499.99m, 15, 1 },
                    { 14, 18, 6, "White", new DateTime(2023, 5, 29, 19, 2, 13, 584, DateTimeKind.Local).AddTicks(4522), "Yüksek kapasiteli çamaşır makinesi", "https://statics.vestel.com.tr/productimages/20263189_r1_1000_1000.jpg", "Çamaşır Makinesi", 1999.99m, 8, 1 }
                });

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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "Color", "CreatedDate", "Description", "ImageUrl", "Name", "Price", "StockQuantity", "UserId" },
                values: new object[,]
                {
                    { 5, 25, 2, "Green", new DateTime(2023, 5, 29, 19, 2, 13, 584, DateTimeKind.Local).AddTicks(4511), "Yumuşak kadife kumaştan yapılmış şık elbise", "https://productimages.hepsiburada.net/s/146/600-800/110000100343650.jpg", "Kadife Elbise", 129.99m, 40, 1 },
                    { 7, 26, 3, "Blue", new DateTime(2023, 5, 29, 19, 2, 13, 584, DateTimeKind.Local).AddTicks(4514), "Yumuşak ve şık yatak örtüsü", "https://cdn.karaca.com/image/cdndata/1/202109/200.18.01.0593/8680214255261-1.jpg", "Yumuşak Yatak Örtüsü", 79.99m, 35, 1 },
                    { 8, 27, 3, "White", new DateTime(2023, 5, 29, 19, 2, 13, 584, DateTimeKind.Local).AddTicks(4515), "El yapımı makrome duvar asması", "https://www.solady.com.tr/images/59591-1/Hayat-a%C4%9Fac%C4%B1-makrome-duvar-as%C4%B1l%C4%B1-boho-ev-dekor-bohemian.jpeg", "Makrome Duvar Asması", 59.99m, 30, 1 },
                    { 9, 28, 4, "White", new DateTime(2023, 5, 29, 19, 2, 13, 584, DateTimeKind.Local).AddTicks(4516), "Grigory Petrov'un ünlü eseri", "https://i.dr.com.tr/cache/600x600-0/originals/0001784820001-1.jpg", "Beyaz Zambaklar Ülkesinde", 29.99m, 50, 1 },
                    { 10, 28, 4, "Black", new DateTime(2023, 5, 29, 19, 2, 13, 584, DateTimeKind.Local).AddTicks(4518), "Yuval Noah Harari'nin çok satan eseri", "https://i0.wp.com/www.okudumizledimgezdim.com/wp-content/uploads/2020/09/IMG_0635.jpg?resize=1080%2C1440", "Sapiens: İnsan Türünün Kısa Bir Tarihi", 39.99m, 40, 1 },
                    { 12, 29, 5, "Black", new DateTime(2023, 5, 29, 19, 2, 13, 584, DateTimeKind.Local).AddTicks(4520), "Profesyonel koşu bandı", "https://productimages.hepsiburada.net/s/43/1500/10757124423730.jpg", "Koşu Bandı", 1999.99m, 10, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2023, 5, 29, 18, 38, 55, 852, DateTimeKind.Local).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2023, 5, 29, 18, 38, 55, 852, DateTimeKind.Local).AddTicks(528));
        }
    }
}
