using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ngApp.Web.Migrations
{
    public partial class modelFeaturesManyMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VehicleFeature");

            migrationBuilder.CreateTable(
                name: "ModelFeature",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FeatureId = table.Column<long>(nullable: false),
                    ModelId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelFeature", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModelFeature_features_FeatureId",
                        column: x => x.FeatureId,
                        principalTable: "features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModelFeature_models_ModelId",
                        column: x => x.ModelId,
                        principalTable: "models",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ModelFeature_FeatureId",
                table: "ModelFeature",
                column: "FeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_ModelFeature_ModelId",
                table: "ModelFeature",
                column: "ModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ModelFeature");

            migrationBuilder.CreateTable(
                name: "VehicleFeature",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FeatureId = table.Column<long>(nullable: false),
                    ModelId = table.Column<long>(nullable: true),
                    VehicleId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleFeature", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleFeature_features_FeatureId",
                        column: x => x.FeatureId,
                        principalTable: "features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VehicleFeature_models_ModelId",
                        column: x => x.ModelId,
                        principalTable: "models",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VehicleFeature_vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VehicleFeature_FeatureId",
                table: "VehicleFeature",
                column: "FeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleFeature_ModelId",
                table: "VehicleFeature",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleFeature_VehicleId",
                table: "VehicleFeature",
                column: "VehicleId");
        }
    }
}
