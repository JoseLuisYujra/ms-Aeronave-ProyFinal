﻿// <auto-generated />
using System;
using Aeronaves.Infraestructure.EF.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Aeronaves.Infraestructure.EF.Migrations
{
    [DbContext(typeof(ReadDbContext))]
    [Migration("20221003000726_InitialStructure")]
    partial class InitialStructure
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Aeronaves.Infraestructure.EF.ReadModel.AeronaveAsientosReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AeronaveId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ClaseAsiento")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("ClaseAsiento");

                    b.Property<string>("EstadoAsiento")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("EstadoAsiento");

                    b.Property<int>("NroSilla")
                        .HasColumnType("int")
                        .HasColumnName("NroSilla");

                    b.Property<string>("Ubicacion")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Ubicacion");

                    b.HasKey("Id");

                    b.HasIndex("AeronaveId");

                    b.ToTable("AeronaveAsientos");
                });

            modelBuilder.Entity("Aeronaves.Infraestructure.EF.ReadModel.AeronaveReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AereopuertoEstacionamiento")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("AereopuertoEstacionamiento");

                    b.Property<decimal>("CapTanqueCombustible")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("CapTanqueCombustible");

                    b.Property<decimal>("CapacidadCarga")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("CapacidadCarga");

                    b.Property<string>("CodAeronave")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("CodAeronave");

                    b.Property<string>("EstadoAeronave")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("EstadoAeronave");

                    b.Property<string>("Marca")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Marca");

                    b.Property<string>("Modelo")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Modelo");

                    b.Property<int>("NroAsientos")
                        .HasColumnType("int")
                        .HasColumnName("NroAsientos");

                    b.HasKey("Id");

                    b.ToTable("Aeronave");
                });

            modelBuilder.Entity("Aeronaves.Infraestructure.EF.ReadModel.AeronaveAsientosReadModel", b =>
                {
                    b.HasOne("Aeronaves.Infraestructure.EF.ReadModel.AeronaveReadModel", "Aeronave")
                        .WithMany("AsientosAeronave")
                        .HasForeignKey("AeronaveId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aeronave");
                });

            modelBuilder.Entity("Aeronaves.Infraestructure.EF.ReadModel.AeronaveReadModel", b =>
                {
                    b.Navigation("AsientosAeronave");
                });
#pragma warning restore 612, 618
        }
    }
}
