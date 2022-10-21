using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeronaves.Aplication.Services {

  public class AeronaveService : IAeoronaveService {
    /*
    private static Random nroramdom = new Random();
    int ranNum = nroramdom.Next(1, 9999);

    public Task<int> GenerarIdAeronaveAsync() => Task.FromResult(ranNum);
    */

    public Task<string> GenerarIdAeronaveAsync() {
      return Task.FromResult(GeneradorCodigo(10));
    }

    public static string GeneradorCodigo(int length) {
      Random random = new Random();
      const string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
      return new string(Enumerable.Repeat(characters, length)
        .Select(s => s[random.Next(s.Length)]).ToArray());
    }

  }
}
