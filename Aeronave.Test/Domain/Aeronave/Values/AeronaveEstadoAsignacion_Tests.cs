using Aeronaves.Domain.Model.Aeronaves.ValueObjects;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeronaves.Test.Domain.Aeronave.Values {
  public class AeronaveEstadoAsignacion_Tests {

    [Fact]
    public void AeronaveEstadoAsignacion_Test() {

      string estado = "Asignado";
      var valida = new AeronaveEstadoAsignacion(estado);
      Assert.NotNull(valida);
      valida.Value.Equals(estado);

      //valida Exception 1 
      try {
        string value = "EstadoIncorrecto";
        var valida2 = new AeronaveEstadoAsignacion(value);

        if (value is null) {
          throw new BussinessRuleValidationException("El Estado no puede ser vacio o nulo");
        } else if (value != "Asignado" && value != "Cancelado") {
          throw new BussinessRuleValidationException("El Estado no es valido -> (Asignado,Cancelado)");
        }
        Assert.NotNull(valida2);
        Assert.False(true);
        valida2.Value.Equals(value);
      } catch {
        Assert.False(false);
      }

      //valida Exception 2 
      try {
        string value = null;
        var valida3 = new AeronaveEstadoAsignacion(value);

        if (value is null) {
          throw new BussinessRuleValidationException("El Estado no puede ser vacio o nulo");
        } else if (value != "Asignado" && value != "Cancelado") {
          throw new BussinessRuleValidationException("El Estado no es valido -> (Asignado,Cancelado)");
        }
        Assert.NotNull(valida3);
        Assert.False(true);
        valida3.Value.Equals(value);
      } catch {
        Assert.False(false);
      }
    }
  }
}
