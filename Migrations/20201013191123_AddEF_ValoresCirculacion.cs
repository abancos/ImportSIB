﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportSuperIntendencia.Migrations
{
    public partial class AddEF_ValoresCirculacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EF_ValoresCirculacion",
                columns: table => new
                {
                    Fecha = table.Column<DateTime>(nullable: false),
                    TitulosyValores = table.Column<decimal>(nullable: false),
                    InteresesporPagar = table.Column<decimal>(nullable: false),
                    Subtotal = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EF_ValoresCirculacion", x => x.Fecha);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EF_ValoresCirculacion");
        }
    }
}
