using Refit;
using System.Threading.Tasks;

namespace RestApiCsharp
{
    public interface ICepApiServise
    {
        [Get("/ws/{cep}/json/")]
        Task<CepResponse> GetAddressasync(string cep);
    }
}
