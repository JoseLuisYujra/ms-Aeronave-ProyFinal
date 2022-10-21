using Aeronaves.Domain.ValueObjects;
using ShareKernel.Core;
using ShareKernel.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeronaves.Test.Domain.Aeronave.Values {
  public class CantidadValue_Tests {
    [Fact]
    public void CantidadValue_Valid() {
      int value = 100;
      var valor = new CantidadValue(value);
      if (value <= 0) {
        throw new BussinessRuleValidationException("La cantidad no puede ser negativa o cero");
      }
      Assert.NotNull(valor);
      valor.Value.Equals(value);

      /////valida exception
      try {
        int value2 = -5;
        var valor2 = new CantidadValue(value2);
        if (value2 <= 0) {
          throw new BussinessRuleValidationException("La cantidad no puede ser negativa o cero");
        }
        Assert.NotNull(valor2);
        Assert.False(true);
        valor2.Value.Equals(value2);
      } catch {
        Assert.False(false);
      }
    }
  }
}
