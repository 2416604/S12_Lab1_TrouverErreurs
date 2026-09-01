using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mission.Migrations
{
    /// <inheritdoc />
    public partial class Seed_ProduitETCategorie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Titre" },
                values: new object[,]
                {
                    { 1, "Vélos" },
                    { 2, "Composantes" },
                    { 3, "Vêtements" },
                    { 4, "Accessoires" }
                });

            migrationBuilder.InsertData(
                table: "Produits",
                columns: new[] { "Id", "CategorieId", "DateCreation", "Description", "PrixVente" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(4834), "Long-Sleeve Logo Jersey, S", 38m },
                    { 2, 3, new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(4853), "Long-Sleeve Logo Jersey, M", 38m },
                    { 3, 1, new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(4867), "HL Road Frame - Red, 62", 868m },
                    { 4, 1, new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(4881), "HL Road Frame - Red, 44", 870m },
                    { 5, 1, new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(4895), "LL Road Frame - Red, 44", 870m },
                    { 6, 1, new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(4914), "Road-150 Red, 62", 2171m },
                    { 7, 1, new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(4928), "Road-150 Red, 44", 2171m },
                    { 8, 4, new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(4942), "LL Headset", 16m },
                    { 9, 2, new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(4956), "LL Mountain Handlebars", 19m },
                    { 10, 2, new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(4992), "LL Mountain Front Wheel", 27m },
                    { 11, 3, new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(5006), "Classic Vest, M", 24m },
                    { 12, 4, new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(5019), "ML Road Seat/Saddle", 50m },
                    { 13, 1, new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(5033), "Mountain-500 Silver, 40", 308m },
                    { 14, 1, new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(5047), "Mountain-500 Silver, 42", 308m },
                    { 15, 4, new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(5060), "LL Bottom Bracket", 22m },
                    { 16, 4, new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(5074), "ML Bottom Bracket", 22m },
                    { 17, 2, new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(5087), "Rear Brakes", 47m },
                    { 18, 3, new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(5102), "Racing Socks, M", 4m },
                    { 19, 3, new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(5116), "Racing Socks, L", 4m },
                    { 20, 4, new DateTime(2024, 10, 10, 17, 33, 54, 570, DateTimeKind.Local).AddTicks(5130), "Hydration Pack - 70 oz.", 21m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 20);

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
        }
    }
}
