using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AssignmntOrm.Migrations
{
    public partial class datebaseadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductModels_UserModels_UserId",
                table: "ProductModels");

            migrationBuilder.DropTable(
                name: "UserModels");

            migrationBuilder.DropIndex(
                name: "IX_ProductModels_UserId",
                table: "ProductModels");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "ProductModels",
                newName: "UpdateId");

            migrationBuilder.AddColumn<int>(
                name: "UpdateModelUpdaeId",
                table: "ProductModels",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UpdateModels",
                columns: table => new
                {
                    UpdaeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(maxLength: 200, nullable: true),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpdateModels", x => x.UpdaeId);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductModels_UpdateModels_UpdateModelUpdaeId",
                table: "ProductModels");

            migrationBuilder.DropTable(
                name: "UpdateModels");

            migrationBuilder.DropIndex(
                name: "IX_ProductModels_UpdateModelUpdaeId",
                table: "ProductModels");

            migrationBuilder.DropColumn(
                name: "UpdateModelUpdaeId",
                table: "ProductModels");

            migrationBuilder.RenameColumn(
                name: "UpdateId",
                table: "ProductModels",
                newName: "UserId");

            migrationBuilder.CreateTable(
                name: "UserModels",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    DOB = table.Column<string>(nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    URL = table.Column<string>(maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserModels", x => x.UserId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductModels_UserId",
                table: "ProductModels",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductModels_UserModels_UserId",
                table: "ProductModels",
                column: "UserId",
                principalTable: "UserModels",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
