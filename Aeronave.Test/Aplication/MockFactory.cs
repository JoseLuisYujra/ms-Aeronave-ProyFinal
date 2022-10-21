using Aeronaves.Aplication.Dto.Aeronave;
using Aeronaves.Domain.Model.Aeronaves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Aeronaves.Domain.Model.Enum.Enums;

namespace Aeronaves.Test.Aplication {
  public class MockFactory {
    public static List<AeronaveAsientosDTO> GetAeronaveAsientos() {

      return new List<AeronaveAsientosDTO>()
      {
                new()
                {
                    Id = Guid.NewGuid(),
                    AeronaveId = Guid.NewGuid(),
                    ClaseAsiento = "Economica",
                    Ubicacion = "Ventana",
                    NroSilla = 1,
                    EstadoAsiento = "Libre"
                },

                new()
                {
                    Id = Guid.NewGuid(),
                    AeronaveId = Guid.NewGuid(),
                    ClaseAsiento = "Economica",
                    Ubicacion = "Centro",
                    NroSilla = 2,
                    EstadoAsiento = "Libre"
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    AeronaveId = Guid.NewGuid(),
                    ClaseAsiento = "Economica",
                    Ubicacion = "Pasillo",
                    NroSilla = 3,
                    EstadoAsiento = "Libre"
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    AeronaveId = Guid.NewGuid(),
                    ClaseAsiento = "Economica",
                    Ubicacion = "Ventana",
                    NroSilla = 4,
                    EstadoAsiento = "Libre"
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    AeronaveId = Guid.NewGuid(),
                    ClaseAsiento = "Economica",
                    Ubicacion = "Centro",
                    NroSilla = 5,
                    EstadoAsiento = "Libre"
                }
            };
    }

  }
}
