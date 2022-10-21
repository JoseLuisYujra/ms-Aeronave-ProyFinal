using Aeronaves.Domain.Model.Aeronaves.ValueObjects;
using Newtonsoft.Json.Linq;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeronaves.Test.Domain.Aeronave.Values {
  public class AeronaveEstadoDisponibilidad_Tests {
    [Fact]
    public void AeronaveEstadoDisponibilidad_CorrectlyTest() {
      string value = "Disponible";
      var valida = new AeronaveEstadoDisponibilidad(value);
      Assert.NotNull(valida);
      valida.Value.Equals(value);
    }

    [Fact]
    public void AeronaveEstadoAsignacion_IncorrectlyTest() {
      string value = "EstadoIncorrecto";
      try {
        var valida = new AeronaveEstadoDisponibilidad(value);
        if (value is null) {
          throw new BussinessRuleValidationException("El Estado no puede ser vacio o nulo");
        } else if (value != "Disponible" && value != "Asignado") {
          throw new BussinessRuleValidationException("El Estado no es valido -> (Disponible,Asignado)");
        }
        Assert.NotNull(valida);
        Assert.False(true);
        valida.Value.Equals(value);
      } catch {
        Assert.False(false);
      }
    }

    [Fact]
    public void AeronaveEstadoAsignacion_nullTest() {
      string value = null;
      try {
        var valida = new AeronaveEstadoDisponibilidad(value);
        if (value is null) {
          throw new BussinessRuleValidationException("El Estado no puede ser vacio o nulo");
        } else if (value != "Disponible" && value != "Asignado") {
          throw new BussinessRuleValidationException("El Estado no es valido -> (Disponible,Asignado)");
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
