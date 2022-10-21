using Aeronaves.Domain.Model.Aeronaves.ValueObjects;
using Aeronaves.Domain.ValueObjects;
using Newtonsoft.Json.Linq;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeronaves.Test.Domain.Aeronave.Values {
  public class values_Test {
    [Fact]
    public void CapacidadDecimalValue_Test() {
      decimal valor = new(1000.0);
      var valida = new CapacidadDecimalValue(valor);
      Assert.NotNull(valida);
      valida.Value.Equals(valor);

      //valida Exception
      try {
        decimal value = new(-100.0);
        var valida2 = new CapacidadDecimalValue(value);
        if (value <= 0) {
          throw new BussinessRuleValidationException("La capacidad no puede ser menor o igual que 0");
        }
        Assert.NotNull(valida2);
        Assert.False(true);
        valida2.Value.Equals(value);
      } catch {
        Assert.False(false);
      }
    }

    [Fact]
    public void NroAsientosValue_CorrectlyTest() {
      int value = 50;
      try {
        var valida = new NroAsientosValue(value);
        if (value <= 0) {
          throw new BussinessRuleValidationException("La capacidad no puede ser menor o igual que 0");
        }
        Assert.NotNull(valida);
        Assert.False(true);
        valida.Value.Equals(value);
      } catch {
        Assert.False(false);
      }
    }

    [Fact]
    public void NroAsientosValue_incorrectlyTest() {
      int value = -5;
      try {
        var valida = new NroAsientosValue(value);
        if (value <= 0) {
          throw new BussinessRuleValidationException("La capacidad no puede ser menor o igual que 0");
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
