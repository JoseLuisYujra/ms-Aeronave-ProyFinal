using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShareKernel.Core;
using Aeronaves.Domain.Event;
using Aeronaves.Domain.Model.Aeronaves;
using Aeronaves.Infraestructure.EF.Config.WriteConfig;

namespace Aeronaves.Infraestructure.EF.Context {
  public class WriteDbContext : DbContext {
    public virtual DbSet<Aeronave> Aeronave { get; set; }

    public WriteDbContext(DbContextOptions<WriteDbContext> options) : base(options) {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
      base.OnModelCreating(modelBuilder);

      var aeronaveConfig = new AeronaveWriteConfig();
      modelBuilder.ApplyConfiguration<Aeronave>(aeronaveConfig);
      modelBuilder.ApplyConfiguration<AeronaveAsientos>(aeronaveConfig);

      modelBuilder.Ignore<DomainEvent>();
      modelBuilder.Ignore<AeronaveAgregada>();
      modelBuilder.Ignore<AeronaveEstadoActualizado>();
      modelBuilder.Ignore<AsientoAgregado>();
    }
  }
}
