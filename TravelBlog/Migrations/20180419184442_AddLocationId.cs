using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelBlog.Migrations
{
    public partial class AddLocationId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Experiences_Locations_LocationId",
                table: "Experiences");

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Experiences",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Experiences_Locations_LocationId",
                table: "Experiences",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Experiences_Locations_LocationId",
                table: "Experiences");

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Experiences",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Experiences_Locations_LocationId",
                table: "Experiences",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
