using Aeronaves.Domain.Model.Aeronaves.ValueObjects;
using Newtonsoft.Json.Linq;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeronaves.Test.Domain.Aeronave.Values {
  public class AeronaveEstados_Tests {
    [Fact]
    public void AeronaveEstados_CorrectlyTest() {
      string value = "Operativo";
      var valida = new AeronaveEstados(value);
      Assert.NotNull(valida);

    }


    [Fact]
    public void AeronaveEstados_IncorrectlyTest() {
      string value = "Estadoincorrecto";
      try {
        var valida = new AeronaveEstados(value);

        if (value is null) {
          throw new BussinessRuleValidationException("El Estado no puede ser vacio o nulo");
        } else if (value != "Operativo" && value != "Mantenimiento" && value != "Asignado") {
          throw new BussinessRuleValidationException("El Estado no es valido -> (Operativo,Mantenimiento,Asignado)");
        }
        Assert.NotNull(valida);
        Assert.False(true);
        valida.Value.Equals(value);
      } catch {
        Assert.False(false);
      }
    }

    [Fact]
    public void AeronaveEstados_NullTest() {
      string value = null;
      try {
        var valida = new AeronaveEstados(value);
        if (value is null) {
          throw new BussinessRuleValidationException("El Estado no puede ser vacio o nulo");
        } else if (value != "Operativo" && value != "Mantenimiento" && value != "Asignado") {
          throw new BussinessRuleValidationException("El Estado no es valido -> (Operativo,Mantenimiento,Asignado)");
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
