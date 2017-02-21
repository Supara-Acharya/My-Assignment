using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssignmntOrm.Migrations
{
    public partial class newfreshdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "UpdateModelUpdaeId",
                table: "UpdateModels");

            migrationBuilder.RenameColumn(
                name: "UpdateId",
                table: "UpdateModels",
                newName: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_UpdateModels_ProductId",
                table: "UpdateModels",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_UpdateModels_ProductModels_ProductId",
                table: "UpdateModels",
                column: "ProductId",
                principalTable: "ProductModels",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UpdateModels_ProductModels_ProductId",
                table: "UpdateModels");

            migrationBuilder.DropIndex(
                name: "IX_UpdateModels_ProductId",
                table: "UpdateModels");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "UpdateModels",
                newName: "UpdateId");

            migrationBuilder.AddColumn<int>(
                name: "ProductModelsProductId",
                table: "UpdateModels",
                nullable: true);

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
    }
}
