﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportSuperIntendencia.Migrations
{
    public partial class AddBienesRecibidosRecuperacionCreditos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EF_BienesRecibidosRecuperacionCreditos",
                columns: table => new
                {
                    Fecha = table.Column<DateTime>(nullable: false),
                    BienesRecibidos = table.Column<decimal>(nullable: false),
                    ProvisionBienesRecibidos = table.Column<decimal>(nullable: false),
                    Subtotal = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EF_BienesRecibidosRecuperacionCreditos", x => x.Fecha);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EF_BienesRecibidosRecuperacionCreditos");
        }
    }
}
