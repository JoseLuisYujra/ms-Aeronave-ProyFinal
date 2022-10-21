using Aeronaves.Aplication.Dto.Aeronave;
using Aeronaves.Domain.Model.Aeronaves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;
using static Aeronaves.Domain.Model.Enum.Enums;

namespace Aeronaves.Test.Aplication.Dto {
  public class AeronaveAsientosDTO_Tests {
    [Fact]
    public void AeronaveAsientosDTO_CheckPropertiesValid() {
      var IdTest = Guid.NewGuid();
      var AeronaveIdTest = Guid.NewGuid();
      var ClaseAsientoTest = "Economica";
      var UbicacionTest = "Centro";
      var NroSillaTest = 1;
      var EstadoAsientoTest = "Libre";

      var objAeronaveAsientos = new AeronaveAsientosDTO();

      Assert.Equal(Guid.Empty, objAeronaveAsientos.Id);
      Assert.Equal(Guid.Empty, objAeronaveAsientos.AeronaveId);
      Assert.Null(objAeronaveAsientos.ClaseAsiento);
      Assert.Null(objAeronaveAsientos.Ubicacion);
      Assert.Equal(0, objAeronaveAsientos.NroSilla);
      Assert.Null(objAeronaveAsientos.EstadoAsiento);

      objAeronaveAsientos.Id = IdTest;
      objAeronaveAsientos.AeronaveId = AeronaveIdTest;
      objAeronaveAsientos.ClaseAsiento = ClaseAsientoTest;
      objAeronaveAsientos.Ubicacion = UbicacionTest;
      objAeronaveAsientos.NroSilla = NroSillaTest;
      objAeronaveAsientos.EstadoAsiento = EstadoAsientoTest;

      Assert.Equal(IdTest, objAeronaveAsientos.Id);
      Assert.Equal(AeronaveIdTest, objAeronaveAsientos.AeronaveId);
      Assert.Equal(ClaseAsientoTest, objAeronaveAsientos.ClaseAsiento);
      Assert.Equal(UbicacionTest, objAeronaveAsientos.Ubicacion);
      Assert.Equal(NroSillaTest, objAeronaveAsientos.NroSilla);
      Assert.Equal(EstadoAsientoTest, objAeronaveAsientos.EstadoAsiento);


    }



  }

}

