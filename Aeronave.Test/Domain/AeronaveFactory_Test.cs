using Aeronaves.Domain.Factory;
using Aeronaves.Domain.Model.Aeronaves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeronaves.Test.Domain {
  public class AeronaveFactory_Test {
    [Fact]
    public void Create_Correctly() {
      string codAeronaveTest = "ABC123";
      string marcaTest = "Boeing";
      string modeloTest = "Boeing-2022";
      int nroasientosTest = 60;
      decimal capacidadcargaTest = 1000;
      decimal captanquecombustibleTest = 3000;
      string aereopuertoEstacionamientoTest = "Aeropuerto Internacional de El Alto";

      var factory = new AeronaveFactory();
      var aeronave = factory.Create(codAeronaveTest, marcaTest, modeloTest, nroasientosTest, capacidadcargaTest, captanquecombustibleTest, aereopuertoEstacionamientoTest);

      Assert.NotNull(aeronave);
      Assert.Equal(codAeronaveTest, aeronave.CodAeronave);
      Assert.Equal(marcaTest, aeronave.Marca);
      Assert.Equal(modeloTest, aeronave.Modelo);
      Assert.Equal(nroasientosTest, (int)aeronave.NroAsientos);
      Assert.Equal(capacidadcargaTest, (decimal)aeronave.CapacidadCarga);
      Assert.Equal(captanquecombustibleTest, (decimal)aeronave.CapTanqueCombustible);
      Assert.Equal(aereopuertoEstacionamientoTest, aeronave.AereopuertoEstacionamiento);
    }

  }
}
