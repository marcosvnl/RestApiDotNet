using Refit;
using System;
using System.Threading.Tasks;

namespace RestApiCsharp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                var cepClient = RestService.For<ICepApiServise>("https://viacep.com.br/");
                Console.WriteLine("Informe o  seu cep: ");
                string cepInformado = Console.ReadLine().ToString();
                Console.WriteLine($"Consultando informações do cep: {cepInformado}");
                var address = await cepClient.GetAddressasync(cepInformado);

                Console.WriteLine($"Rua: {address.Logradouro}");
                Console.WriteLine($"Complemento: {address.Complemento}");
                Console.WriteLine($"Bairro: {address.Bairro}");
                Console.WriteLine($"Cidade: {address.Localidade}");
                Console.WriteLine($"Estado: {address.Uf}");

                Console.ReadKey();
            }
            catch (Exception e)
            {

                Console.WriteLine("Erro na leitura do cep" + e.Message);
            }
        }
    }
}
