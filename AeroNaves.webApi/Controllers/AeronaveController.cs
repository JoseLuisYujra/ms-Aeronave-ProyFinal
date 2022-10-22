using MediatR;
using Microsoft.AspNetCore.Mvc;
using Aeronaves.Aplication.Dto.Aeronave;
using Aeronaves.Aplication.UseCases.Command.Aeronaves;
using Aeronaves.Aplication.UseCases.Queries.Aeronaves.GetAeronaveById;
using System;
using System.Threading.Tasks;
using Aeronaves.Aplication.UseCases.Queries.Aeronaves.SearchAeronave;
using Aeronaves.Aplication.UseCases.Command.Aeronaves.CrearAeronave;
using System.Collections.Generic;
using Aeronaves.Aplication.UseCases.Queries.Aeronaves.ListAll;

namespace AeroNaves.webApi.Controllers {
  [ApiController]
  [Route("/api/[controller]")]
  public class AeronaveController : ControllerBase {
    private readonly IMediator _mediator;

    public AeronaveController(IMediator mediator) {
      _mediator = mediator;
    }

    [Route("crear")]
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CrearAeronaveCommand command) {
      Guid id = await _mediator.Send(command);

      if (id == Guid.Empty)
        return BadRequest();

      return Ok(id);
    }

    [Route("{id:guid}")]
    [HttpGet]
    public async Task<IActionResult> GetAeronave([FromRoute] GetAeronaveByIdQuery command) {
      AeronaveDTO result = await _mediator.Send(command);

      if (result == null)
        return NotFound();

      return Ok(result);
    }

    [Route("search")]
    [HttpPost]
    public async Task<IActionResult> Search([FromBody] SearchAeronaveQuery query) {
      var aeronaves = await _mediator.Send(query);

      if (aeronaves == null)
        return BadRequest();

      return Ok(aeronaves);
    }

    [Route("getall")]
    [HttpGet]
    public async Task<IActionResult> GetAll([FromRoute] ListAllAeronaveQuery command) {
      List<AeronaveDTO> result = await _mediator.Send(command);
      if (result == null)
        return NotFound();

      return Ok(result);
    }


  }
}
