using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Songs_Manager.Data.Migrations
{
    public partial class updatuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915), new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915), new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915), new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915), new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915), new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915), new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915), new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915), new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915), new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915), new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915), new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915), new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915), new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915), new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915), new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915), new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915), new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915), new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915), new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915), new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915), new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915), new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915), new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915), new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915), new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915), new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915), new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915), new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915), new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915), new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915), new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915), new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915), new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915), new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915), new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915), new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915), new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915), new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915), new DateTime(2021, 6, 1, 19, 28, 58, 235, DateTimeKind.Local).AddTicks(8915) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752), new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752), new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752), new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752), new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752), new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752), new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752), new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752), new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752), new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752), new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752), new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752), new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752), new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752), new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752), new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752), new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752), new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752), new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752), new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752), new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752), new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752), new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752), new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752), new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752), new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752), new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752), new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752), new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752), new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752), new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752), new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752), new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752), new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752), new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752), new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752), new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752), new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752), new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752), new DateTime(2021, 6, 1, 19, 17, 15, 773, DateTimeKind.Local).AddTicks(7752) });
        }
    }
}
