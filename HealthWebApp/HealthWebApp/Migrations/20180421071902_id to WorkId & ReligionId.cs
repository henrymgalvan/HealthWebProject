using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthWebApp.Migrations
{
    public partial class idtoWorkIdReligionId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Work",
                newName: "WorkId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Religion",
                newName: "ReligionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WorkId",
                table: "Work",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ReligionId",
                table: "Religion",
                newName: "Id");
        }
    }
}
