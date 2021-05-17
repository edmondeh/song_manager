using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Songs_Manager.Data.Migrations
{
    public partial class update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artist_Genre_Artists_ArtistId",
                table: "Artist_Genre");

            migrationBuilder.DropForeignKey(
                name: "FK_Artist_Genre_Genre_GenreId",
                table: "Artist_Genre");

            migrationBuilder.DropForeignKey(
                name: "FK_Song_Genre_Genre_GenreId",
                table: "Song_Genre");

            migrationBuilder.DropForeignKey(
                name: "FK_Song_Genre_Songs_SongId",
                table: "Song_Genre");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Song_Genre",
                table: "Song_Genre");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genre",
                table: "Genre");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Artist_Genre",
                table: "Artist_Genre");

            migrationBuilder.RenameTable(
                name: "Song_Genre",
                newName: "Song_Genres");

            migrationBuilder.RenameTable(
                name: "Genre",
                newName: "Genres");

            migrationBuilder.RenameTable(
                name: "Artist_Genre",
                newName: "Artist_Genres");

            migrationBuilder.RenameIndex(
                name: "IX_Song_Genre_SongId",
                table: "Song_Genres",
                newName: "IX_Song_Genres_SongId");

            migrationBuilder.RenameIndex(
                name: "IX_Song_Genre_GenreId",
                table: "Song_Genres",
                newName: "IX_Song_Genres_GenreId");

            migrationBuilder.RenameIndex(
                name: "IX_Artist_Genre_GenreId",
                table: "Artist_Genres",
                newName: "IX_Artist_Genres_GenreId");

            migrationBuilder.RenameIndex(
                name: "IX_Artist_Genre_ArtistId",
                table: "Artist_Genres",
                newName: "IX_Artist_Genres_ArtistId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Song_Genres",
                table: "Song_Genres",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genres",
                table: "Genres",
                column: "GenreId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Artist_Genres",
                table: "Artist_Genres",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697), new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697), new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697), new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697), new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697), new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697), new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697), new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697), new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697), new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697), new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697), new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Artist_Genres",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697), new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697), new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697), new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697), new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697), new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697), new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697), new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697), new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697), new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697), new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697), new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697), new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697), new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697), new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697), new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697), new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697), new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697), new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697), new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697), new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697), new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697), new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697), new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697), new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697), new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697), new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697), new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Song_Genres",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697), new DateTime(2021, 5, 8, 19, 47, 26, 723, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.AddForeignKey(
                name: "FK_Artist_Genres_Artists_ArtistId",
                table: "Artist_Genres",
                column: "ArtistId",
                principalTable: "Artists",
                principalColumn: "ArtistId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Artist_Genres_Genres_GenreId",
                table: "Artist_Genres",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Song_Genres_Genres_GenreId",
                table: "Song_Genres",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Song_Genres_Songs_SongId",
                table: "Song_Genres",
                column: "SongId",
                principalTable: "Songs",
                principalColumn: "SongId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artist_Genres_Artists_ArtistId",
                table: "Artist_Genres");

            migrationBuilder.DropForeignKey(
                name: "FK_Artist_Genres_Genres_GenreId",
                table: "Artist_Genres");

            migrationBuilder.DropForeignKey(
                name: "FK_Song_Genres_Genres_GenreId",
                table: "Song_Genres");

            migrationBuilder.DropForeignKey(
                name: "FK_Song_Genres_Songs_SongId",
                table: "Song_Genres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Song_Genres",
                table: "Song_Genres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genres",
                table: "Genres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Artist_Genres",
                table: "Artist_Genres");

            migrationBuilder.RenameTable(
                name: "Song_Genres",
                newName: "Song_Genre");

            migrationBuilder.RenameTable(
                name: "Genres",
                newName: "Genre");

            migrationBuilder.RenameTable(
                name: "Artist_Genres",
                newName: "Artist_Genre");

            migrationBuilder.RenameIndex(
                name: "IX_Song_Genres_SongId",
                table: "Song_Genre",
                newName: "IX_Song_Genre_SongId");

            migrationBuilder.RenameIndex(
                name: "IX_Song_Genres_GenreId",
                table: "Song_Genre",
                newName: "IX_Song_Genre_GenreId");

            migrationBuilder.RenameIndex(
                name: "IX_Artist_Genres_GenreId",
                table: "Artist_Genre",
                newName: "IX_Artist_Genre_GenreId");

            migrationBuilder.RenameIndex(
                name: "IX_Artist_Genres_ArtistId",
                table: "Artist_Genre",
                newName: "IX_Artist_Genre_ArtistId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Song_Genre",
                table: "Song_Genre",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genre",
                table: "Genre",
                column: "GenreId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Artist_Genre",
                table: "Artist_Genre",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Artist_Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597), new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Artist_Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597), new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Artist_Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597), new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Artist_Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597), new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Artist_Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597), new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Artist_Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597), new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Artist_Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597), new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Artist_Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597), new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Artist_Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597), new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Artist_Genre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597), new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Artist_Genre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597), new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Artist_Genre",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597), new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Song_Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597), new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Song_Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597), new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Song_Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597), new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Song_Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597), new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Song_Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597), new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Song_Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597), new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Song_Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597), new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Song_Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597), new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Song_Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597), new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Song_Genre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597), new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Song_Genre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597), new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Song_Genre",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597), new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Song_Genre",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597), new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Song_Genre",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597), new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Song_Genre",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597), new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Song_Genre",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597), new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Song_Genre",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597), new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Song_Genre",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597), new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Song_Genre",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597), new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Song_Genre",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597), new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Song_Genre",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597), new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Song_Genre",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597), new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Song_Genre",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597), new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Song_Genre",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597), new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Song_Genre",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597), new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Song_Genre",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597), new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Song_Genre",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597), new DateTime(2021, 5, 8, 18, 30, 54, 606, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.AddForeignKey(
                name: "FK_Artist_Genre_Artists_ArtistId",
                table: "Artist_Genre",
                column: "ArtistId",
                principalTable: "Artists",
                principalColumn: "ArtistId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Artist_Genre_Genre_GenreId",
                table: "Artist_Genre",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Song_Genre_Genre_GenreId",
                table: "Song_Genre",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Song_Genre_Songs_SongId",
                table: "Song_Genre",
                column: "SongId",
                principalTable: "Songs",
                principalColumn: "SongId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
