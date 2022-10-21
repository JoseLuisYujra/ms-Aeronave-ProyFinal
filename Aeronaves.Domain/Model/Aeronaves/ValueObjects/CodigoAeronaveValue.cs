using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeronaves.Domain.Model.Aeronaves.ValueObjects {

  public record CodigoAeronaveValue : ValueObject {
    public string Value { get; }

    public CodigoAeronaveValue(string value) {
      CheckRule(new ShareKernel.Rules.StringNotNullOrEmptyRule(value));
      //TODO: validar el formato del codigo de reserva
      Value = value;
    }


    public static implicit operator string(CodigoAeronaveValue value) {
      return value.Value;
    }

    public static implicit operator CodigoAeronaveValue(string value) {
      return new CodigoAeronaveValue(value);
    }



  }


}
