using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssignmntOrm.Migrations
{
    public partial class freshdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductModels_UpdateModels_UpdateModelUpdaeId",
                table: "ProductModels");

            migrationBuilder.DropIndex(
                name: "IX_ProductModels_UpdateModelUpdaeId",
                table: "ProductModels");

            migrationBuilder.DropColumn(
                name: "UpdateId",
                table: "ProductModels");

            migrationBuilder.DropColumn(
                name: "UpdateModelUpdaeId",
                table: "ProductModels");

            migrationBuilder.AddColumn<int>(
                name: "ProductModelsProductId",
                table: "UpdateModels",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdateId",
                table: "UpdateModels",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateModelUpdaeId",
                table: "UpdateModels",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UpdateModels_ProductModelsProductId",
                table: "UpdateModels",
                column: "ProductModelsProductId");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateModels_UpdateModelUpdaeId",
                table: "UpdateModels",
                column: "UpdateModelUpdaeId");

            migrationBuilder.AddForeignKey(
                name: "FK_UpdateModels_ProductModels_ProductModelsProductId",
                table: "UpdateModels",
                column: "ProductModelsProductId",
                principalTable: "ProductModels",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UpdateModels_UpdateModels_UpdateModelUpdaeId",
                table: "UpdateModels",
                column: "UpdateModelUpdaeId",
                principalTable: "UpdateModels",
                principalColumn: "UpdaeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UpdateModels_ProductModels_ProductModelsProductId",
                table: "UpdateModels");

            migrationBuilder.DropForeignKey(
                name: "FK_UpdateModels_UpdateModels_UpdateModelUpdaeId",
                table: "UpdateModels");

            migrationBuilder.DropIndex(
                name: "IX_UpdateModels_ProductModelsProductId",
                table: "UpdateModels");

            migrationBuilder.DropIndex(
                name: "IX_UpdateModels_UpdateModelUpdaeId",
                table: "UpdateModels");

            migrationBuilder.DropColumn(
                name: "ProductModelsProductId",
                table: "UpdateModels");

            migrationBuilder.DropColumn(
                name: "UpdateId",
                table: "UpdateModels");

            migrationBuilder.DropColumn(
                name: "UpdateModelUpdaeId",
                table: "UpdateModels");

            migrationBuilder.AddColumn<int>(
                name: "UpdateId",
                table: "ProductModels",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpdateModelUpdaeId",
                table: "ProductModels",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductModels_UpdateModelUpdaeId",
                table: "ProductModels",
                column: "UpdateModelUpdaeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductModels_UpdateModels_UpdateModelUpdaeId",
                table: "ProductModels",
                column: "UpdateModelUpdaeId",
                principalTable: "UpdateModels",
                principalColumn: "UpdaeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
