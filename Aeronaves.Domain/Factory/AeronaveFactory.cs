
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aeronaves.Domain.Model.Aeronaves;

namespace Aeronaves.Domain.Factory {
  public class AeronaveFactory : IAeronaveFactory {


    public Aeronave Create(string codAeronave, string marca, string modelo, int nroasientos, decimal capacidadcarga, decimal captanquecombustible, string aereopuertoEstacionamiento) {
      return new Aeronave(codAeronave, marca, modelo, nroasientos, capacidadcarga, captanquecombustible, aereopuertoEstacionamiento);
    }



  }
}


