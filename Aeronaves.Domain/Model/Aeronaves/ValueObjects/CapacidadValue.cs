using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareKernel.Core;
using ShareKernel.Rules;

namespace Aeronaves.Domain.ValueObjects {

  public record CapacidadValue : ValueObject {
    public int Value { get; init; }

    public CapacidadValue(int value) {
      if (value <= 0) {
        throw new BussinessRuleValidationException("La cantidad de pasajeros no puede ser negativa o cero");
      }
      //Aeronave Comercial  Aeronave Comercial   Clase Ejecutiva = 30 Clase Economica = 100
      //Control a nivel general del ejemplo 30 + 100 =  130
      else if (value > 150) {
        throw new BussinessRuleValidationException("La cantidad de pasajeros no puede sobrepasar el limite");
      }

      Value = value;
    }

    [ExcludeFromCodeCoverage]
    public static implicit operator int(CapacidadValue value) {
      return value.Value;
    }

    [ExcludeFromCodeCoverage]
    public static implicit operator CapacidadValue(int value) {
      return new CapacidadValue(value);
    }
  }
}
