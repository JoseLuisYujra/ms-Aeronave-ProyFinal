using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Aeronaves.Infraestructure.EF.Context;
using Aeronaves.Infraestructure.EF.ReadModel;
using Aeronaves.Aplication.Dto.Aeronave;
using Aeronaves.Aplication.UseCases.Queries.Aeronaves.SearchAeronave;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;


namespace Aeronaves.Infraestructure.EF.UseCases.Queries.Aeronave {

  public class SearchAeronaveHandler : IRequestHandler<SearchAeronaveQuery, AeronaveDTO> {
    private readonly DbSet<AeronaveReadModel> _context;

    public SearchAeronaveHandler(ReadDbContext context) {
      _context = context.Aeronave;
    }


    public async Task<AeronaveDTO> Handle(SearchAeronaveQuery request, CancellationToken cancellationToken) {
      AeronaveDTO result = null;
      var AeronaveList = await _context.FindAsync(request.Id);

      if (AeronaveList == null) {
        return null;
      }
      result = new AeronaveDTO() {
        Id = AeronaveList.Id,
        CodAeronave = AeronaveList.CodAeronave,
        Marca = AeronaveList.Marca,
        Modelo = AeronaveList.Modelo,
        NroAsientos = AeronaveList.NroAsientos,
        CapacidadCarga = AeronaveList.CapacidadCarga,
        CapTanqueCombustible = AeronaveList.CapTanqueCombustible,
        AereopuertoEstacionamiento = AeronaveList.AereopuertoEstacionamiento,
        EstadoAeronave = AeronaveList.EstadoAeronave
      };

      return result;
    }
  }
}
