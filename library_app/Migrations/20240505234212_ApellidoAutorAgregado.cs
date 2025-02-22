﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace library_app.Migrations
{
    public partial class ApellidoAutorAgregado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Authors");
        }
    }
}
