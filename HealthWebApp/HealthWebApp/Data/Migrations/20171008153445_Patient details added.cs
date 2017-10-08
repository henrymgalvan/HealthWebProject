using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HealthWebApp.Data.Migrations
{
    public partial class Patientdetailsadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.CreateTable(
                name: "Barangay",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Barangay", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContactNumber = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: true),
                    ExtensionName = table.Column<string>(maxLength: 3, nullable: true),
                    FirstName = table.Column<string>(maxLength: 30, nullable: false),
                    LastName = table.Column<string>(maxLength: 30, nullable: false),
                    MiddleName = table.Column<string>(maxLength: 30, nullable: false),
                    NameTittle = table.Column<string>(maxLength: 30, nullable: true),
                    PersonConsent = table.Column<bool>(nullable: false),
                    Sex = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HouseholdMember",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CivilStatus = table.Column<int>(nullable: false),
                    FatherId = table.Column<int>(nullable: false),
                    HouseholdProfileId = table.Column<string>(nullable: true),
                    MotherId = table.Column<int>(nullable: false),
                    PersonId = table.Column<int>(nullable: false),
                    RelationToHead = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseholdMember", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HouseholdMember_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HouseholdProfile",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: true),
                    BarangayId = table.Column<int>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    ProfileId = table.Column<string>(nullable: true),
                    RespondentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseholdProfile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HouseholdProfile_Barangay_BarangayId",
                        column: x => x.BarangayId,
                        principalTable: "Barangay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HouseholdProfile_People_RespondentId",
                        column: x => x.RespondentId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HouseholdMember_PersonId",
                table: "HouseholdMember",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HouseholdProfile_BarangayId",
                table: "HouseholdProfile",
                column: "BarangayId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseholdProfile_RespondentId",
                table: "HouseholdProfile",
                column: "RespondentId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HouseholdMember");

            migrationBuilder.DropTable(
                name: "HouseholdProfile");

            migrationBuilder.DropTable(
                name: "Barangay");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName");
        }
    }
}
