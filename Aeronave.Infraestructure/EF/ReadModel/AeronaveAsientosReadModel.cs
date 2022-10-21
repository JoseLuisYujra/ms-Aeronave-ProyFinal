using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeronaves.Infraestructure.EF.ReadModel {
  public class AeronaveAsientosReadModel {
    public Guid Id { get; set; }
    public Guid AeronaveId { get; set; }
    public string ClaseAsiento { get; set; }
    public string Ubicacion { get; set; }
    public int NroSilla { get; set; }
    public string EstadoAsiento { get; set; }

    public AeronaveReadModel Aeronave { get; set; }
  }
}
