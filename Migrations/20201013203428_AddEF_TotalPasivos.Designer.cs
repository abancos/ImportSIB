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
    [Migration("20201013203428_AddEF_TotalPasivos")]
    partial class AddEF_TotalPasivos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_AceptacionesCirculacion", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("AceptacionesCirculacion")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_AceptacionesCirculacion");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_BienesRecibidosRecuperacionCreditos", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("BienesRecibidos")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ProvisionBienesRecibidos")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_BienesRecibidosRecuperacionCreditos");
                });

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

                    b.Property<decimal>("RendimientosCobrar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Vencida")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Vigente")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_CarteraCreditos");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_CuentasCobrar", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("CuentasCobrar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("RendimientosCobrar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_CuentasCobrar");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_DepositosInstitucionesFinancieras", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("InstitucionesExterior")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("InstitucionesPais")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("InteresesPorPagar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_DepositosInstitucionesFinancieras");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_DeudoresAceptacion", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("DeudoresAceptacion")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_DeudoresAceptacion");
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

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_FondosInterbancariosActivos", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("FondosBancarios")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("RendimientosporCobrar")
                        .HasColumnType("decimal(16,4)");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_FondosInterbancariosActivos");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_FondosInterbancariosPasivos", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("FondosBancarios")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("InteresesPorPagar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_FondosInterbancariosPasivos");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_FondosTomadosPrestamos", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("BancoCentral")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("InstitucionesExterior")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("InstitucionesPais")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("InteresesPagar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Otros")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_FondosTomadosPrestamos");
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

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_InversionesAcciones", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("InversionesAcciones")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ProvisionInversionesAcciones")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_InversionesAcciones");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_ObligacionesPublico", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("ALaVista")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Ahorro")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("InteresesPorPagar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Plazo")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_ObligacionesPublico");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_ObligacionesRecompraTitulos", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("RecompraTitulos")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_ObligacionesRecompraTitulos");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_ObligacionesSubordinadas", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("DeudasSubordinadas")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("InteresesporPagar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_ObligacionesSubordinadas");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_OtrosActivos", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("ActivosDiversos")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("AmortizacionAcumulada")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CargosDiferidos")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Intangibles")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_OtrosActivos");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_OtrosPasivos", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("InteresesyComisiones")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("OtrosPasivos")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_OtrosPasivos");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_PropiedadMueblesEquipos", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("DepreciacionAcumulada")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PropiedadMueblesEquipos")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_PropiedadMueblesEquipos");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_TotalActivos", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("CuentasContingentes")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CuentasOrden")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalActivos")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_TotalActivos");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_TotalPasivos", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalPasivos")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_TotalPasivos");
                });

            modelBuilder.Entity("ImportSuperIntendencia.Models.EF_ValoresCirculacion", b =>
                {
                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("InteresesporPagar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TitulosyValores")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Fecha");

                    b.ToTable("EF_ValoresCirculacion");
                });
#pragma warning restore 612, 618
        }
    }
}
