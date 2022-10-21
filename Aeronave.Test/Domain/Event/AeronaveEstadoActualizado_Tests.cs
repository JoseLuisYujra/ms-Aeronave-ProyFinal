using Aeronaves.Domain.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeronaves.Test.Domain.Event {
  public class AeronaveEstadoActualizado_Tests {

    [Fact]
    public void AeronaveEstadoActualizado_ExpectInstantiation() {

      //Arrange            
      var IdAeronave = Guid.NewGuid();
      var EstadoAeronave = "Libre";

      var checkAeronaveEstadoActualizado = new AeronaveEstadoActualizado(IdAeronave, EstadoAeronave);

      Assert.IsType<Guid>(checkAeronaveEstadoActualizado.IdAeronave);
      Assert.NotNull(checkAeronaveEstadoActualizado.EstadoAeronave);
      Assert.NotNull(checkAeronaveEstadoActualizado);


    }
  }
}
