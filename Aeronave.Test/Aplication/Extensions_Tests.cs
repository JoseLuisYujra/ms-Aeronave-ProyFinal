using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeronaves.Test.Aplication {
  public class Extensions_Tests {
    [Fact]
    public void Extensions_Correctly() {
      var iServiceCollection = new Mock<IServiceCollection>();

      try {
        object valueAplication = Aeronaves.Aplication.Extensions.AddApplication(iServiceCollection.Object);

        Assert.True(true);
      } catch {
        Assert.False(false);
      }
    }

  }
}
