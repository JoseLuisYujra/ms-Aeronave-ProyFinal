using Aeronaves.Aplication.Dto.Aeronave;
using Aeronaves.Aplication.Services;
using Aeronaves.Domain.Model.Aeronaves;
using Aeronaves.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeronaves.Test.Aplication.Dto {
  public class AeronaveDto_Tests {

    /*
    private readonly IAeoronaveService _aeoronaveService;
    public AeronaveDto_Tests(IAeoronaveService aeoronaveService)
    {
        _aeoronaveService = aeoronaveService;
    }
    */

    [Fact]
    public void AeronaveDTo_CheckPropertiesValid() {
      //Arrange
      var IdTest = Guid.NewGuid();
      var CodAeronaveTest = "abc123";  //_aeoronaveService.GenerarIdAeronaveAsync();
      var MarcaTest = "Boeing";
      var ModeloTest = "Boeing 2022";
      var NroAsientosTest = 60;
      decimal CapacidadCargaTest = new(2000.0);
      decimal CapTanqueCombustibleTest = new(3500);
      var AereopuertoEstacionamientoTest = "Aeropuerto Internacional de El Alto";
      var EstadoAeronavTeste = "Operativo";
      var AsientosAeronaveTests = MockFactory.GetAeronaveAsientos();

      var objAeronave = new AeronaveDTO();

      //Act

      //Assert
      Assert.Equal(Guid.Empty, objAeronave.Id);
      Assert.Null(objAeronave.CodAeronave);
      Assert.Null(objAeronave.Marca);
      Assert.Null(objAeronave.Modelo);
      Assert.Equal(0, objAeronave.NroAsientos);
      Assert.Equal(new decimal(0.0), objAeronave.CapacidadCarga);
      Assert.Equal(new decimal(0.0), objAeronave.CapTanqueCombustible);
      Assert.Null(objAeronave.AereopuertoEstacionamiento);
      Assert.Null(objAeronave.EstadoAeronave);
      Assert.Empty(objAeronave.AsientosAeronave);

      objAeronave.Id = IdTest;
      objAeronave.CodAeronave = CodAeronaveTest;
      objAeronave.Marca = MarcaTest;
      objAeronave.Modelo = ModeloTest;
      objAeronave.NroAsientos = NroAsientosTest;
      objAeronave.CapacidadCarga = CapacidadCargaTest;
      objAeronave.CapTanqueCombustible = CapTanqueCombustibleTest;
      objAeronave.AereopuertoEstacionamiento = AereopuertoEstacionamientoTest;
      objAeronave.EstadoAeronave = EstadoAeronavTeste;
      objAeronave.AsientosAeronave = AsientosAeronaveTests;


      Assert.Equal(IdTest, objAeronave.Id);
      Assert.Equal(CodAeronaveTest, objAeronave.CodAeronave);
      Assert.Equal(MarcaTest, objAeronave.Marca);
      Assert.Equal(ModeloTest, objAeronave.Modelo);
      Assert.Equal(NroAsientosTest, objAeronave.NroAsientos);
      Assert.Equal(CapacidadCargaTest, objAeronave.CapacidadCarga);
      Assert.Equal(CapTanqueCombustibleTest, objAeronave.CapTanqueCombustible);
      Assert.Equal(AereopuertoEstacionamientoTest, objAeronave.AereopuertoEstacionamiento);
      Assert.Equal(EstadoAeronavTeste, objAeronave.EstadoAeronave);
      Assert.Equal(AsientosAeronaveTests.Count, objAeronave.AsientosAeronave.Count);

    }


  }
}

