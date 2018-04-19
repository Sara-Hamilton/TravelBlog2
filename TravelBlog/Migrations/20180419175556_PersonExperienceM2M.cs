using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelBlog.Migrations
{
    public partial class PersonExperienceM2M : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Experiences_ExperienceId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_ExperienceId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "ExperienceId",
                table: "Persons");

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Experiences",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Experiences_PersonId",
                table: "Experiences",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Experiences_Persons_PersonId",
                table: "Experiences",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Experiences_Persons_PersonId",
                table: "Experiences");

            migrationBuilder.DropIndex(
                name: "IX_Experiences_PersonId",
                table: "Experiences");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Experiences");

            migrationBuilder.AddColumn<int>(
                name: "ExperienceId",
                table: "Persons",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persons_ExperienceId",
                table: "Persons",
                column: "ExperienceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Experiences_ExperienceId",
                table: "Persons",
                column: "ExperienceId",
                principalTable: "Experiences",
                principalColumn: "ExperienceId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
