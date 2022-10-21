using Aeronaves.Aplication.UseCases.Command.Aeronaves.AsignarAeronave;
using Aeronaves.Aplication.UseCases.Command.Aeronaves.CrearAeronave;
using Aeronaves.Aplication.UseCases.Queries.Aeronaves.GetAeronaveById;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Aeronaves.Test.Aplication.UseCases.Command {
  public class AsignarAeronaveCommand_Tests {
    [Fact]
    public void IsRequest_Valid() {
      var IdTest = Guid.NewGuid();

      var command = new AsignarAeronaveCommand(IdTest);

      Assert.Equal(IdTest, command.Id);
    }

  }
}
