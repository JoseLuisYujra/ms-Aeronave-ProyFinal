using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Aeronaves.Domain.Model.Enum.Enums;

namespace Aeronaves.Domain.Model.Aeronaves {
  public class AeronaveAsientos : Entity<Guid> {
    //public Guid Id { get; private set; }
    public Guid AeronaveId { get; private set; }
    public string ClaseAsiento { get; private set; } //(Economica(20)/Ejecutiva(10)) -> enum
    public string Ubicacion { get; private set; }    //(Ventana,Central,Pasillo)  -> enum
    public int NroSilla { get; private set; }
    public string EstadoAsiento { get; private set; }  //(Reservado/Libre)

    public AeronaveAsientos() { }

    public AeronaveAsientos(Guid aeronaveId, string asientosClases, string asientosUbicacion, int nrosilla, string estadoAsiento) {
      Id = Guid.NewGuid();
      AeronaveId = aeronaveId;
      ClaseAsiento = asientosClases;
      Ubicacion = asientosUbicacion;
      NroSilla = nrosilla;
      EstadoAsiento = estadoAsiento;
    }

    [ExcludeFromCodeCoverage]
    public void ModificarAeronaveAsientos(string asientosClases, string asientosUbicacion, int nrosilla, string estadoAsiento) {
      ClaseAsiento = asientosClases;
      Ubicacion = asientosUbicacion;
      NroSilla = nrosilla;
      EstadoAsiento = estadoAsiento;
    }
  }
}
