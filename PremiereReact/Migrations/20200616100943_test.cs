﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PremiereReact.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_Films_FilmId",
                table: "Sessions");

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AlterColumn<int>(
                name: "FilmId",
                table: "Sessions",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_Films_FilmId",
                table: "Sessions",
                column: "FilmId",
                principalTable: "Films",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_Films_FilmId",
                table: "Sessions");

            migrationBuilder.AlterColumn<int>(
                name: "FilmId",
                table: "Sessions",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "FilmId", "StartTime" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 6, 16, 22, 35, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, new DateTime(2020, 6, 16, 19, 20, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, new DateTime(2020, 6, 16, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 2, new DateTime(2020, 6, 17, 19, 20, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 2, new DateTime(2020, 6, 18, 19, 20, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_Films_FilmId",
                table: "Sessions",
                column: "FilmId",
                principalTable: "Films",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
