using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelBlog.Migrations
{
    public partial class AddJoinTableIds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonExperience_Experiences_ExperiencesExperienceId",
                table: "PersonExperience");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonExperience_Persons_PersonsPersonId",
                table: "PersonExperience");

            migrationBuilder.DropIndex(
                name: "IX_PersonExperience_ExperiencesExperienceId",
                table: "PersonExperience");

            migrationBuilder.DropIndex(
                name: "IX_PersonExperience_PersonsPersonId",
                table: "PersonExperience");

            migrationBuilder.DropColumn(
                name: "ExperiencesExperienceId",
                table: "PersonExperience");

            migrationBuilder.DropColumn(
                name: "PersonsPersonId",
                table: "PersonExperience");

            migrationBuilder.AddColumn<int>(
                name: "ExperienceId",
                table: "PersonExperience",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "PersonExperience",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PersonExperience_ExperienceId",
                table: "PersonExperience",
                column: "ExperienceId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonExperience_PersonId",
                table: "PersonExperience",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonExperience_Experiences_ExperienceId",
                table: "PersonExperience",
                column: "ExperienceId",
                principalTable: "Experiences",
                principalColumn: "ExperienceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonExperience_Persons_PersonId",
                table: "PersonExperience",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonExperience_Experiences_ExperienceId",
                table: "PersonExperience");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonExperience_Persons_PersonId",
                table: "PersonExperience");

            migrationBuilder.DropIndex(
                name: "IX_PersonExperience_ExperienceId",
                table: "PersonExperience");

            migrationBuilder.DropIndex(
                name: "IX_PersonExperience_PersonId",
                table: "PersonExperience");

            migrationBuilder.DropColumn(
                name: "ExperienceId",
                table: "PersonExperience");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "PersonExperience");

            migrationBuilder.AddColumn<int>(
                name: "ExperiencesExperienceId",
                table: "PersonExperience",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonsPersonId",
                table: "PersonExperience",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersonExperience_ExperiencesExperienceId",
                table: "PersonExperience",
                column: "ExperiencesExperienceId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonExperience_PersonsPersonId",
                table: "PersonExperience",
                column: "PersonsPersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonExperience_Experiences_ExperiencesExperienceId",
                table: "PersonExperience",
                column: "ExperiencesExperienceId",
                principalTable: "Experiences",
                principalColumn: "ExperienceId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonExperience_Persons_PersonsPersonId",
                table: "PersonExperience",
                column: "PersonsPersonId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
