using System.Text.Json;
using UsandoLinq.Modelos;

List<int> NumerosRepetios = new List<int>() { 1, 5, 1, 3, 2, 4, 2, 10, 0, 2, 1, 7 };
var numerosNaoRepetido = NumerosRepetios.GroupBy(i => i).Where(g => g.Count() == 1).Select(g => g.Key);
foreach (var item in numerosNaoRepetido)
{
    Console.WriteLine(item);
}

List<Livro> livros = new List<Livro>();

using(HttpClient client = new HttpClient())
{
	try
	{
        var result = await client.GetStringAsync(@"https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json");
        //Console.WriteLine(result);
        livros = JsonSerializer.Deserialize<List<Livro>>(result);
    }
	catch (Exception ex)
	{
        Console.WriteLine(ex.Message);
	}
}

var livrosPublicadosDepois2000 = livros.Where(l => l.Ano >= 2000).OrderBy(l => l.Titulo).Select(l => l.Titulo).ToList();

if(livrosPublicadosDepois2000.Count > 0)
{
    foreach (var item in livrosPublicadosDepois2000)
    {
        Console.WriteLine($"Livros publicados: {item}");
    }
}
else
{
    Console.WriteLine("Nnão há livros publicados depois de 2000");
}


List<Produto> produtos = new List<Produto>
{
    new Produto( "TV",  10, 5000.00),
    new Produto("Radio", 5, 59.99),
    new Produto("Notebook", 10, 4599.00),
    new Produto("Relógio de Parede", 20, 10.00),
    new Produto("Celular", 30, 3999.90),
    new Produto("SmartWatch", 10, 8000.00)
};

var mediaPreco = produtos.Select(p => p.Preco).Average();

Console.WriteLine("A média dos produtos é: " + mediaPreco);


List<int> ints = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
var numerosPares = ints.Where(i => i % 2 == 0).ToList();
foreach (var item in numerosPares)
{
    Console.WriteLine(item);
}
