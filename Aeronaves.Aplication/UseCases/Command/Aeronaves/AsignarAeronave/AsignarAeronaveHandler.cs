using Aeronaves.Aplication.Services;
using Aeronaves.Aplication.UseCases.Command.Aeronaves.CrearAeronave;
using Aeronaves.Domain.Factory;
using Aeronaves.Domain.Model.Aeronaves;
using Aeronaves.Domain.Repositories;
using MediatR;
using Microsoft.Extensions.Logging;
using Shared.Rabbitmq.BusRabbit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aeronaves.Aplication.UseCases.Command.Aeronaves.AsignarAeronave {
  public class AsignarAeronaveHandler : IRequestHandler<AsignarAeronaveCommand, Guid> {
    private readonly IAeronaveRepository _aeronaveRepository;
    private readonly ILogger<AsignarAeronaveHandler> _logger;
    private readonly IUnitOfWork _unitOfWork;


    public AsignarAeronaveHandler(IAeronaveRepository aeronaveRepository,
       ILogger<AsignarAeronaveHandler> logger,
       IUnitOfWork unitOfWork
       ) {
      _aeronaveRepository = aeronaveRepository;
      _logger = logger;
      _unitOfWork = unitOfWork;
    }


    public async Task<Guid> Handle(AsignarAeronaveCommand request, CancellationToken cancellationToken) {
      try {
        Aeronave objAeronave = await _aeronaveRepository.FindByIdAsync(request.Id);
        objAeronave.ActualizarEstadoAeronave();
        await _aeronaveRepository.UpdateAsync(objAeronave);
        await _unitOfWork.Commit();
        return objAeronave.Id;
      } catch (Exception ex) {
        _logger.LogError(ex, "Error al Actualizar Estado de Aeronave");
      }
      return Guid.Empty;
    }
  }
}
