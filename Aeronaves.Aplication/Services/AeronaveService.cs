using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Aeronaves.Aplication.Services {

  public class AeronaveService : IAeoronaveService {

    public Task<string> GenerarIdAeronaveAsync() {
      return Task.FromResult(GeneradorCodigo(10));
    }

    [ExcludeFromCodeCoverage]
    public static string GeneradorCodigo(int length) {

      Random random = new Random();
      const string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
      return new string(Enumerable.Repeat(characters, length)
        .Select(s => s[random.Next(s.Length)]).ToArray());

    }
  }
}
