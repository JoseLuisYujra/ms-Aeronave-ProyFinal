using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareKernel.Core;
using Aeronaves.Domain.Event;
using Aeronaves.Domain.Model.Aeronaves.ValueObjects;
using Aeronaves.Domain.ValueObjects;
using static Aeronaves.Domain.Model.Enum.Enums;

namespace Aeronaves.Domain.Model.Aeronaves {
  public class Aeronave : AggregateRoot<Guid> {

    public string prueba;
    public string pruebaD;
    public CodigoAeronaveValue CodAeronave;
    public string Marca { get; private set; }
    public string Modelo { get; private set; }
    public NroAsientosValue NroAsientos { get; private set; }
    public RegistroDecimalValue CapacidadCarga { get; private set; }
    public RegistroDecimalValue CapTanqueCombustible { get; private set; }
    public string AereopuertoEstacionamiento { get; private set; }
    public string EstadoAeronave { get; private set; } //(Operativo/Mantenimiento/Asignado) 

    //public List<AeronaveAsientos> AsientosAeronave;
    //public ICollection<AeronaveAsientos> AsientosAeronave { get; set; }

    private readonly ICollection<AeronaveAsientos> AsientosAeronave;

    public IReadOnlyCollection<AeronaveAsientos> DetalleAsientos {
      get {
        return new ReadOnlyCollection<AeronaveAsientos>(AsientosAeronave.ToList());
      }
    }


    public Aeronave(string codAeronave, string marca, string modelo, int nroasientos, decimal capacidadcarga, decimal captanquecombustible, string aereopuertoEstacionamiento) {
      Id = Guid.NewGuid();
      CodAeronave = codAeronave;
      Marca = marca;
      Modelo = modelo;
      NroAsientos = nroasientos;
      CapacidadCarga = capacidadcarga;
      CapTanqueCombustible = captanquecombustible;
      AereopuertoEstacionamiento = aereopuertoEstacionamiento;
      EstadoAeronave = "Operativo";
      AsientosAeronave = new List<AeronaveAsientos>();
    }


    public Aeronave() { }

    //uso de DOMAIN EVENT           
    public void ActualizarEstadoAeronave() {
      EstadoAeronave = "Asignado";
    }

    public void ActualizarEstadoMantenimientoAeronave() {
      EstadoAeronave = "Mantenimiento";
    }


    public void AgregarAsiento(Guid aeronaveId, string asientosClases, string asientosUbicacion, int nrosilla, string estadoAsiento) {
      var detalleAsiento = new AeronaveAsientos(aeronaveId, asientosClases, asientosUbicacion, nrosilla, estadoAsiento);
      AsientosAeronave.Add(detalleAsiento);

      AddDomainEvent(new AsientoAgregado(aeronaveId, asientosClases, asientosUbicacion, nrosilla, estadoAsiento));
    }


    public void RegistroAeronave() {

      EstadoAeronave = "Operativo";
      AddDomainEvent(new AeronaveAgregada(Id, CodAeronave, Marca, Modelo, NroAsientos, CapacidadCarga, CapTanqueCombustible, AereopuertoEstacionamiento));
    }

  }
}
