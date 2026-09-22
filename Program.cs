using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsumerCatFactApi
{
    internal class Program
    {
        private const string EndpointUrl = "https://catfact.ninja/fact";

        private static async Task Main(string[] args)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    // Requisição GET ao endpoint da API de fatos sobre gatos
                    HttpResponseMessage response = await httpClient.GetAsync(EndpointUrl);
                    response.EnsureSuccessStatusCode();

                    string jsonResponse = await response.Content.ReadAsStringAsync();

                    // Desserializa o JSON retornado para o objeto CatFact
                    CatFact? catFact = JsonSerializer.Deserialize<CatFact>(jsonResponse);

                    if (catFact is not null)
                    {
                        Console.WriteLine("Fato sobre Gatos:");
                        Console.WriteLine();
                        Console.WriteLine(catFact.Fact);
                    }
                    else
                    {
                        Console.WriteLine("Não foi possível interpretar a resposta da API.");
                    }
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine($"Erro ao consumir a API: {ex.Message}");
                }
                catch (JsonException ex)
                {
                    Console.WriteLine($"Erro ao converter o JSON retornado: {ex.Message}");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
