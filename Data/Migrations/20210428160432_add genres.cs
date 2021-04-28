using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Songs_Manager.Data.Migrations
{
    public partial class addgenres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artist_Genre",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtistId = table.Column<int>(nullable: false),
                    GenreId = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastUpdatedAt = table.Column<DateTime>(nullable: false),
                    LastUpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artist_Genre", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Artist_Genre_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "ArtistId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Artist_Genre_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Song_Genre",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SongId = table.Column<int>(nullable: false),
                    GenreId = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastUpdatedAt = table.Column<DateTime>(nullable: false),
                    LastUpdatedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Song_Genre", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Song_Genre_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Song_Genre_Songs_SongId",
                        column: x => x.SongId,
                        principalTable: "Songs",
                        principalColumn: "SongId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Artist_Genre",
                columns: new[] { "Id", "ArtistId", "CreatedAt", "CreatedBy", "GenreId", "LastUpdatedAt", "LastUpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 1, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null },
                    { 11, 6, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 6, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null },
                    { 10, 6, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 5, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null },
                    { 9, 5, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 6, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null },
                    { 8, 5, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 5, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null },
                    { 7, 4, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 6, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null },
                    { 12, 7, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 9, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null },
                    { 5, 3, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 3, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null },
                    { 4, 3, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 2, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null },
                    { 3, 2, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 2, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null },
                    { 2, 1, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 2, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null },
                    { 6, 4, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 5, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null }
                });

            migrationBuilder.InsertData(
                table: "Song_Genre",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "GenreId", "LastUpdatedAt", "LastUpdatedBy", "SongId" },
                values: new object[,]
                {
                    { 16, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 3, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 9 },
                    { 17, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 5, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 10 },
                    { 18, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 6, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 10 },
                    { 19, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 5, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 11 },
                    { 20, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 6, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 11 },
                    { 22, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 6, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 12 },
                    { 23, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 5, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 13 },
                    { 24, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 6, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 13 },
                    { 25, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 6, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 14 },
                    { 15, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 2, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 9 },
                    { 21, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 5, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 12 },
                    { 14, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 7, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 8 },
                    { 8, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 4, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 5 },
                    { 12, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 4, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 7 },
                    { 11, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 2, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 7 },
                    { 10, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 4, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 6 },
                    { 9, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 1, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 6 },
                    { 26, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 7, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 15 },
                    { 7, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 2, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 5 },
                    { 6, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 8, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 4 },
                    { 5, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 6, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 4 },
                    { 4, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 9, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 3 },
                    { 3, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 6, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 2 },
                    { 2, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 6, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 1 },
                    { 1, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 1, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 1 },
                    { 13, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 6, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 8 },
                    { 27, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 7, new DateTime(2021, 4, 28, 18, 4, 31, 401, DateTimeKind.Local).AddTicks(4214), null, 16 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artist_Genre_ArtistId",
                table: "Artist_Genre",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Artist_Genre_GenreId",
                table: "Artist_Genre",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Song_Genre_GenreId",
                table: "Song_Genre",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Song_Genre_SongId",
                table: "Song_Genre",
                column: "SongId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artist_Genre");

            migrationBuilder.DropTable(
                name: "Song_Genre");
        }
    }
}
