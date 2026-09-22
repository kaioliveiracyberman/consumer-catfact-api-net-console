using System.Text.Json.Serialization;

namespace ConsumerCatFactApi
{
    // Classe que representa o objeto JSON retornado pelo endpoint https://catfact.ninja/fact
    // {
    //     "fact": "Many cats cannot properly digest cow's milk...",
    //     "length": 87
    // }
    public class CatFact
    {
        [JsonPropertyName("fact")]
        public string Fact { get; set; } = string.Empty;

        [JsonPropertyName("length")]
        public int Length { get; set; }
    }
}
