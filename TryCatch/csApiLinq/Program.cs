//Exercio 1
using csApiLinq.DivisaoTryCatch;
using csApiLinq.ListaTryCatch;
using csApiLinq.ObjetoNuloTryCatch;

using (HttpClient client = new HttpClient())
{
	try
	{
        string resp = await client.GetStringAsync("");
        Console.WriteLine(resp);
    }
	catch (Exception ex)
	{
        Console.WriteLine(ex.Message);
	}
}

//Exercicio 2
Console.Write("\nEscreva o numerador: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Escreva o denominador: ");
int y = int.Parse(Console.ReadLine());
Console.Write($"\nO resultado é {Divisao2Numeros.Dividir(x, y)} ");

//Exercicio 3
Console.Write("\nNumero da lista: " + AcessarListaTryCatch.AcessarInteiro(1));

//Exercicio 4
Console.WriteLine();
try
{
	ObjetoNulo obj;
	obj = null;
	Console.WriteLine(obj.Nome);
}
catch (NullReferenceException ex)
{

    Console.WriteLine(ex.Message);
}