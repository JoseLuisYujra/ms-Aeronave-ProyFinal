using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aeronaves.Domain.Repositories;
using ShareKernel.Core;
using Aeronaves.Domain.Model.Aeronaves;
using Microsoft.EntityFrameworkCore;
using Aeronaves.Infraestructure.EF.Context;


namespace Aeronaves.Infraestructure.EF.Repository {

  public class AeronaveRepository : IAeronaveRepository {
    /*
      public Task CreateAsync(Aeronaves.Domain.Model.Aeronaves.Aeronave obj)
      {
          Console.WriteLine($"Insertando Asignacion de Aeronave { obj.CodAeronave }");

          return Task.CompletedTask;
      }

      public Task<Aeronaves.Domain.Model.Aeronaves.Aeronave> FindByIdAsync(Guid id)
      {
          Console.WriteLine($"Retornando Asignacion de Aeronave{ id }");

          return null;
      }


      public Task UpdateAsync(Aeronaves.Domain.Model.Aeronaves.Aeronave obj)
      {
          Console.WriteLine($"Actualizando Asignacion de Aeronave { obj.CodAeronave }");

          return Task.CompletedTask;
      }
      /*
      Task<Aeronaves.Domain.Model.Aeronaves.Aeronave> IRepository<Aeronaves.Domain.Model.Aeronaves.Aeronave, Guid>.FindByIdAsync(Guid id)
      {
          throw new NotImplementedException();
      }
      */


    public readonly DbSet<Aeronave> _aeronave;

    public AeronaveRepository(WriteDbContext context) {
      _aeronave = context.Aeronave;
    }

    public async Task CreateAsync(Aeronave obj) {
      await _aeronave.AddAsync(obj);
    }

    public async Task<Aeronave> FindByIdAsync(Guid id) {

      return await _aeronave.SingleAsync(x => x.Id == id);

      /*
             return await _aeronave.Include("AsientosAeronave")
                    .SingleAsync(x => x.Id == id);           
      */
    }

    public Task UpdateAsync(Aeronave obj) {
      _aeronave.Update(obj);

      return Task.CompletedTask;
    }

    public Task<List<Aeronave>> GetAll() {
      return _aeronave.Include("AsientosAeronave").ToListAsync();
    }

  }
}
