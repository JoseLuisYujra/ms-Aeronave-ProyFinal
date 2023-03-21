using Aeronaves.Aplication.Services;
using Aeronaves.Aplication.UseCases.Command.Aeronaves.CrearAeronave;
using Aeronaves.Domain.Factory;
using Aeronaves.Domain.Model.Aeronaves;
using Aeronaves.Domain.Repositories;
using Aeronaves.Infraestructure.EF.Repository;
using Aeronaves.Infraestructure.EF;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using static Moq.It;
using Aeronaves.Aplication.Dto.Aeronave;
using Shared.Rabbitmq.BusRabbit;
using ShareKernel.Core;
using Aeronaves.Domain.Event;

namespace Aeronaves.Test.Aplication.UseCases.Handler {
  public class CrearAeronaveHandler_Tests {
    private readonly Mock<IAeronaveRepository> _aeronaveRepository;
    private readonly Mock<ILogger<CrearAeronaveHandler>> _logger;
    private readonly Mock<IAeoronaveService> _aeoronaveService;
    private readonly Mock<IAeronaveFactory> _aeronaveFactory;
    private readonly Mock<IUnitOfWork> _unitOfWork;
    private readonly Mock<IRabbitEventBus> _eventBus;


    private Aeronave aeronaveTest;

    private string codAeronaveTest = "ABC123";
    private string marcaTest = "Boeing";
    private string modeloTest = "Boeing-2022";
    private int nroasientosTest = 60;
    private decimal capacidadcargaTest = 1000;
    private decimal captanquecombustibleTest = 2000;
    private string aereopuertoEstacionamientoTest = "Aeropuerto Internacional del Alto";
    private List<AeronaveAsientosDTO> detalleAeronaveAsientosTest = MockFactory.GetAeronaveAsientos();


    public CrearAeronaveHandler_Tests() {
      _aeronaveRepository = new Mock<IAeronaveRepository>();
      _logger = new Mock<ILogger<CrearAeronaveHandler>>();
      _aeoronaveService = new Mock<IAeoronaveService>();
      _aeronaveFactory = new Mock<IAeronaveFactory>();
      _unitOfWork = new Mock<IUnitOfWork>();
      _eventBus = new Mock<IRabbitEventBus>();
      aeronaveTest = new AeronaveFactory().Create(codAeronaveTest, marcaTest, modeloTest, nroasientosTest, capacidadcargaTest, captanquecombustibleTest, aereopuertoEstacionamientoTest);
    }

    [Fact]
    public void CrearAeronaveHandler_HandleCorrectly() {

      _aeoronaveService.Setup(_aeoronaveService => _aeoronaveService.GenerarIdAeronaveAsync()).Returns(Task.FromResult(codAeronaveTest));
      _aeronaveFactory.Setup(_aeronaveFactory => _aeronaveFactory.Create(codAeronaveTest, marcaTest, modeloTest, nroasientosTest, capacidadcargaTest, captanquecombustibleTest, aereopuertoEstacionamientoTest)).Returns(aeronaveTest);

      var objHandler = new CrearAeronaveHandler(
         _aeronaveRepository.Object,
         _logger.Object,
         _aeoronaveService.Object,
         _aeronaveFactory.Object,
         _unitOfWork.Object
     //,         _eventBus.Object
     );

      var objRequest = new CrearAeronaveCommand(codAeronaveTest, marcaTest, modeloTest, nroasientosTest, capacidadcargaTest, captanquecombustibleTest, aereopuertoEstacionamientoTest, detalleAeronaveAsientosTest);
      var tcs = new CancellationTokenSource(1000);
      var result = objHandler.Handle(objRequest, tcs.Token);

      _aeronaveRepository.Verify(mock => mock.CreateAsync(IsAny<Aeronave>()), Times.Once);
      _unitOfWork.Verify(mock => mock.Commit(), Times.Once);
      Assert.IsType<Guid>(result.Result);

      var domainEventList = (List<DomainEvent>)aeronaveTest.DomainEvents;
      Assert.Equal(6, domainEventList.Count);
      Assert.IsType<AsientoAgregado>(domainEventList[0]);
      Assert.IsType<AsientoAgregado>(domainEventList[1]);
      Assert.IsType<AsientoAgregado>(domainEventList[2]);
      Assert.IsType<AsientoAgregado>(domainEventList[3]);
      Assert.IsType<AsientoAgregado>(domainEventList[4]);
      Assert.IsType<AeronaveAgregada>(domainEventList[5]);
    }

    [Fact]
    public void CrearAeronaveHandle_Handle_Fail() {
      // Failing by returning null values
      var objHandler = new CrearAeronaveHandler(
                                                _aeronaveRepository.Object,
                                                _logger.Object,
                                                _aeoronaveService.Object,
                                                _aeronaveFactory.Object,
                                                _unitOfWork.Object
                                                  //,                                                _eventBus.Object
                                                  );

      var objRequest = new CrearAeronaveCommand(codAeronaveTest, marcaTest, modeloTest, nroasientosTest, capacidadcargaTest, captanquecombustibleTest, aereopuertoEstacionamientoTest, detalleAeronaveAsientosTest);

      var tcs = new CancellationTokenSource(1000);
      var result = objHandler.Handle(objRequest, tcs.Token);

      _logger.Verify(mock => mock.Log(
          It.Is<LogLevel>(logLevel => logLevel == LogLevel.Error),
          It.Is<EventId>(eventId => eventId.Id == 0),
          It.Is<It.IsAnyType>((@object, @type) => @object.ToString() == "Error al crear Aeronave"),
          It.IsAny<Exception>(),
          It.IsAny<Func<It.IsAnyType, Exception, string>>())
      , Times.Once);
    }

  }
}
