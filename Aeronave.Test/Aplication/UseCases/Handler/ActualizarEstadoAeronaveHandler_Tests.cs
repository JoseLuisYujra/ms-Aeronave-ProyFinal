using Aeronaves.Aplication.UseCases.Command.Aeronaves;
using Aeronaves.Aplication.UseCases.Command.Aeronaves.AsignarAeronave;
using Aeronaves.Domain.Event;
using Aeronaves.Domain.Model.Aeronaves;
using Aeronaves.Domain.Repositories;
using Aeronaves.Domain.ValueObjects;
using Aeronaves.Infraestructure.EF;
using Aeronaves.Infraestructure.EF.Repository;
using Moq;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeronaves.Test.Aplication.UseCases.Handler {

  public class ActualizarEstadoAeronaveHandler_Tests {

    private readonly Mock<IAeronaveRepository> _IAeronaveRepository;

    public ActualizarEstadoAeronaveHandler_Tests() {
      _IAeronaveRepository = new Mock<IAeronaveRepository>();
    }

    [Fact]
    public void ActualizarEstadoAeronaveHandler_HandleCorrectly() {
      var IdTest = Guid.NewGuid();


      var CodAeronaveTest = "abc123";  //_aeoronaveService.GenerarIdAeronaveAsync();
      var MarcaTest = "Boeing";
      var ModeloTest = "Boeing 2022";
      var NroAsientosTest = 60;
      decimal CapacidadCargaTest = new(2000.0);
      decimal CapTanqueCombustibleTest = new(3500);
      var AereopuertoEstacionamientoTest = "Aeropuerto Internacional de El Alto";

      var IdAeronave = Guid.NewGuid();
      var EstadoAeronave = "Libre";

      Aeronave aeronaveTest = new Aeronave(CodAeronaveTest, MarcaTest, ModeloTest, NroAsientosTest, CapacidadCargaTest, CapTanqueCombustibleTest, AereopuertoEstacionamientoTest);

      var objHandler = new ActualizarEstadoAeronaveHandler(_IAeronaveRepository.Object);

      var objRequest = new AeronaveEstadoActualizado(IdAeronave, EstadoAeronave);
      var tcs = new CancellationTokenSource(1000);
      var result = objHandler.Handle(objRequest, tcs.Token);


      _IAeronaveRepository.Setup(mock => mock.FindByIdAsync(objRequest.Id))
         .Returns(Task.FromResult(aeronaveTest));
      aeronaveTest.ActualizarEstadoMantenimientoAeronave();

      /*
      await _IAeronaveRepository.Object.UpdateAsync(aeronaveTest);

      _IAeronaveRepository.Verify();
      */

      _IAeronaveRepository.Setup(mock => mock.UpdateAsync(aeronaveTest));
      _IAeronaveRepository.Verify(mock => mock.UpdateAsync(aeronaveTest), Times.Never);


      //Assert.IsType<Guid>(result);
      Assert.NotNull(result);

    }

  }
}
