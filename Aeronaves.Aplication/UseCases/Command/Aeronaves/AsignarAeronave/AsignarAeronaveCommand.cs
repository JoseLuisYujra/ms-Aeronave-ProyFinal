using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeronaves.Aplication.UseCases.Command.Aeronaves.AsignarAeronave {
  public class AsignarAeronaveCommand : IRequest<Guid> {
    public Guid Id { get; set; }

    public AsignarAeronaveCommand(Guid id) {
      Id = id;
    }
  }
}
