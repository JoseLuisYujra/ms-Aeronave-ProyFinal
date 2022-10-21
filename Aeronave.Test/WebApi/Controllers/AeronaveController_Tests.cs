using Aeronaves.Aplication.Dto.Aeronave;
using Aeronaves.Aplication.UseCases.Command.Aeronaves.CrearAeronave;
using Aeronaves.Domain.Model.Aeronaves;
using Aeronaves.Domain.Repositories;
using Aeronaves.Infraestructure.EF;
using Aeronaves.Infraestructure.EF.Repository;
using Aeronaves.Test.Aplication;
using AeroNaves.webApi.Controllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;
using static Moq.It;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MockFactory = Aeronaves.Test.Aplication.MockFactory;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Aeronaves.Aplication.UseCases.Queries.Aeronaves.GetAeronaveById;
using Aeronaves.Aplication.UseCases.Queries.Aeronaves.SearchAeronave;
using Aeronaves.Aplication.Services;
using Aeronaves.Domain.Factory;
using Microsoft.Extensions.Logging;
using Shared.Rabbitmq.BusRabbit;
using Castle.Core.Logging;

namespace Aeronaves.Test.WebApi.Controllers {
  public class AeronaveController_Tests {
    private readonly Mock<IMediator> _mediator;

    public AeronaveController_Tests() {
      _mediator = new Mock<IMediator>();
    }


    [Fact]
    public void AeronaveController_CreateTest() {
      //var _mediator = new Mock<IMediator>();
      var CodAeronaveTest = "abc123";  //_aeoronaveService.GenerarIdAeronaveAsync();
      var MarcaTest = "Boeing";
      var ModeloTest = "Boeing 2022";
      var NroAsientosTest = 60;
      decimal CapacidadCargaTest = new(2000.0);
      decimal CapTanqueCombustibleTest = new(3500);
      var AereopuertoEstacionamientoTest = "Aeropuerto Internacional de El Alto";
      var aeronaveasientosListTest = MockFactory.GetAeronaveAsientos();
      var command = new CrearAeronaveCommand(CodAeronaveTest, MarcaTest, ModeloTest, NroAsientosTest, CapacidadCargaTest, CapTanqueCombustibleTest, AereopuertoEstacionamientoTest, aeronaveasientosListTest);


      var _aeronaveRepository = new Mock<IAeronaveRepository>();
      var _logger = new Mock<ILogger<CrearAeronaveHandler>>();
      var _aeoronaveService = new Mock<IAeoronaveService>();
      var _aeronaveFactory = new Mock<IAeronaveFactory>();
      var _unitOfWork = new Mock<IUnitOfWork>();
      var _eventBus = new Mock<IRabbitEventBus>();

      var objHandler = new CrearAeronaveHandler(
         _aeronaveRepository.Object,
         _logger.Object,
         _aeoronaveService.Object,
         _aeronaveFactory.Object,
         _unitOfWork.Object,
         _eventBus.Object
      );
      var tcs = new CancellationTokenSource(1000);
      var resultTest = objHandler.Handle(command, tcs.Token);


      AeronaveController controler = new AeronaveController(_mediator.Object);
      var result = controler.Create(command);

      _mediator.Setup(x => x.Send(resultTest, It.IsAny<CancellationToken>()))
               .ReturnsAsync(() => resultTest.Id);
      //.ReturnsAsync(Task.FromResult(Guid.NewGuid()));
      Assert.NotNull(result);
      Assert.IsType<Guid>(resultTest.Result);
    }


    [Fact]
    public void AeronaveController_GetAeronaveTest() {
      var IdTest = Guid.NewGuid();
      var query = new GetAeronaveByIdQuery(IdTest);

      AeronaveController controler = new AeronaveController(_mediator.Object);
      var result = controler.GetAeronave(query);
      Assert.NotNull(result);
    }


    [Fact]
    public void AeronaveController_SearchTest() {
      var Id = Guid.NewGuid();
      var query = new SearchAeronaveQuery();

      AeronaveController controler = new AeronaveController(_mediator.Object);
      var result = controler.Search(query);
      Assert.NotNull(result);
    }

  }
}
