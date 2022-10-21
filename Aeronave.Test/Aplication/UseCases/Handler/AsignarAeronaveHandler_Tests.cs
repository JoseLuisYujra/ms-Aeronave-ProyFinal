using Aeronaves.Aplication.Dto.Aeronave;
using Aeronaves.Aplication.Services;
using Aeronaves.Aplication.UseCases.Command.Aeronaves.AsignarAeronave;
using Aeronaves.Aplication.UseCases.Command.Aeronaves.CrearAeronave;
using Aeronaves.Domain.Factory;
using Aeronaves.Domain.Model.Aeronaves;
using Aeronaves.Domain.Repositories;
using Microsoft.Extensions.Logging;
using Moq;
using static Moq.It;
using Shared.Rabbitmq.BusRabbit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;
using Aeronaves.Infraestructure.EF.Repository;
using Microsoft.AspNetCore.Http;
using System.Data;
using System.Text.RegularExpressions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Aeronaves.Test.Aplication.UseCases.Handler {
  public class AsignarAeronaveHandler_Tests {

    private readonly Mock<IAeronaveRepository> _aeronaveRepository;
    private readonly Mock<ILogger<AsignarAeronaveHandler>> _logger;
    private readonly Mock<IUnitOfWork> _unitOfWork;
    /*
            private Aeronave aeronaveTest;

            private Guid idTest = Guid.NewGuid();
            private string codAeronaveTest = "ABC123";
            private string marcaTest = "Boeing";
            private string modeloTest = "Boeing-2022";
            private int nroasientosTest = 60;
            private decimal capacidadcargaTest = 1000;
            private decimal captanquecombustibleTest = 2000;
            private string aereopuertoEstacionamientoTest = "Aeropuerto Internacional del Alto";
    */

    public AsignarAeronaveHandler_Tests() {

      _aeronaveRepository = new Mock<IAeronaveRepository>();
      _logger = new Mock<ILogger<AsignarAeronaveHandler>>();
      _unitOfWork = new Mock<IUnitOfWork>();
      //            aeronaveTest = new AeronaveFactory().Create(codAeronaveTest, marcaTest, modeloTest, nroasientosTest, capacidadcargaTest, captanquecombustibleTest, aereopuertoEstacionamientoTest);
    }

    [Fact]
    public void AsignarAeronaveHandler_HandleCorrectly() {
      var idTest = Guid.NewGuid();
      var codAeronaveTest = "ABC123";
      var marcaTest = "Boeing";
      var modeloTest = "Boeing-2022";
      int nroasientosTest = 60;
      decimal capacidadcargaTest = 1000;
      decimal captanquecombustibleTest = 2000;
      var aereopuertoEstacionamientoTest = "Aeropuerto Internacional del Alto";
      var asientosAeronaveTests = MockFactory.GetAeronaveAsientos();
      Aeronave aeronaveT = new Aeronave(codAeronaveTest, marcaTest, modeloTest, nroasientosTest, capacidadcargaTest, captanquecombustibleTest, aereopuertoEstacionamientoTest);


      var objHandler = new AsignarAeronaveHandler(
         _aeronaveRepository.Object,
         _logger.Object,
         _unitOfWork.Object
       );

      var objRequest = new AsignarAeronaveCommand(idTest);
      var tcs = new CancellationTokenSource(1000);
      var result = objHandler.Handle(objRequest, tcs.Token);


      /*
      _aeronaveRepository.Setup(mock => mock.FindByIdAsync(objRequest.Id))
         .Returns(Task.FromResult(aeronaveTest));
      _aeronaveRepository.Verify(mock => mock.FindByIdAsync(objRequest.Id));
         aeronaveTest.ActualizarEstadoAeronave();
         _aeronaveRepository.Setup(mock => mock.UpdateAsync(aeronaveTest));
      //_aeronaveRepository.Verify(mock => mock.UpdateAsync(aeronaveTest), Times.Never);
      _aeronaveRepository.Verify(mock => mock.UpdateAsync(It.IsAny<Aeronave>()), Times.Never);
      _unitOfWork.Verify();
      */
      _aeronaveRepository.Setup(mock => mock.FindByIdAsync(idTest))
         .Returns(Task.FromResult(aeronaveT));
      _aeronaveRepository.Verify(mock => mock.FindByIdAsync(idTest));

      //aeronaveTest.ActualizarEstadoAeronave();
      aeronaveT.ActualizarEstadoAeronave();

      _aeronaveRepository.Setup(mock => mock.UpdateAsync(aeronaveT));
      _aeronaveRepository.Verify(mock => mock.UpdateAsync(aeronaveT), Times.Never);
      _unitOfWork.Verify(mock => mock.Commit(), Times.Never);

      //_aeronaveRepository.Verify(mock => mock.UpdateAsync(aeronaveTest), Times.Never);
      //_aeronaveRepository.Verify(mock => mock.UpdateAsync(It.IsAnyType<(aeronaveT), Times.Never);
      //_unitOfWork.Verify();

      // await _aeronaveRepository.Object.UpdateAsync(aeronaveTest);
      //_unitOfWork.Verify(mock => mock.Commit(), Times.Once);

      Assert.IsType<Guid>(result.Result);
    }

  }
}
