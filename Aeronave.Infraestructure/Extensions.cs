using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Aeronaves.Domain.Repositories;
using Aeronaves.Infraestructure.EF;
using Aeronaves.Aplication;
using Aeronaves.Infraestructure.EF.Repository;
using Aeronaves.Infraestructure.MemoryRepository;
using MediatR;
using Aeronaves.Infraestructure.EF.Context;

namespace Aeronaves.Infraestructure {
  public static class Extensions {

    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration) {

      services.AddApplication();
      services.AddMediatR(Assembly.GetExecutingAssembly());

      var connectionString = configuration.GetConnectionString("AeronaveDbConnectionString");

      services.AddDbContext<ReadDbContext>(context => context.UseSqlServer(connectionString));
      services.AddDbContext<WriteDbContext>(context => context.UseSqlServer(connectionString));

      services.AddScoped<IAeronaveRepository, AeronaveRepository>();
      services.AddScoped<IUnitOfWork, UnitOfWork>();

      return services;
    }

  }
}
