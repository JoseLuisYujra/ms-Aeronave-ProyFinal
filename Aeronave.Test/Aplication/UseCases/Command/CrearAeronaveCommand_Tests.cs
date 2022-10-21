using Aeronaves.Aplication.Dto.Aeronave;
using Aeronaves.Aplication.UseCases.Command.Aeronaves.CrearAeronave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeronaves.Test.Aplication.UseCases.Command {
  public class CrearAeronaveCommand_Tests {
    [Fact]
    public void IsRequest_Valid() {

      //Arrange           
      var CodAeronaveTest = "abc123";  //_aeoronaveService.GenerarIdAeronaveAsync();
      var MarcaTest = "Boeing";
      var ModeloTest = "Boeing 2022";
      var NroAsientosTest = 60;
      decimal CapacidadCargaTest = new(2000.0);
      decimal CapTanqueCombustibleTest = new(3500);
      var AereopuertoEstacionamientoTest = "Aeropuerto Internacional de El Alto";


      var aeronaveasientosListTest = MockFactory.GetAeronaveAsientos();
      var command = new CrearAeronaveCommand(CodAeronaveTest, MarcaTest, ModeloTest, NroAsientosTest, CapacidadCargaTest, CapTanqueCombustibleTest, AereopuertoEstacionamientoTest, aeronaveasientosListTest);


      Assert.Equal(CodAeronaveTest, command.CodAeronave);
      Assert.Equal(MarcaTest, command.Marca);
      Assert.Equal(ModeloTest, command.Modelo);
      Assert.Equal(NroAsientosTest, command.NroAsientos);
      Assert.Equal(CapacidadCargaTest, command.CapacidadCarga);
      Assert.Equal(CapTanqueCombustibleTest, command.CapTanqueCombustible);
      Assert.Equal(AereopuertoEstacionamientoTest, command.AereopuertoEstacionamiento);
      Assert.Equal(5, command.DetalleAeronaveAsientos.Count);

    }

    [Fact]
    public void TestConstructor_IsPrivate() {
      var command = (CrearAeronaveCommand)Activator.CreateInstance(typeof(CrearAeronaveCommand), true);

      Assert.Null(command.CodAeronave);
      Assert.Null(command.Marca);
      Assert.Null(command.Modelo);
      Assert.Equal(0, command.NroAsientos);
      Assert.Equal(new decimal(0.0), command.CapacidadCarga);
      Assert.Equal(new decimal(0.0), command.CapTanqueCombustible);
      Assert.Null(command.AereopuertoEstacionamiento);
      Assert.Null(command.DetalleAeronaveAsientos);
    }
  }
}
