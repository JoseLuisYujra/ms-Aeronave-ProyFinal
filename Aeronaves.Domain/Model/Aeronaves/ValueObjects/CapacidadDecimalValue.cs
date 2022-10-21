using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeronaves.Domain.Model.Aeronaves.ValueObjects {
  public record CapacidadDecimalValue {
    public decimal Value { get; init; }

    public CapacidadDecimalValue(decimal value) {
      if (value <= 0) {
        throw new BussinessRuleValidationException("La capacidad no puede ser menor o igual que 0");
      }
      Value = value;
    }

    [ExcludeFromCodeCoverage]
    public static implicit operator decimal(CapacidadDecimalValue value) {
      return value.Value;
    }

    [ExcludeFromCodeCoverage]
    public static implicit operator CapacidadDecimalValue(decimal value) {
      return new CapacidadDecimalValue(value);
    }
  }
}
