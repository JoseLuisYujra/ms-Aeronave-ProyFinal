using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aeronaves.Domain.Model.Aeronaves;
using Aeronaves.Domain.Repositories;

namespace Aeronaves.Infraestructure.MemoryRepository {
  public class MemoryAeronaveRepository : IAeronaveRepository {
    private readonly MemoryDatabase _database;

    public MemoryAeronaveRepository(MemoryDatabase database) {
      _database = database;
    }

    public Task CreateAsync(Aeronave obj) {
      _database.Aeronaves.Add(obj);
      return Task.CompletedTask;
    }

    public Task<Aeronave> FindByIdAsync(Guid id) {
      return Task.FromResult(_database.Aeronaves.FirstOrDefault(x => x.Id == id));
    }

    public Task<List<Aeronave>> GetAll() {
      return Task.FromResult(_database.Aeronaves.ToList());
    }

    public Task UpdateAsync(Aeronave obj) {
      return Task.CompletedTask;
    }

  }
}
