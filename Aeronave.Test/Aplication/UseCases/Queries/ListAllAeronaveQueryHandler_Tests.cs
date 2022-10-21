using Aeronaves.Aplication.Dto.Aeronave;
using Aeronaves.Aplication.UseCases.Queries.Aeronaves.GetAeronaveById;
using Aeronaves.Aplication.UseCases.Queries.Aeronaves.ListAll;
using Aeronaves.Domain.Factory;
using Aeronaves.Domain.Model.Aeronaves;
using Aeronaves.Domain.Repositories;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace Aeronaves.Test.Aplication.UseCases.Queries {
  public class ListAllAeronaveQueryHandler_Tests {
    private readonly Mock<IAeronaveRepository> _aeronaveRepository;
    private readonly Mock<ILogger<ListAllAeronaveQuery>> _logger;

    public ListAllAeronaveQueryHandler_Tests() {
      _aeronaveRepository = new Mock<IAeronaveRepository>();
      _logger = new Mock<ILogger<ListAllAeronaveQuery>>();
    }

    [Fact]
    public async void ListAllAeronaveQueryHandler_ValidTests() {

      var objHandler = new ListAllAeronaveQueryHandler(_aeronaveRepository.Object, _logger.Object);
      var tcs = new CancellationTokenSource(2000);
      var result = objHandler.Handle(new ListAllAeronaveQuery(), tcs.Token);

      List<AeronaveDTO> resultado = new List<AeronaveDTO>();
      List<Aeronave> DetalleAeronave = new List<Aeronave>();
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
        resultado.Add(aeronavelist);
      }

      Assert.NotNull(result.Result);

    }


  }
}
