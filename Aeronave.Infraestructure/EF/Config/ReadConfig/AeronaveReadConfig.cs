using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Aeronaves.Infraestructure.EF.ReadModel;
using Aeronaves.Aplication.Dto.Aeronave;

namespace Aeronaves.Infraestructure.EF.Config.ReadConfig {
  public class AeronaveReadConfig : IEntityTypeConfiguration<AeronaveReadModel>,
                                    IEntityTypeConfiguration<AeronaveAsientosReadModel> {
    public void Configure(EntityTypeBuilder<AeronaveReadModel> builder) {

      builder.ToTable("Aeronave");
      builder.HasKey(x => x.Id);
      //builder.Property(x => x.Id)
      //    .HasColumnName("Id")                
      //    .HasMaxLength(40);

      builder.Property(x => x.CodAeronave)
          .HasColumnName("CodAeronave")
          .HasMaxLength(50);

      builder.Property(x => x.Marca)
          .HasColumnName("Marca")
          .HasMaxLength(50);

      builder.Property(x => x.Modelo)
          .HasColumnName("Modelo")
          .HasMaxLength(50);

      builder.Property(x => x.NroAsientos)
         .HasColumnName("NroAsientos")
         .HasColumnType("int");

      builder.Property(x => x.CapacidadCarga)
          .HasColumnName("CapacidadCarga")
          .HasColumnType("decimal")
          .HasPrecision(18, 2);

      builder.Property(x => x.CapTanqueCombustible)
         .HasColumnName("CapTanqueCombustible")
         .HasColumnType("decimal")
         .HasPrecision(18, 2);

      builder.Property(x => x.AereopuertoEstacionamiento)
         .HasColumnName("AereopuertoEstacionamiento")
         .HasMaxLength(50);


      builder.Property(x => x.EstadoAeronave)
             .HasColumnName("EstadoAeronave")
             .HasMaxLength(20);

      builder.HasMany(x => x.AsientosAeronave)
             .WithOne(x => x.Aeronave);
    }

    public void Configure(EntityTypeBuilder<AeronaveAsientosReadModel> builder) {
      builder.ToTable("AeronaveAsientos");
      builder.HasKey(x => x.Id);

      //builder.Property(x => x.IdAsiento)
      //   .HasColumnName("IdAsiento")
      //   .HasMaxLength(40);

      /*
      builder.Property(x => x.AeronaveId)
          .HasColumnName("AeronaveId")
          .HasMaxLength(40);
      */
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
    }
  }
}


