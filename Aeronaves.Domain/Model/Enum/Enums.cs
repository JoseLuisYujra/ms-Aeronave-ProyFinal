using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeronaves.Domain.Model.Enum {
  public class Enums {
    public enum AeronaveStatus {
      Operativo,
      Mantenimiento,
      Asignado
    }

    public enum AsientosClases {
      Economica,
      PrimeraClase,
      Ejecutiva
    }

    public enum AsientosUbicacion {
      Ventana,
      Central,
      Pasillo
    }

    public enum AsientosStatus {
      Reservado,
      Libre
    }
  }
}
