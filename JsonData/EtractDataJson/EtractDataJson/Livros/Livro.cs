using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ExtractDataJson.Livros
{
    internal class Livro
    {
        [JsonPropertyName("titulo")]
        public string Titulo { get; set; }

        [JsonPropertyName("autor")]
        public string Autor { get; set; }

        [JsonPropertyName("ano_publicacao")]
        public int AnoDePublicacao { get; set; }
        
        [JsonPropertyName("paginas")]
        public int Paginas { get; set; }
        
        [JsonPropertyName("editora")]
        public string Editora { get; set; }
    }
}
