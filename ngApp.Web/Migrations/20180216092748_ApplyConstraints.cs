using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ngApp.Web.Migrations
{
    public partial class ApplyConstraints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Model_Make_MakeId",
                table: "Model");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Model",
                table: "Model");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Make",
                table: "Make");

            migrationBuilder.RenameTable(
                name: "Model",
                newName: "models");

            migrationBuilder.RenameTable(
                name: "Make",
                newName: "makes");

            migrationBuilder.RenameIndex(
                name: "IX_Model_MakeId",
                table: "models",
                newName: "IX_models_MakeId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "models",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "makes",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_models",
                table: "models",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_makes",
                table: "makes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_models_makes_MakeId",
                table: "models",
                column: "MakeId",
                principalTable: "makes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_models_makes_MakeId",
                table: "models");

            migrationBuilder.DropPrimaryKey(
                name: "PK_models",
                table: "models");

            migrationBuilder.DropPrimaryKey(
                name: "PK_makes",
                table: "makes");

            migrationBuilder.RenameTable(
                name: "models",
                newName: "Model");

            migrationBuilder.RenameTable(
                name: "makes",
                newName: "Make");

            migrationBuilder.RenameIndex(
                name: "IX_models_MakeId",
                table: "Model",
                newName: "IX_Model_MakeId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Model",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Make",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Model",
                table: "Model",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Make",
                table: "Make",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Model_Make_MakeId",
                table: "Model",
                column: "MakeId",
                principalTable: "Make",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
