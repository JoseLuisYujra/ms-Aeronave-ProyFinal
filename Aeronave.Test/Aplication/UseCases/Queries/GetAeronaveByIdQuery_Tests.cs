using Aeronaves.Aplication.UseCases.Command.Aeronaves.AsignarAeronave;
using Aeronaves.Aplication.UseCases.Queries.Aeronaves.GetAeronaveById;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Aeronaves.Test.Aplication.UseCases.Queries {
  public class GetAeronaveByIdQuery_Tests {
    [Fact]
    public void IsRequest_Valid() {
      var IdTest = Guid.NewGuid();
      var query = new GetAeronaveByIdQuery(IdTest);
      Assert.Equal(IdTest, query.Id);
    }

    [Fact]
    public void IsRequest_Valid2() {
      var IdTest = Guid.NewGuid();
      var query1 = new GetAeronaveByIdQuery();
      Assert.NotNull(query1);
    }


    [Fact]
    public void TestConstructor_IsPrivate() {
      var command = (GetAeronaveByIdQuery)Activator.CreateInstance(typeof(GetAeronaveByIdQuery), true);
      Assert.NotNull(command);
      Assert.Equal(Guid.Empty, command.Id);
    }
  }
}
