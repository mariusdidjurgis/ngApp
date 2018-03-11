using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ngApp.Web.Migrations
{
    public partial class makeDateAndHeadquaters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "makes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "HeadQuatersLocation",
                table: "makes",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "features",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "makes");

            migrationBuilder.DropColumn(
                name: "HeadQuatersLocation",
                table: "makes");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "features",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255);
        }
    }
}
