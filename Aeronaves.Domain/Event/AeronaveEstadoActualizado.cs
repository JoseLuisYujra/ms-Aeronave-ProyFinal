using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareKernel.Core;

namespace Aeronaves.Domain.Event {
  public record AeronaveEstadoActualizado : DomainEvent {
    public Guid IdAeronave { get; }
    public string EstadoAeronave { get; }

    public AeronaveEstadoActualizado(Guid idaeronave, string estadoAeronave) : base(DateTime.Now) {
      IdAeronave = idaeronave;
      EstadoAeronave = estadoAeronave;
    }
  }
}
