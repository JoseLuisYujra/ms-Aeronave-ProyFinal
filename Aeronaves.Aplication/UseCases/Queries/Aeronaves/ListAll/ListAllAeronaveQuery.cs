using Aeronaves.Aplication.Dto.Aeronave;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeronaves.Aplication.UseCases.Queries.Aeronaves.ListAll {
  public class ListAllAeronaveQuery : IRequest<List<AeronaveDTO>> {
    public ListAllAeronaveQuery() { }
  }

}
