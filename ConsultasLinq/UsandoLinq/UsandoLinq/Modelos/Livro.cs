using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace UsandoLinq.Modelos
{
    internal class Livro
    {
        [JsonPropertyName("titulo")]
        public string Titulo { get; set; }
        [JsonPropertyName("autor")]
        public string Autor { get; set; }
        [JsonPropertyName("editora")]
        public string Editora { get; set; }
        [JsonPropertyName("ano_publicacao")]

        public int Ano { get; set; }
    }
}
