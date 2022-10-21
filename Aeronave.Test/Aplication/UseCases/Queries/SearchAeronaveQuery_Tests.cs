using Aeronaves.Aplication.UseCases.Queries.Aeronaves.GetAeronaveById;
using Aeronaves.Aplication.UseCases.Queries.Aeronaves.SearchAeronave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Aeronaves.Test.Aplication.UseCases.Queries {
  public class SearchAeronaveQuery_Tests {

    [Fact]
    public void IsRequest_Valid() {
      var Id = Guid.NewGuid();
      var query = new SearchAeronaveQuery();

      Assert.IsType<Guid>(query.Id);
      Assert.NotNull(query);
    }
  }
}
