using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cms.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<decimal>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Goods",
                columns: table => new
                {
                    Id = table.Column<decimal>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "locations",
                columns: table => new
                {
                    Id = table.Column<decimal>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    LocationType = table.Column<string>(type: "nvarchar(50)", unicode: false, nullable: false, defaultValue: "shop"),
                    Tell = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    CityId = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_locations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_locations_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FactorDocs",
                columns: table => new
                {
                    Id = table.Column<decimal>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    Confrimdate = table.Column<DateTime>(nullable: false),
                    Date = table.Column<string>(nullable: true),
                    LocationId = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FactorDocs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FactorDocs_locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FactorDocDetails",
                columns: table => new
                {
                    Id = table.Column<decimal>(nullable: false),
                    AddressBuy = table.Column<string>(nullable: true),
                    Quantity = table.Column<float>(nullable: false),
                    GoodsId = table.Column<decimal>(nullable: true),
                    FactorDocId = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FactorDocDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FactorDocDetails_Goods_GoodsId",
                        column: x => x.GoodsId,
                        principalTable: "Goods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FactorDocDetails_FactorDocs_FactorDocId",
                        column: x => x.FactorDocId,
                        principalTable: "FactorDocs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FactorDocDetails_GoodsId",
                table: "FactorDocDetails",
                column: "GoodsId");

            migrationBuilder.CreateIndex(
                name: "IX_FactorDocDetails_FactorDocId",
                table: "FactorDocDetails",
                column: "FactorDocId");

            migrationBuilder.CreateIndex(
                name: "IX_FactorDocs_LocationId",
                table: "FactorDocs",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_locations_CityId",
                table: "locations",
                column: "CityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FactorDocDetails");

            migrationBuilder.DropTable(
                name: "Goods");

            migrationBuilder.DropTable(
                name: "FactorDocs");

            migrationBuilder.DropTable(
                name: "locations");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
