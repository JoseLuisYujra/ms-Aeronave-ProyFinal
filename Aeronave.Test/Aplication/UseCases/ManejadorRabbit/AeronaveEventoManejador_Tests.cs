using Aeronaves.Aplication.UseCases.Command.Aeronaves.AsignarAeronave;
using Aeronaves.Aplication.UseCases.ManejadorRabbit;
using Shared.Rabbitmq.EventoQueue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeronaves.Test.Aplication.UseCases.ManejadorRabbit {
  public class AeronaveEventoManejador_Tests {

    [Fact]
    public void AeronaveEventoManejador_Valid() {
      var e = new VueloAsignadoAeronaveQueue(Guid.Empty, Guid.Empty, Guid.Empty);

      e.Id = Guid.Empty;
      e.TripulacionGuid = Guid.Empty;
      e.VueloGuid = Guid.Empty;

      var V = new AeronaveEventoManejador();
      V.Handle(e);

      Assert.NotNull(V);
      Assert.True(V != null);
    }
  }
}
