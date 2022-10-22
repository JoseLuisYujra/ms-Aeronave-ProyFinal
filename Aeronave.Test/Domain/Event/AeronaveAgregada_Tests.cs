using Aeronaves.Aplication.Dto.Aeronave;
using Aeronaves.Aplication.UseCases.Queries.Aeronaves.GetAeronaveById;
using Aeronaves.Domain.Event;
using Aeronaves.Test.Aplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Aeronaves.Test.Domain.Event {
  public class AeronaveAgregada_Tests {

    [Fact]
    public void AeronaveAgregada_CheckPropertiesValid() {

      //Arrange
      var IdAeronaveTest = Guid.NewGuid();
      var CodAeronaveTest = "abc123";  //_aeoronaveService.GenerarIdAeronaveAsync();
      var MarcaTest = "Boeing";
      var ModeloTest = "Boeing 2022";
      var NroAsientosTest = 60;
      decimal CapacidadCargaTest = new(2000.0);
      decimal CapTanqueCombustibleTest = new(3500);
      var AereopuertoEstacionamientoTest = "Aeropuerto Internacional de El Alto";

      var checkAeronaveAgregada = new AeronaveAgregada(IdAeronaveTest, CodAeronaveTest, MarcaTest, ModeloTest, NroAsientosTest, CapacidadCargaTest, CapTanqueCombustibleTest, AereopuertoEstacionamientoTest);


      Assert.IsType<Guid>(checkAeronaveAgregada.IdAeronave);
      Assert.Equal(CodAeronaveTest, checkAeronaveAgregada.CodAeronave);
      Assert.Equal(MarcaTest, checkAeronaveAgregada.Marca);
      Assert.Equal(ModeloTest, checkAeronaveAgregada.Modelo);
      Assert.Equal(NroAsientosTest, checkAeronaveAgregada.NroAsientos);
      Assert.Equal(CapacidadCargaTest, checkAeronaveAgregada.CapacidadCarga);
      Assert.Equal(CapTanqueCombustibleTest, checkAeronaveAgregada.CapTanqueCombustible);
      Assert.Equal(AereopuertoEstacionamientoTest, checkAeronaveAgregada.AereopuertoEstacionamiento);
      /*
      Assert.Empty(checkAeronaveAgregada.EstadoAeronave);
      Assert.NotNull(checkAeronaveAgregada.DetalleAeronaveAsientos);
      */

      Assert.NotNull(checkAeronaveAgregada);
    }

  }
}
