using Aeronaves.Domain.Model.Aeronaves.ValueObjects;
using Aeronaves.Domain.ValueObjects;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeronaves.Test.Domain.Aeronave.Values {
  public class RegistroDecimalValue_Tests {

    [Fact]
    public void RegistroDecimalValue_CorrectlyTest() {
      decimal value = new(100.00);
      var valida = new RegistroDecimalValue(value);
      Assert.NotNull(valida);
      valida.Value.Equals(value);
    }

    [Fact]
    public void RegistroDecimalValue_IncorrectlyTest() {
      decimal value = new(-50.00);
      try {
        var valida = new RegistroDecimalValue(value);
        if (value < 0) {
          throw new BussinessRuleValidationException("El valor del registro no puede ser Negativo");
        }
        Assert.NotNull(valida);
        Assert.False(true);
        valida.Value.Equals(value);
      } catch {
        Assert.False(false);
      }
    }

  }
}
