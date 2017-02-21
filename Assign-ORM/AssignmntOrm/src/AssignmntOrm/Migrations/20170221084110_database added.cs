using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AssignmntOrm.Migrations
{
    public partial class databaseadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "ProductModels",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(maxLength: 200, nullable: true),
                    HomepageUrl = table.Column<string>(maxLength: 60, nullable: false),
                    Name = table.Column<string>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductModels", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_ProductModels_UserModels_UserId",
                        column: x => x.UserId,
                        principalTable: "UserModels",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductModels_UserId",
                table: "ProductModels",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductModels");

            migrationBuilder.DropTable(
                name: "UserModels");
        }
    }
}
