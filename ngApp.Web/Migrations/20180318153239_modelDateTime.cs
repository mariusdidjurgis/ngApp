using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ngApp.Web.Migrations
{
    public partial class modelDateTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "models");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "models",
                nullable: false,
                defaultValue: DateTime.Now);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "models");

            migrationBuilder.AddColumn<int>(
                name: "Color",
                table: "models",
                nullable: false,
                defaultValue: 0);
        }
    }
}
