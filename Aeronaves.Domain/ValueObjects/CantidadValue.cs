
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareKernel.Core;

namespace Aeronaves.Domain.ValueObjects {
  public record CantidadValue : ValueObject {
    public int Value { get; }
    public CantidadValue(int value) {
      if (value <= 0) {
        throw new BussinessRuleValidationException("La cantidad no puede ser negativa o cero");
      }
      Value = value;
    }

    [ExcludeFromCodeCoverage]
    public static implicit operator int(CantidadValue value) {
      return value.Value;
    }

    [ExcludeFromCodeCoverage]
    public static implicit operator CantidadValue(int value) {
      return new CantidadValue(value);
    }
  }
}
