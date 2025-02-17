using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ExtractDataJson.Paises;

internal class Pais
{
    [JsonPropertyName("nome")]
    public string Nome { get; set; }
    
    [JsonPropertyName("capital")]
    public string Capital { get; set; }
    [JsonPropertyName("populacao")]
    public int Populacao { get; set; }
    [JsonPropertyName("continete")]
    public string Continente { get; set; }
    [JsonPropertyName("idioma")]
    public string Idioma { get; set; }
}
