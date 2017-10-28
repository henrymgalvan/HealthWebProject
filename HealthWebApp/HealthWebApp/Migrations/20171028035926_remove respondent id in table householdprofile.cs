using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthWebApp.Migrations
{
    public partial class removerespondentidintablehouseholdprofile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RespondentId",
                table: "HouseholdProfile");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RespondentId",
                table: "HouseholdProfile",
                nullable: false,
                defaultValue: 0);
        }
    }
}
