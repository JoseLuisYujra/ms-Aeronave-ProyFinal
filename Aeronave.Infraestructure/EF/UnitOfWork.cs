using Aeronaves.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using ShareKernel.Core;
using Aeronaves.Infraestructure.EF.Context;

namespace Aeronaves.Infraestructure.EF {

  public class UnitOfWork : IUnitOfWork {
    private readonly WriteDbContext _context;
    private readonly IMediator _mediator;

    public UnitOfWork(WriteDbContext context, IMediator mediator) {
      _context = context;
      _mediator = mediator;
    }

    public async Task Commit() {
      //Publicar eventos de dominio
      var domainEvents = _context.ChangeTracker.Entries<Entity<Guid>>()
          .Select(x => x.Entity.DomainEvents)
          .SelectMany(x => x)
          .ToArray();

      foreach (var @event in domainEvents) {
        await _mediator.Publish(@event);
      }

      await _context.SaveChangesAsync();

    }
  }


}
