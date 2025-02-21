using System.Security.AccessControl;
using System.Text.Json;
using ManipulacaoArquivo.Modelos;

string caminhoArquivo = @"C:\Users\Jonathan\Desktop";

List<Pessoa> pessoas = new List<Pessoa>() 
{ 
    new Pessoa("Luis Carlos", "luis@gmail.com", 20),
    new Pessoa("Amanda Paes", "amanda@gmail.com", 20),
    new Pessoa("Carlos Lacerda", "carlosLacerda@gmail.com", 35),
    new Pessoa("Pedro Miguel", "pedroMiguel@gmail.com", 18),
    new Pessoa("Samira Santa", "samira@gmail.com", 52),
};

void CriarArquivo<T>(List<T> dados, string nomeArquivo)
{
    try
    {
        string pathSalvamento = Path.Combine(caminhoArquivo, nomeArquivo);

        using (StreamWriter writer = new StreamWriter(pathSalvamento))
        {
            JsonSerializer.Serialize(writer.BaseStream, pessoas);
        }
        Console.Clear();
        Console.WriteLine("Arquivo Json Gerado com sucesso");
        Console.WriteLine("\nPressione algo para continuar");
        Console.ReadKey();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }   
}

void LerArquivo<T>(string nomeArquivo)
{
    Console.Clear();
    try
    {
        using (FileStream stream = File.OpenRead(Path.Combine(caminhoArquivo, nomeArquivo).ToString()))
        {
            var lista = JsonSerializer.Deserialize<List<T>>(stream);

            foreach (var item in lista)
            {
                Console.WriteLine(item.ToString());
            }
           
            Console.WriteLine("Arquivo Json lido com sucesso");
            Console.WriteLine("\nPressione algo para continuar");
            Console.ReadKey();
        }
    }
    catch (Exception ex)
    {

        Console.WriteLine(ex.Message);
    }
}

void MenuPessoa()
{
    List<Pessoa> pessoasCadastradas = new List<Pessoa>();

    Console.Clear();
    Console.WriteLine("Digite 1 para inserir uma pessoa");
    Console.WriteLine("Digite 2 para salvar em json");
    Console.WriteLine("Digite 3 para ler um arquivo Json");
    Console.WriteLine("Digite 4 filtar pessoas por idade");
    Console.WriteLine("Digite 5 para sair");
    Console.WriteLine("--------------------------------------");

    Console.Write("Opção: ");
    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            CriarPessoa(pessoasCadastradas);
            MenuPessoa();
            break;
        case 2:
            CriarArquivo(pessoasCadastradas, "pessoasCadastradas.json");
            MenuPessoa();
            break;
        case 3:
            LerArquivo<Pessoa>("pessoasCadastradas.json");
            
            MenuPessoa();
            break;
        case 4:
            FiltarPessoaPorIdade(pessoas);
            break;
        case 5:
            Console.WriteLine("Tchau");
            MenuPessoa();
            break;
        default:
            Console.WriteLine("Opcao Invalida");
            MenuPessoa();
            break;
    }
}

void CriarPessoa(List<Pessoa> pessoas)
{
    Console.Clear();
    Console.Write("Digite o nome da pessoa: ");
    string nome = Console.ReadLine();
    Console.Write("Digite o email da pessoa: ");
    string email = Console.ReadLine();
    Console.Write("Digite a idade da pessoa: ");
    int idade = int.Parse(Console.ReadLine());

    Pessoa p = new Pessoa(nome, email, idade);

    pessoas.Add(p);
}

void FiltarPessoaPorIdade(List<Pessoa> pessoas)
{
    Console.Clear();
    Console.Write("Digite a idade que você quer filtar: ");
    int idade = int.Parse(Console.ReadLine());
    Console.WriteLine($"\nPessoas com {idade} ano(s)");
    var pessoasPorIdade = pessoas.Where(i => i.Idade == idade).OrderBy(i => i.Nome).ToList();
    foreach (var item in pessoasPorIdade)
    {
        Console.WriteLine(item.ToString());
    }
}

MenuPessoa();

//CriarJson("pessoas.json");
//LerArquivo<Pessoa>("pessoas.json");