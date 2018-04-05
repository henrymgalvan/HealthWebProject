using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HealthWebApp.Migrations
{
    public partial class BarangayDbInitializescs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonEditModel",
                columns: table => new
                {
                    PersonId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CivilStatus = table.Column<int>(nullable: false),
                    ContactNumber = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    DateTimeLastUpdated = table.Column<DateTime>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: true),
                    ExtensionName = table.Column<int>(nullable: false),
                    FatherId = table.Column<long>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 30, nullable: false),
                    LastName = table.Column<string>(maxLength: 30, nullable: false),
                    MiddleName = table.Column<string>(maxLength: 30, nullable: false),
                    MotherId = table.Column<long>(nullable: false),
                    NameTitleId = table.Column<int>(nullable: false),
                    PersonConsent = table.Column<bool>(nullable: false),
                    PhilHealthId = table.Column<long>(nullable: false),
                    PhilHealthId1 = table.Column<long>(nullable: true),
                    ReligionId = table.Column<int>(nullable: false),
                    Sex = table.Column<int>(nullable: false),
                    WorkId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonEditModel", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_PersonEditModel_NameTitle_NameTitleId",
                        column: x => x.NameTitleId,
                        principalTable: "NameTitle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonEditModel_PhilHealth_PhilHealthId1",
                        column: x => x.PhilHealthId1,
                        principalTable: "PhilHealth",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonEditModel_Religion_ReligionId",
                        column: x => x.ReligionId,
                        principalTable: "Religion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonEditModel_Work_WorkId",
                        column: x => x.WorkId,
                        principalTable: "Work",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonEditModel_NameTitleId",
                table: "PersonEditModel",
                column: "NameTitleId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonEditModel_PhilHealthId1",
                table: "PersonEditModel",
                column: "PhilHealthId1");

            migrationBuilder.CreateIndex(
                name: "IX_PersonEditModel_ReligionId",
                table: "PersonEditModel",
                column: "ReligionId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonEditModel_WorkId",
                table: "PersonEditModel",
                column: "WorkId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonEditModel");
        }
    }
}
