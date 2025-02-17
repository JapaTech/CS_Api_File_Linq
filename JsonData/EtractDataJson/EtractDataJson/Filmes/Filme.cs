using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ExtractDataJson.Filmes
{
    internal class Filme
    {
        [JsonPropertyName("rank")]
        public string Rank { get; set; }
        [JsonPropertyName("title")]
        public string Titulo { get; set; }
        [JsonPropertyName("fullTitle")]
        public string TituloCompleto { get; set; }
        [JsonPropertyName("year")]
        public string Ano { get; set; }
        [JsonPropertyName("image")]
        public string Imagem { get; set; }
        [JsonPropertyName("crew")]
        public string Elenco { get; set; }
        [JsonPropertyName("imDbRating")]
        public string NotaIMDB { get; set; }
        [JsonPropertyName("imDbRatingCount")]
        public string QuantidadeAvaliacoes { get; set; }


    }
}
