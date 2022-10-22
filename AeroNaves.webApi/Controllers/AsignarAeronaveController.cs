using Aeronaves.Aplication.UseCases.Command.Aeronaves.AsignarAeronave;
using Aeronaves.Aplication.UseCases.Command.Aeronaves.CrearAeronave;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace AeroNaves.webApi.Controllers {

  [Route("api/[controller]")]
  [ApiController]
  public class AsignarAeronaveController : ControllerBase {

    private readonly IMediator _mediator;
    public AsignarAeronaveController(IMediator mediator) {
      _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> AsignarAeronave([FromBody] AsignarAeronaveCommand command) {
      Guid id = await _mediator.Send(command);

      if (id == Guid.Empty)
        return BadRequest();

      return Ok(id);
    }

  }
}
