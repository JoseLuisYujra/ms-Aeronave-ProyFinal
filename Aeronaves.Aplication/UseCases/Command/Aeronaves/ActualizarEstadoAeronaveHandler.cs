using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Aeronaves.Domain.Event;
using Aeronaves.Domain.Model.Aeronaves;
using Aeronaves.Domain.Repositories;
using System.Threading;

namespace Aeronaves.Aplication.UseCases.Command.Aeronaves {

  public class ActualizarEstadoAeronaveHandler : INotificationHandler<AeronaveEstadoActualizado> {
    private readonly IAeronaveRepository _IAeronaveRepository;

    public ActualizarEstadoAeronaveHandler(IAeronaveRepository iaeronaveRepository) {
      _IAeronaveRepository = iaeronaveRepository;
    }

    public async Task Handle(AeronaveEstadoActualizado notification, CancellationToken cancellationToken) {
      Aeronave objAeronave = await _IAeronaveRepository.FindByIdAsync(notification.IdAeronave);
      objAeronave.ActualizarEstadoMantenimientoAeronave();

      await _IAeronaveRepository.UpdateAsync(objAeronave);


    }
  }
}
