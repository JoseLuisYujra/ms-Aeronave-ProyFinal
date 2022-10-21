using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareKernel.Core;


namespace Aeronaves.Domain.Model.Aeronaves.ValueObjects {
  public record AeronaveEstados : ValueObject {
    public string Value { get; }
    public AeronaveEstados(string value) {
      if (value is null) {
        throw new BussinessRuleValidationException("El Estado no puede ser vacio o nulo");
      } else if (value != "Operativo" && value != "Mantenimiento" && value != "Asignado") {
        throw new BussinessRuleValidationException("El Estado no es valido -> (Operativo,Mantenimiento,Asignado)");
      }
      Value = value;
    }

    [ExcludeFromCodeCoverage]
    public static implicit operator string(AeronaveEstados value) {
      return value.Value;
    }

    [ExcludeFromCodeCoverage]
    public static implicit operator AeronaveEstados(string value) {
      return new AeronaveEstados(value);
    }
  }
}
