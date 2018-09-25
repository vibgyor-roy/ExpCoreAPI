using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ProductAPI.Migrations
{
    public partial class InitialMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "eMail",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "eMailID",
                table: "Users",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "eMailID",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "eMail",
                table: "Users",
                nullable: true);
        }
    }
}
