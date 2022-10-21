using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;
using Aeronaves.Aplication.Dto.Aeronave;
using Aeronaves.Domain.Model.Aeronaves;
using Aeronaves.Domain.Repositories;


namespace Aeronaves.Aplication.UseCases.Queries.Aeronaves.GetAeronaveById {

  public class GetAeronaveByIdHandler : IRequestHandler<GetAeronaveByIdQuery, AeronaveDTO> {
    private readonly IAeronaveRepository _aeronaveRepository;
    private readonly ILogger<GetAeronaveByIdQuery> _logger;

    public GetAeronaveByIdHandler(IAeronaveRepository aeronaveRepository, ILogger<GetAeronaveByIdQuery> logger) {
      _aeronaveRepository = aeronaveRepository;
      _logger = logger;
    }

    public async Task<AeronaveDTO> Handle(GetAeronaveByIdQuery request, CancellationToken cancellationToken) {
      AeronaveDTO result = null;
      try {
        var objAeronave = await _aeronaveRepository.FindByIdAsync(request.Id);
        result = new AeronaveDTO() {
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
          result.AsientosAeronave.Add(new AeronaveAsientosDTO() {
            Id = item.Id,
            AeronaveId = item.AeronaveId,
            ClaseAsiento = item.ClaseAsiento,
            Ubicacion = item.Ubicacion,
            NroSilla = item.NroSilla,
            EstadoAsiento = item.EstadoAsiento
          });
        }
      } catch (Exception ex) {
        _logger.LogError(ex, "Error al obtener Aeronave con id: { Id }", request.Id);
      }

      return result;
    }
  }
}
