using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Shared.Rabbitmq.BusRabbit;
using Shared.Rabbitmq.EventoQueue;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Aeronaves.Aplication.UseCases.ManejadorRabbit {

  public class AeronaveEventoManejador : IEventoManejador<VueloAsignadoAeronaveQueue> {
    /// <summary>
    /// Clase para el CONSUMIDOR uso de RabbitMQ
    /// </summary>                     
    public Task Handle(VueloAsignadoAeronaveQueue @evento) {

      //var url = "https://aeronave.azurewebsites.net/api/AsignarAeronave";          
      var url = "https://localhost:44384/api/AsignarAeronave";
      //var url = "https://localhost:5001/api/AsignarAeronave";
      var request = (HttpWebRequest)WebRequest.Create(url);
      request.Accept = "application/json";
      request.ContentType = "application/json";
      request.Method = "POST";
      request.Timeout = 300000;
      var json = JsonConvert.SerializeObject(evento);

      ASCIIEncoding encoding = new ASCIIEncoding();
      Byte[] bytes = encoding.GetBytes(json);

      Stream newStream = request.GetRequestStream();
      newStream.Write(bytes, 0, bytes.Length);
      newStream.Close();

      // Invocación del servicio y respuesta
      try {
        var response = request.GetResponse();
      } catch (Exception ex) { }

      return Task.CompletedTask;

    }
  }
}
