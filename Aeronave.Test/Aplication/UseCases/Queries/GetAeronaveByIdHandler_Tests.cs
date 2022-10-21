using Aeronaves.Aplication.Dto.Aeronave;
using Aeronaves.Aplication.Services;
using Aeronaves.Aplication.UseCases.Command.Aeronaves.AsignarAeronave;
using Aeronaves.Aplication.UseCases.Command.Aeronaves.CrearAeronave;
using Aeronaves.Aplication.UseCases.Queries.Aeronaves.GetAeronaveById;
using Aeronaves.Domain.Factory;
using Aeronaves.Domain.Model.Aeronaves;
using Aeronaves.Domain.Repositories;
using Aeronaves.Infraestructure.EF;
using Microsoft.Extensions.Logging;
using Moq;
using Shared.Rabbitmq.BusRabbit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeronaves.Test.Aplication.UseCases.Queries {
  public class GetAeronaveByIdHandler_Tests {
    private readonly Mock<IAeronaveRepository> _aeronaveRepository;
    private readonly Mock<ILogger<GetAeronaveByIdQuery>> _logger;

    private Aeronave aeronaveTest;

    private string codAeronaveTest = "ABC123";
    private string marcaTest = "Boeing";
    private string modeloTest = "Boeing-2022";
    private int nroasientosTest = 60;
    private decimal capacidadcargaTest = 1000;
    private decimal captanquecombustibleTest = 2000;
    private string aereopuertoEstacionamientoTest = "Aeropuerto Internacional del Alto";


    public GetAeronaveByIdHandler_Tests() {
      _aeronaveRepository = new Mock<IAeronaveRepository>();
      _logger = new Mock<ILogger<GetAeronaveByIdQuery>>();
      aeronaveTest = new AeronaveFactory().Create(codAeronaveTest, marcaTest, modeloTest, nroasientosTest, capacidadcargaTest, captanquecombustibleTest, aereopuertoEstacionamientoTest);
    }

    [Fact]
    public void GetAeronaveByIdQueryHandler_Tests() {
      var IdTest = Guid.NewGuid();
      var CodAeronaveTest = "abc123";  //_aeoronaveService.GenerarIdAeronaveAsync();
      var MarcaTest = "Boeing";
      var ModeloTest = "Boeing 2022";
      var NroAsientosTest = 60;
      decimal CapacidadCargaTest = new(2000.0);
      decimal CapTanqueCombustibleTest = new(3500);
      var AereopuertoEstacionamientoTest = "Aeropuerto Internacional de El Alto";
      var EstadoAeronavTeste = "Operativo";
      var AsientosAeronaveTests = MockFactory.GetAeronaveAsientos();

      var AeronaveIdTest = IdTest;
      var ClaseAsientoTest = "Economica";
      var UbicacionTest = "Centro";
      var NroSillaTest = 1;
      var EstadoAsientoTest = "Libre";

      var objAeronave = new AeronaveDTO();
      var objAeronaveAsientos = new AeronaveAsientosDTO();


      var objHandler = new GetAeronaveByIdHandler(
         _aeronaveRepository.Object,
         _logger.Object
     );

      var objRequest = new GetAeronaveByIdQuery(IdTest);
      var tcs = new CancellationTokenSource(1000);
      var result = objHandler.Handle(objRequest, tcs.Token);

      _aeronaveRepository.Setup(mock => mock.FindByIdAsync(objRequest.Id))
        .Returns(Task.FromResult(aeronaveTest));


      //objAeronave.AsientosAeronave.Add( new AeronaveAsientosDTO());
      /*

      objAeronave.AsientosAeronave.Add(new AeronaveAsientosDTO()
                  {
                       Id = Guid.NewGuid(),
                       AeronaveId = IdTest,
                       ClaseAsiento = ClaseAsientoTest,
                       Ubicacion = UbicacionTest,
                       NroSilla = NroSillaTest,
                       EstadoAsiento = EstadoAsientoTest
                   });

      */

      foreach (var item in objAeronave.AsientosAeronave) {
        objAeronave.AsientosAeronave.Add(new AeronaveAsientosDTO() {
          Id = item.Id,
          AeronaveId = item.AeronaveId,
          ClaseAsiento = item.ClaseAsiento,
          Ubicacion = item.Ubicacion,
          NroSilla = item.NroSilla,
          EstadoAsiento = item.EstadoAsiento
        });
      }


      Assert.Equal(IdTest, objRequest.Id);
      Assert.NotNull(result);


      //Assert.IsType<int>(objAeronave.AsientosAeronave.Count);

    }

  }
}

