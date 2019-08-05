using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Adventure.Data.Migrations
{
    public partial class relationships : Migration
    {
        /// <summary>
        /// Ups the specified migration builder.
        /// </summary>
        /// <param name="migrationBuilder">The migration builder.</param>
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Events_EventId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_EventId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Images");

            migrationBuilder.CreateTable(
                name: "EventImage",
                columns: table => new
                {
                    EventId = table.Column<Guid>(nullable: false),
                    ImageId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventImage", x => new { x.EventId, x.ImageId });
                    table.ForeignKey(
                        name: "FK_EventImage_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventImage_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventImage_ImageId",
                table: "EventImage",
                column: "ImageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventImage");

            migrationBuilder.AddColumn<Guid>(
                name: "EventId",
                table: "Images",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Images_EventId",
                table: "Images",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Events_EventId",
                table: "Images",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
