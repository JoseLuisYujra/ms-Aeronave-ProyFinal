using Aeronaves.Aplication.Dto.Aeronave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeronaves.Infraestructure.EF.ReadModel {
  public class AeronaveReadModel {
    public Guid Id { get; set; }
    public string CodAeronave { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int NroAsientos { get; set; }
    public decimal CapacidadCarga { get; set; }
    public decimal CapTanqueCombustible { get; set; }
    public string AereopuertoEstacionamiento { get; set; }
    public string EstadoAeronave { get; set; }

    public List<AeronaveAsientosReadModel> AsientosAeronave { get; set; }

  }
}
