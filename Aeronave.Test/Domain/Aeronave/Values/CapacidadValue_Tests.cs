using Aeronaves.Domain.ValueObjects;
using Newtonsoft.Json.Linq;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeronaves.Test.Domain.Aeronave.Values {
  public class CapacidadValue_Tests {
    [Fact]
    public void CapacidadValue_valid() {
      try {
        int value = 100;
        var valida = new CapacidadValue(value);
        if (value <= 0) {
          throw new BussinessRuleValidationException("La cantidad de pasajeros no puede ser negativa o cero");
        }
        Assert.NotNull(valida);
        Assert.False(true);
        valida.Value.Equals(value);
      } catch {
        Assert.False(false);
      };

      //valida exception
      try {
        int value2 = -80;
        var valida2 = new CapacidadValue(value2);
        if (value2 <= 0) {
          throw new BussinessRuleValidationException("La cantidad de pasajeros no puede ser negativa o cero");
        }
        Assert.NotNull(valida2);
        Assert.False(true);
        valida2.Value.Equals(value2);
      } catch {
        Assert.False(false);
      };
    }

    [Fact]
    public void CapacidadValue_Notvalid() {
      try {
        int valor = 140;
        var valida = new CapacidadValue(valor);
        Assert.NotNull(valida);
        Assert.False(true);
      } catch {
        Assert.False(false);
      };
    }


  }
}
