using Aeronaves.Aplication.Dto.Aeronave;
using Aeronaves.Aplication.UseCases.Queries.Aeronaves.GetAeronaveById;
using Aeronaves.Domain.Model.Aeronaves;
using Aeronaves.Domain.Repositories;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aeronaves.Aplication.UseCases.Queries.Aeronaves.ListAll {
  public class ListAllAeronaveQueryHandler : IRequestHandler<ListAllAeronaveQuery, List<AeronaveDTO>> {

    private readonly IAeronaveRepository _aeronaveRepository;
    private readonly ILogger<ListAllAeronaveQuery> _logger;

    public ListAllAeronaveQueryHandler(IAeronaveRepository aeronaveRepository, ILogger<ListAllAeronaveQuery> logger) {
      _aeronaveRepository = aeronaveRepository;
      _logger = logger;
    }

    public async Task<List<AeronaveDTO>> Handle(ListAllAeronaveQuery request, CancellationToken cancellationToken) {

      List<AeronaveDTO> result = new List<AeronaveDTO>();
      try {
        List<Aeronave> DetalleAeronave = await _aeronaveRepository.GetAll();
        foreach (var objAeronave in DetalleAeronave) {
          AeronaveDTO aeronavelist = new AeronaveDTO() {
            Id = objAeronave.Id,
            CodAeronave = objAeronave.CodAeronave,
            Marca = objAeronave.Marca,
            Modelo = objAeronave.Modelo,
            NroAsientos = objAeronave.NroAsientos,
            CapacidadCarga = objAeronave.CapacidadCarga,
            CapTanqueCombustible = objAeronave.CapTanqueCombustible,
            AereopuertoEstacionamiento = objAeronave.AereopuertoEstacionamiento,
            EstadoAeronave = objAeronave.EstadoAeronave
          };

          foreach (var item in objAeronave.DetalleAsientos) {
            aeronavelist.AsientosAeronave.Add(new AeronaveAsientosDTO() {
              Id = item.Id,
              AeronaveId = item.AeronaveId,
              ClaseAsiento = item.ClaseAsiento,
              Ubicacion = item.Ubicacion,
              NroSilla = item.NroSilla,
              EstadoAsiento = item.EstadoAsiento
            });
          }
          result.Add(aeronavelist);
        }
      } catch (Exception ex) {
        _logger.LogError(ex, "Error al obtener eL detalle completo de Aeronaves.");
      }
      return result.OrderBy(orden => orden.CodAeronave).ToList();
    }

  }
}
