using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthWebApp.Migrations
{
    public partial class updateonNameTitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShortTitle",
                table: "NameTitle",
                newName: "ShortName");

            migrationBuilder.RenameColumn(
                name: "LongTittle",
                table: "NameTitle",
                newName: "LongName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShortName",
                table: "NameTitle",
                newName: "ShortTitle");

            migrationBuilder.RenameColumn(
                name: "LongName",
                table: "NameTitle",
                newName: "LongTittle");
        }
    }
}
