using Aeronaves.Domain.Model.Personal;
using Aeronaves.Domain.ValueObjects;
using ShareKernel.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeronaves.Test.Domain.Personal {
  public class Personal_Test {
    private PersonNameValue nombreCompleto = "Jose Yujra";

    [Fact]
    public void Personal_valid() {
      //string var = "Jose Yujra";
      Aeronaves.Domain.Model.Personal.Personal persona = new Aeronaves.Domain.Model.Personal.Personal(nombreCompleto);
      Assert.NotNull(persona);
    }

  }
}
