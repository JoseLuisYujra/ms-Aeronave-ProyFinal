using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Aeronaves.Domain.Model.Aeronaves;
using Aeronaves.Domain.ValueObjects;
using Aeronaves.Domain.Model.Aeronaves.ValueObjects;
using static Aeronaves.Domain.Model.Enum.Enums;

namespace Aeronaves.Infraestructure.EF.Config.WriteConfig {

  public class AeronaveWriteConfig : IEntityTypeConfiguration<Aeronave>, IEntityTypeConfiguration<AeronaveAsientos> {

    public void Configure(EntityTypeBuilder<Aeronave> builder) {

      builder.ToTable("Aeronave");
      builder.HasKey(x => x.Id);

      var codAeronaveConverter = new ValueConverter<CodigoAeronaveValue, string>(
          CodAeronaveValue => CodAeronaveValue.Value,
          CodAeronave => new CodigoAeronaveValue(CodAeronave)
      );
      builder.Property(x => x.CodAeronave)
          .HasConversion(codAeronaveConverter)
          .HasColumnName("CodAeronave")
          .HasMaxLength(25);

      builder.Property(x => x.Marca)
             .HasColumnName("Marca")
             .HasColumnType("string")
             .HasMaxLength(50);

      builder.Property(x => x.Modelo)
             .HasColumnName("Modelo")
             .HasColumnType("string")
             .HasMaxLength(50);

      var nroAsientosConverter = new ValueConverter<NroAsientosValue, int>(
          nroAsientosValue => nroAsientosValue.Value,
          nroAsientos => new NroAsientosValue(nroAsientos));
      builder.Property(x => x.NroAsientos)
             .HasConversion(nroAsientosConverter)
             .HasColumnName("NroAsientos")
             .HasColumnType("int");

      var CapacidadCargaConverter = new ValueConverter<RegistroDecimalValue, decimal>(
          CapacidadCargaValue => CapacidadCargaValue.Value,
          capacidadCarga => new RegistroDecimalValue(capacidadCarga));
      builder.Property(x => x.CapacidadCarga)
             .HasConversion(CapacidadCargaConverter)
             .HasColumnName("CapacidadCarga")
             .HasPrecision(18, 2);


      var capTanqueCombustibleConverter = new ValueConverter<RegistroDecimalValue, decimal>(
          capTanqueCombustibleValue => capTanqueCombustibleValue.Value,
          capTanqueCombustible => new RegistroDecimalValue(capTanqueCombustible));
      builder.Property(x => x.CapTanqueCombustible)
             .HasConversion(capTanqueCombustibleConverter)
             .HasColumnName("CapTanqueCombustible")
             .HasColumnType("decimal")
             .HasPrecision(18, 2);

      builder.Property(x => x.AereopuertoEstacionamiento)
            .HasColumnName("AereopuertoEstacionamiento")
            .HasColumnType("string")
            .HasMaxLength(50);

      builder.Property(x => x.EstadoAeronave)
             .HasColumnName("EstadoAeronave")
             .HasColumnType("string")
             .HasMaxLength(20);

      builder.HasMany(typeof(AeronaveAsientos), "AsientosAeronave");

      builder.Ignore("_domainEvents");
      builder.Ignore(x => x.DomainEvents);
      builder.Ignore(x => x.DetalleAsientos);

    }

    public void Configure(EntityTypeBuilder<AeronaveAsientos> builder) {

      builder.ToTable("AeronaveAsientos");
      builder.HasKey(x => x.Id);


      builder.Property(x => x.ClaseAsiento)
          .HasColumnName("ClaseAsiento")
          .HasMaxLength(50);

      builder.Property(x => x.Ubicacion)
          .HasColumnName("Ubicacion")
          .HasMaxLength(50);

      builder.Property(x => x.NroSilla)
          .HasColumnName("NroSilla")
          .HasColumnType("int");

      builder.Property(x => x.EstadoAsiento)
        .HasColumnName("EstadoAsiento")
        .HasMaxLength(50);

      builder.Ignore("_domainEvents");
      builder.Ignore(x => x.DomainEvents);
    }
  }
}
