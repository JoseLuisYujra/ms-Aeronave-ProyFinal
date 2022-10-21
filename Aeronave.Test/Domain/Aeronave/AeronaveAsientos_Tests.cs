using Aeronaves.Aplication.Dto.Aeronave;
using Aeronaves.Domain.Model.Aeronaves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Aeronaves.Test.Domain.Aeronave {
  public class AeronaveAsientos_Tests {

    [Fact]
    public void AeronaveAsientos_CheckPropertiesValid() {
      var IdTest = Guid.NewGuid();
      var AeronaveIdTest = Guid.NewGuid();
      var ClaseAsientoTest = "Economica";
      var UbicacionTest = "Centro";
      var NroSillaTest = 1;

      var objAeronaveAsientos = new AeronaveAsientos();

      Assert.NotNull(objAeronaveAsientos);
    }

    [Fact]
    public void AeronaveAsientos_CheckModify() {
      var AeronaveIdTest = Guid.NewGuid();
      var ClaseAsientoTest = "Economica";
      var UbicacionTest = "Centro";
      var NroSillaTest = 1;
      var EstadoAsientoTest = "Libre";
      var objAeronaveAsientos = new AeronaveAsientos(AeronaveIdTest, ClaseAsientoTest, UbicacionTest, NroSillaTest, EstadoAsientoTest);

      //Assert.Equal(Guid.Empty, objAeronaveAsientos.Id);
      //Assert.Equal(Guid.Empty, objAeronaveAsientos.AeronaveId);
      Assert.NotNull(objAeronaveAsientos.ClaseAsiento);
      Assert.NotNull(objAeronaveAsientos.Ubicacion);
      Assert.IsType<int>(objAeronaveAsientos.NroSilla);
      Assert.NotNull(objAeronaveAsientos.EstadoAsiento);

      objAeronaveAsientos.ModificarAeronaveAsientos(ClaseAsientoTest, UbicacionTest, NroSillaTest, EstadoAsientoTest);

      Assert.IsType<Guid>(objAeronaveAsientos.Id);
      Assert.Equal(AeronaveIdTest, objAeronaveAsientos.AeronaveId);
      Assert.Equal(ClaseAsientoTest, objAeronaveAsientos.ClaseAsiento);
      Assert.Equal(UbicacionTest, objAeronaveAsientos.Ubicacion);
      Assert.Equal(NroSillaTest, objAeronaveAsientos.NroSilla);
      Assert.Equal(EstadoAsientoTest, objAeronaveAsientos.EstadoAsiento);

    }
  }
}
