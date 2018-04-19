using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelBlog.Migrations
{
    public partial class PersonExperienceM2M2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "PersonExperience",
                columns: table => new
                {
                    PersonExperienceId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGeneratedOnAdd", true),
                    ExperiencesExperienceId = table.Column<int>(nullable: true),
                    PersonsPersonId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonExperience", x => x.PersonExperienceId);
                    table.ForeignKey(
                        name: "FK_PersonExperience_Experiences_ExperiencesExperienceId",
                        column: x => x.ExperiencesExperienceId,
                        principalTable: "Experiences",
                        principalColumn: "ExperienceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonExperience_Persons_PersonsPersonId",
                        column: x => x.PersonsPersonId,
                        principalTable: "Persons",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonExperience_ExperiencesExperienceId",
                table: "PersonExperience",
                column: "ExperiencesExperienceId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonExperience_PersonsPersonId",
                table: "PersonExperience",
                column: "PersonsPersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonExperience");

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
    }
}
