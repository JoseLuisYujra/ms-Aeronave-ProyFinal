using MediatR;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Threading;
using System.Threading.Tasks;
using Aeronaves.Domain.Repositories;
using Aeronaves.Aplication.Services;
using Aeronaves.Domain.Factory;
using Aeronaves.Domain.Model.Aeronaves;
using Shared.Rabbitmq.BusRabbit;
using Shared.Rabbitmq.EventoQueue;

namespace Aeronaves.Aplication.UseCases.Command.Aeronaves.CrearAeronave {
  public class CrearAeronaveHandler : IRequestHandler<CrearAeronaveCommand, Guid> {

    private readonly IAeronaveRepository _aeronaveRepository;
    private readonly ILogger<CrearAeronaveHandler> _logger;
    private readonly IAeoronaveService _aeoronaveService;
    private readonly IAeronaveFactory _aeronaveFactory;
    private readonly IUnitOfWork _unitOfWork;

    /// <summary>
    /// Se implementa EventBus de RabbitMQ
    /// </summary>
    /// <param name="eventBus"></param>
    //private readonly IRabbitEventBus _eventBus;

    public CrearAeronaveHandler(IAeronaveRepository aeronaveRepository,
        ILogger<CrearAeronaveHandler> logger,
        IAeoronaveService aeoronaveService,
        IAeronaveFactory aeronaveFactory,
        IUnitOfWork unitOfWork
        //IRabbitEventBus eventBus
        ) {
      _aeronaveRepository = aeronaveRepository;
      _logger = logger;
      _aeoronaveService = aeoronaveService;
      _aeronaveFactory = aeronaveFactory;
      _unitOfWork = unitOfWork;
      //_eventBus = eventBus;
    }

    public async Task<Guid> Handle(CrearAeronaveCommand request, CancellationToken cancellationToken) {
      try {
        string codigoAeronave = await _aeoronaveService.GenerarIdAeronaveAsync();
        string _estadoASiento = "Libre";
        Aeronave objaeronave = _aeronaveFactory.Create(codigoAeronave, request.Marca, request.Modelo, request.NroAsientos, request.CapacidadCarga, request.CapTanqueCombustible, request.AereopuertoEstacionamiento);

        if (request.DetalleAeronaveAsientos != null) {
          foreach (var item in request.DetalleAeronaveAsientos) {
            objaeronave.AgregarAsiento(item.AeronaveId, item.ClaseAsiento, item.Ubicacion, item.NroSilla, _estadoASiento);
          }
        }

        objaeronave.RegistroAeronave();
        await _aeronaveRepository.CreateAsync(objaeronave);
        await _unitOfWork.Commit();

        //Publicando RabbitMQ            
        //_eventBus.Publish(new AeronaveAgregadaEventoQueue(objaeronave.Id, request.Marca, request.Modelo, request.NroAsientos, objaeronave.EstadoAeronave, "Se Creo la Aeronave y se notifica al bus de eventos"));

        return objaeronave.Id;
      } catch (Exception ex) {
        _logger.LogError(ex, "Error al crear Aeronave");
      }
      return Guid.Empty;
    }
  }
}
