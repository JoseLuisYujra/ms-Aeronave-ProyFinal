using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Aeronaves.Domain.Model.Enum.Enums;

namespace Aeronaves.Domain.Event {
  public record AsientoAgregado : DomainEvent {
    public Guid AeronaveId { get; private set; }
    public string ClaseAsiento { get; private set; }
    public string Ubicacion { get; private set; }
    public int NroSilla { get; private set; }
    public string EstadoAsiento { get; private set; }

    public AsientoAgregado(Guid aeronaveId, string asientosClases, string asientosUbicacion, int nrosilla, string estadoAsiento) : base(DateTime.Now) {
      AeronaveId = aeronaveId;
      ClaseAsiento = asientosClases;
      Ubicacion = asientosUbicacion;
      NroSilla = nrosilla;
      EstadoAsiento = estadoAsiento;
    }
  }
}

