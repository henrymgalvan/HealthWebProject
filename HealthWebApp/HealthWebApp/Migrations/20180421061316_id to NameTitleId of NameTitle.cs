using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthWebApp.Migrations
{
    public partial class idtoNameTitleIdofNameTitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "NameTitle",
                newName: "NameTitleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NameTitleId",
                table: "NameTitle",
                newName: "Id");
        }
    }
}
