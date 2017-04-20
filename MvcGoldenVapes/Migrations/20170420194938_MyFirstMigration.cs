using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MvcGoldenVapes.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VapeJuices",
                columns: table => new
                {
                    VapeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VapeBrand = table.Column<string>(nullable: true),
                    VapeName = table.Column<string>(nullable: true),
                    VapePrice = table.Column<double>(nullable: false),
                    VapeSize = table.Column<string>(nullable: true),
                    VapeStock = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VapeJuices", x => x.VapeID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VapeJuices");
        }
    }
}
