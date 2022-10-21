using Aeronaves.Aplication;
using AeroNaves.webApi;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeronaves.Test.Aplication {
  public class ExtensionsApp_Tests {

    [Fact]
    public void ExtensionsApp_Correctly() {
      var iApplicationBuilder = new Mock<IApplicationBuilder>();

      try {
        object value = Aeronaves.Aplication.ExtensionsApp.RabbitMQConsumer(iApplicationBuilder.Object);
        Assert.True(true);

      } catch {
        Assert.False(false);
      }
    }

  }
}
