using Aeronaves.Aplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Aeronaves.Test.Aplication.Services {
  public class AeronaveService_Tests {

    [Theory]
    [InlineData("ABCdsae112", false)]
    [InlineData("123asdcfgb", false)]
    [InlineData("1255463336", false)]
    [InlineData("789pphfdgh", false)]
    [InlineData("111", false)]
    [InlineData("sss", false)]
    [InlineData("", false)]
    //[InlineData(null, false)]
    public async void GenerarIdAeronave_CheckValidData(string expectedNroAeronave, bool isEqual) {
      var aeronaveservice = new AeronaveService();
      string idAeronave = await aeronaveservice.GenerarIdAeronaveAsync();
      if (isEqual) {
        Assert.Equal(expectedNroAeronave, idAeronave);
      } else {
        Assert.NotEqual(expectedNroAeronave, idAeronave);
      }

    }
  }
}
