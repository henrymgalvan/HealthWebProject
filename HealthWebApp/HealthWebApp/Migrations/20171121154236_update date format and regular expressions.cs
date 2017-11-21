using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthWebApp.Migrations
{
    public partial class updatedateformatandregularexpressions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_HouseholdMember_PersonId",
                table: "HouseholdMember");

            migrationBuilder.DropColumn(
                name: "FatherId",
                table: "HouseholdMember");

            migrationBuilder.DropColumn(
                name: "MotherId",
                table: "HouseholdMember");

            migrationBuilder.AddColumn<string>(
                name: "Barangay",
                table: "HouseholdMemberDetailModel",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "People",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_HouseholdMember_PersonId",
                table: "HouseholdMember",
                column: "PersonId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_HouseholdMember_PersonId",
                table: "HouseholdMember");

            migrationBuilder.DropColumn(
                name: "Barangay",
                table: "HouseholdMemberDetailModel");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "People",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<int>(
                name: "FatherId",
                table: "HouseholdMember",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MotherId",
                table: "HouseholdMember",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_HouseholdMember_PersonId",
                table: "HouseholdMember",
                column: "PersonId");
        }
    }
}
