using Aeronaves.Aplication.UseCases.Command.Aeronaves.AsignarAeronave;
using Aeronaves.Aplication.UseCases.Queries.Aeronaves.GetAeronaveById;
using AeroNaves.webApi.Controllers;
using MediatR;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeronaves.Test.WebApi.Controllers {
  public class AsignarAeronaveController_Tests {
    private readonly Mock<IMediator> _mediator;

    public AsignarAeronaveController_Tests() {
      _mediator = new Mock<IMediator>();
    }


    [Fact]
    public void AsignarAeronaveController_AsignarAeronaveTest() {
      var IdTest = Guid.NewGuid();
      var command = new AsignarAeronaveCommand(IdTest);

      AsignarAeronaveController controler = new AsignarAeronaveController(_mediator.Object);
      var result = controler.AsignarAeronave(command);
      Assert.NotNull(result);
    }


  }
}
