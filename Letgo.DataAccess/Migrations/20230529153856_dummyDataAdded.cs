using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Letgo.DataAccess.Migrations
{
    public partial class dummyDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Samsung markası", "Samsung" },
                    { 2, "Mavi markası", "Mavi" },
                    { 3, "JACK & JONES markası", "JACK & JONES" },
                    { 4, "LTB markası", "LTB" },
                    { 5, "Vivense markası", "Vivense" },
                    { 6, "Madamecoco markası", "Madamecoco" },
                    { 7, "Koctaş markası", "Koctaş" },
                    { 8, "English Home markası", "English Home" },
                    { 9, "Kitapyurdu markası", "Kitapyurdu" },
                    { 10, "D&R markası", "D&R" },
                    { 11, "Idefix markası", "Idefix" },
                    { 12, "Morhipo markası", "Morhipo" },
                    { 13, "Decathlon markası", "Decathlon" },
                    { 14, "Koray Spor markası", "Koray Spor" },
                    { 15, "Fenerbahçe markası", "Fenerbahçe" },
                    { 16, "Flo markası", "Flo" },
                    { 17, "Arçelik markası", "Arçelik" },
                    { 18, "Vestel markası", "Vestel" },
                    { 19, "Dyson markası", "Dyson" },
                    { 20, "Apple markası", "Apple" },
                    { 21, "Nike markası", "Nike" },
                    { 22, "Adidas markası", "Adidas" },
                    { 23, "Sony markası", "Sony" },
                    { 24, "LG markası", "LG" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "Elektronik ürünler", "Elektronik", "elektronik" },
                    { 2, "Giyim ve moda ürünleri", "Giyim ve Moda", "giyim-ve-moda" },
                    { 3, "Ev ve dekorasyon ürünleri", "Ev ve Dekorasyon", "ev-ve-dekorasyon" },
                    { 4, "Kitaplar", "Kitaplar", "kitaplar" },
                    { 5, "Spor ve fitness ürünleri", "Spor ve Fitness", "spor-ve-fitness" },
                    { 6, "Beyaz eşya ürünleri", "Beyaz Eşya", "beyaz-esya" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "admin", "admin" },
                    { 2, "user", "user" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "City", "DateOfBirth", "Email", "FirstName", "FullName", "Gender", "LastName", "Password", "ProfilePhoto", "RoleId", "isLogin" },
                values: new object[] { 1, "test adress admin", "Çankırı", new DateTime(2023, 5, 29, 18, 38, 55, 852, DateTimeKind.Local).AddTicks(510), "admin@gmail.com", "admin", "admin admin", "Erkek", "admin", "123456", "https://cdn1.vectorstock.com/i/1000x1000/51/95/businessman-avatar-cartoon-character-profile-vector-25645195.jpg", 1, false });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "City", "DateOfBirth", "Email", "FirstName", "FullName", "Gender", "LastName", "Password", "ProfilePhoto", "RoleId", "isLogin" },
                values: new object[] { 2, "test adress user", "Çankırı", new DateTime(2023, 5, 29, 18, 38, 55, 852, DateTimeKind.Local).AddTicks(528), "user@gmail.com", "user", "user user", "Kadın", "user", "123456", "https://w0.peakpx.com/wallpaper/979/89/HD-wallpaper-purple-smile-design-eye-smily-profile-pic-face-thumbnail.jpg", 1, false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
