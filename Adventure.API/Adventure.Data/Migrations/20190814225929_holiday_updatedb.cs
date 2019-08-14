using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Adventure.Data.Migrations
{
    public partial class holiday_updatedb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "HolidayId",
                table: "Images",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "HolidayTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HolidayTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Holidays",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PriceId = table.Column<Guid>(nullable: true),
                    LocationId = table.Column<Guid>(nullable: true),
                    HolidayTypeId = table.Column<Guid>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    LongDescription = table.Column<string>(nullable: true),
                    DateFrom = table.Column<DateTime>(nullable: false),
                    DateTo = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Holidays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Holidays_HolidayTypes_HolidayTypeId",
                        column: x => x.HolidayTypeId,
                        principalTable: "HolidayTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Holidays_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Holidays_Prices_PriceId",
                        column: x => x.PriceId,
                        principalTable: "Prices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Images_HolidayId",
                table: "Images",
                column: "HolidayId");

            migrationBuilder.CreateIndex(
                name: "IX_Holidays_HolidayTypeId",
                table: "Holidays",
                column: "HolidayTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Holidays_LocationId",
                table: "Holidays",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Holidays_PriceId",
                table: "Holidays",
                column: "PriceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Holidays_HolidayId",
                table: "Images",
                column: "HolidayId",
                principalTable: "Holidays",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Holidays_HolidayId",
                table: "Images");

            migrationBuilder.DropTable(
                name: "Holidays");

            migrationBuilder.DropTable(
                name: "HolidayTypes");

            migrationBuilder.DropIndex(
                name: "IX_Images_HolidayId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "HolidayId",
                table: "Images");
        }
    }
}
