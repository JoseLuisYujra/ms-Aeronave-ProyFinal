using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareKernel.Core;
using Aeronaves.Domain.ValueObjects;
using Aeronaves.Domain.Model.Aeronaves.ValueObjects;
using Aeronaves.Domain.Model.Aeronaves;
using static Aeronaves.Domain.Model.Enum.Enums;

namespace Aeronaves.Domain.Event {
  public record AeronaveAgregada : DomainEvent {

    public Guid IdAeronave { get; }
    public string CodAeronave { get; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int NroAsientos { get; set; }
    public decimal CapacidadCarga { get; set; }
    public decimal CapTanqueCombustible { get; set; }
    public string AereopuertoEstacionamiento { get; set; }
    public string EstadoAeronave { get; set; }
    public List<DetalleAeronaveAsientosAgregado> DetalleAeronaveAsientos { get; init; }

    public record DetalleAeronaveAsientosAgregado(string asientosClases, string asientosUbicacion, int nrosilla, string asientosStatus);
    /*
    public AeronaveAgregada(Guid idaeronave, string marca, string modelo, int nroAsientos, decimal capacidadCarga, decimal capTanqueCombustible,
                            string aereopuertoEstacionamiento, List<DetalleAeronaveAsientosAgregado> detalleAeronaveAsientos) : base(DateTime.Now)
    {
        IdAeronave = idaeronave;            
        Marca = marca;
        Modelo = modelo;
        NroAsientos = nroAsientos;
        CapacidadCarga = capacidadCarga;
        CapTanqueCombustible = capTanqueCombustible;
        AereopuertoEstacionamiento = aereopuertoEstacionamiento;           
        DetalleAeronaveAsientos = detalleAeronaveAsientos;
    }
    */
    public AeronaveAgregada(Guid idAeronave, string codAeronave, string marca, string modelo, int nroAsientos, decimal capacidadCarga, decimal capTanqueCombustible,
                           string aereopuertoEstacionamiento) : base(DateTime.Now) {

      IdAeronave = idAeronave;
      CodAeronave = codAeronave;
      Marca = marca;
      Modelo = modelo;
      NroAsientos = nroAsientos;
      CapacidadCarga = capacidadCarga;
      CapTanqueCombustible = capTanqueCombustible;
      AereopuertoEstacionamiento = aereopuertoEstacionamiento;
    }

  }
}
