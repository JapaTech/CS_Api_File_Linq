// See https://aka.ms/new-console-template for more information

using System.Data;
using System.Text.Json;
using ExtractDataJson.Carros;
using ExtractDataJson.Filmes;
using ExtractDataJson.Got;
using ExtractDataJson.Livros;
using ExtractDataJson.Paises;

using (HttpClient client = new HttpClient())
{
	try
	{
		var resp = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
        //Console.WriteLine(resp);
		var filmes = JsonSerializer.Deserialize<List<Filme>>(resp);
		Console.WriteLine(filmes[0].Titulo);

    }
	catch (Exception ex)
	{

        Console.WriteLine("Erro: " + ex.Message);
	}
}

using (HttpClient client = new HttpClient())
{
	try
	{
		var resp = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
        //Console.WriteLine(resp);
		var paises = JsonSerializer.Deserialize<List<Pais>>(resp);
		Console.WriteLine(paises[0].Nome);
	}
	catch (Exception ex)
	{

        Console.WriteLine(ex.Message);
	}
}

using(HttpClient client = new HttpClient())
{
	var resp = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Carros.json");
    //Console.WriteLine(resp);
	var carros = JsonSerializer.Deserialize<List<Carro>>(resp);
	Console.WriteLine(carros[0].Marca);
}

using(HttpClient client = new HttpClient())
{
	var resp = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json");
    //Console.WriteLine(resp);
	var livros = JsonSerializer.Deserialize<List<Livro>>(resp);
	Console.WriteLine(livros[0].Titulo);
}

using(HttpClient client = new HttpClient())
{
	var resp = await client.GetStringAsync("https://www.anapioficeandfire.com/api/characters/16");
	var personagem = JsonSerializer.Deserialize<Personagem>(resp);
	personagem.ExibirApelidosDaPersonagem();
}