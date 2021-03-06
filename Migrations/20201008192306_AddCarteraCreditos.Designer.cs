﻿// <auto-generated />
using System;
using ImportSuperIntendencia.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ImportSuperIntendencia.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201008192306_AddCarteraCreditos")]
    partial class AddCarteraCreditos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_CarteraCreditos", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("CobranzaJudicial")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ProvisionesCredito")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Reestructurada")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("RendimientosCObrar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Vigente")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_CarteraCreditos");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_FondosDisponibles", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("BancoCentral")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("BancosExtranjeros")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("BancosPais")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Caja")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Otras")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("RendimientosCobrar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_FondosDisponibles");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_FondosInterbancarios", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("FondosBancarios")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("RendimientosporCobrar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_FondosInterbancarios");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_Inversiones", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("DisponiblesVenta")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("InversionesDepositosValores")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("InversionesInstDeudas")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MantenidasVencimiento")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Negociables")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ProvisionInversiones")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("RendimientoPorCobrar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_Inversiones");
                });
#pragma warning restore 612, 618
        }
    }
}
