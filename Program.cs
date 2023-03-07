using YieldReturn.Model;

IEnumerable<Pessoa> GeradorPessoas()
{

    Random rnd = new Random();

    for (int i = 0; i < 100; i++)
    {
        yield return new Pessoa()
        {
            Guid = Guid.NewGuid(),
            Nome = $"Pessoa {i}",
            Cpf = rnd.Next(),
        };
    }
}


var pessoas = GeradorPessoas();

foreach (var item in pessoas)
{
    Console.WriteLine($"{item.Nome} Guid {item.Guid} Cpf {item.Cpf} Gerada!");

    if(item.Nome == "Pessoa 10")
    break;
}

