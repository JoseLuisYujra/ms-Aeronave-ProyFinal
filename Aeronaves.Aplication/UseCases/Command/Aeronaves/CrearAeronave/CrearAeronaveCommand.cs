using Aeronaves.Aplication.Dto.Aeronave;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeronaves.Aplication.UseCases.Command.Aeronaves.CrearAeronave {
  public class CrearAeronaveCommand : IRequest<Guid> {

    public string CodAeronave { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int NroAsientos { get; set; }
    public decimal CapacidadCarga { get; set; }
    public decimal CapTanqueCombustible { get; set; }
    public string AereopuertoEstacionamiento { get; set; }
    public List<AeronaveAsientosDTO> DetalleAeronaveAsientos { get; set; }

    public CrearAeronaveCommand(string codAeronave, string marca, string modelo, int nroasientos, decimal capacidadcarga, decimal captanquecombustible, string aereopuertoEstacionamiento, List<AeronaveAsientosDTO> detalleAeronaveAsientos) {
      CodAeronave = codAeronave;
      Marca = marca;
      Modelo = modelo;
      NroAsientos = nroasientos;
      CapacidadCarga = capacidadcarga;
      CapTanqueCombustible = captanquecombustible;
      AereopuertoEstacionamiento = aereopuertoEstacionamiento;
      DetalleAeronaveAsientos = detalleAeronaveAsientos;
    }

    public CrearAeronaveCommand() { }

  }
}
