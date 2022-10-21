using AeroNaves.webApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeronaves.Test.WebApi {
  public class Program_Tests {
    [Fact]
    public void ProgramCreate_Correctly() {

      string[] arg = new String[1];
      try {
        Program.Main(arg);
        Assert.True(true);
      } catch {
        Assert.False(false);
      }
    }
  }
}
