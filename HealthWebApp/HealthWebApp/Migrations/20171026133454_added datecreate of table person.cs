using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthWebApp.Migrations
{
    public partial class addeddatecreateoftableperson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonCreateModel_Barangay_BarangayId",
                table: "PersonCreateModel");

            migrationBuilder.DropIndex(
                name: "IX_PersonCreateModel_BarangayId",
                table: "PersonCreateModel");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "PersonCreateModel");

            migrationBuilder.DropColumn(
                name: "BarangayId",
                table: "PersonCreateModel");

            migrationBuilder.DropColumn(
                name: "HouseholdProfileId",
                table: "PersonCreateModel");

            migrationBuilder.AddColumn<bool>(
                name: "PersonConsent",
                table: "PersonCreateModel",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "People",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PersonConsent",
                table: "PersonCreateModel");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "People");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "PersonCreateModel",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BarangayId",
                table: "PersonCreateModel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HouseholdProfileId",
                table: "PersonCreateModel",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersonCreateModel_BarangayId",
                table: "PersonCreateModel",
                column: "BarangayId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonCreateModel_Barangay_BarangayId",
                table: "PersonCreateModel",
                column: "BarangayId",
                principalTable: "Barangay",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
