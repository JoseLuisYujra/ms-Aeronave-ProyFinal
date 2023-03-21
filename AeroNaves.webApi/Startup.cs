using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aeronaves.Aplication;
using Aeronaves.Infraestructure;
using Shared.Rabbitmq.BusRabbit;
using Shared.Rabbitmq.EventoQueue;
using Aeronaves.Aplication.UseCases.ManejadorRabbit;
using Shared.Rabbitmq.Implement;
using System.Diagnostics.CodeAnalysis;

namespace AeroNaves.webApi {

  [ExcludeFromCodeCoverage]
  public class Startup {
    public Startup(IConfiguration configuration) {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }


    public void ConfigureServices(IServiceCollection services) {

      ///<Sumary>
      ///Se invoca a AddInfrastructure que contiene las configuracions, conexion DB, RabbitMQ          
      ///<Sumary>
      services.AddInfrastructure(Configuration);

      services.AddControllers();
      services.AddSwaggerGen(c => {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "AeroNaves.webApi", Version = "v1" });
      });
    }


    public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {


      app.UseSwagger();
      app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "AeroNaves.webApi v1"));


      app.UseHttpsRedirection();

      app.UseRouting();

      app.UseAuthorization();

      app.UseEndpoints(endpoints => {
        endpoints.MapControllers();
      });

      ///<Sumary>
      ///Se invoca al Consumer de RabbitMQ cliente            
      ///<Sumary>
      //app.RabbitMQConsumer();

    }
  }
}
