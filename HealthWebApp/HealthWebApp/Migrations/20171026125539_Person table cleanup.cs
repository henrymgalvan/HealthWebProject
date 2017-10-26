using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HealthWebApp.Migrations
{
    public partial class Persontablecleanup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_HouseholdProfile_HouseholdProfileId",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_People_HouseholdProfileId",
                table: "People");

            migrationBuilder.DropColumn(
                name: "HouseholdProfileId",
                table: "People");

            migrationBuilder.CreateTable(
                name: "PersonCreateModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: true),
                    BarangayId = table.Column<int>(nullable: true),
                    CivilStatus = table.Column<int>(nullable: false),
                    ContactNumber = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    ExtensionName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    HouseholdProfileId = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    NameTitle = table.Column<string>(nullable: true),
                    Sex = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonCreateModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonCreateModel_Barangay_BarangayId",
                        column: x => x.BarangayId,
                        principalTable: "Barangay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonCreateModel_BarangayId",
                table: "PersonCreateModel",
                column: "BarangayId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonCreateModel");

            migrationBuilder.AddColumn<int>(
                name: "HouseholdProfileId",
                table: "People",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_People_HouseholdProfileId",
                table: "People",
                column: "HouseholdProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_People_HouseholdProfile_HouseholdProfileId",
                table: "People",
                column: "HouseholdProfileId",
                principalTable: "HouseholdProfile",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
