using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Songs_Manager.Data.Migrations
{
    public partial class upatuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253), new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253), new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253), new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253), new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253), new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253), new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253), new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253), new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253), new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253), new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253), new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253), new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253), new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253), new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253), new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253), new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253), new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253), new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253), new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253), new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253), new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253), new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253), new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253), new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253), new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253), new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253), new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253), new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253), new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253), new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253), new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253), new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253), new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253), new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253), new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253), new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253), new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253), new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253), new DateTime(2021, 6, 1, 19, 12, 36, 996, DateTimeKind.Local).AddTicks(253) });
        }
    }
}
