using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aeronaves.Infraestructure.EF.Config.ReadConfig;
using Aeronaves.Infraestructure.EF.ReadModel;
using Aeronaves.Domain.Event;
using Microsoft.EntityFrameworkCore;
using ShareKernel.Core;

namespace Aeronaves.Infraestructure.EF.Context {

  public class ReadDbContext : DbContext {
    public virtual DbSet<AeronaveReadModel> Aeronave { set; get; }
    //public virtual DbSet<AeronaveAsientosReadModel> AeronaveAsientos { set; get; }

    public ReadDbContext(DbContextOptions<ReadDbContext> options) : base(options) {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
      base.OnModelCreating(modelBuilder);

      var aeronaveConfig = new AeronaveReadConfig();
      modelBuilder.ApplyConfiguration<AeronaveReadModel>(aeronaveConfig);
      modelBuilder.ApplyConfiguration<AeronaveAsientosReadModel>(aeronaveConfig);

      modelBuilder.Ignore<DomainEvent>();
      modelBuilder.Ignore<AeronaveAgregada>();
      modelBuilder.Ignore<AeronaveEstadoActualizado>();
      modelBuilder.Ignore<AsientoAgregado>();

    }
  }
}
