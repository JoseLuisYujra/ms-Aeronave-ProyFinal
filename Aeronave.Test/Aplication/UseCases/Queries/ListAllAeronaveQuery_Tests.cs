using Aeronaves.Aplication.UseCases.Queries.Aeronaves.GetAeronaveById;
using Aeronaves.Aplication.UseCases.Queries.Aeronaves.ListAll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeronaves.Test.Aplication.UseCases.Queries {
  public class ListAllAeronaveQuery_Tests {

    [Fact]
    public void IsRequest_Valid() {
      var query = new ListAllAeronaveQuery();
      Assert.NotNull(query);
    }

  }
}
