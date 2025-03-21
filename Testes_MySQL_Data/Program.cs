using Testes_MySQL_Data.Model;

// Área de testes.

try
{

    //

}

catch (Exception ex)
{

    Console.WriteLine(ex.Message);

}

Console.ReadKey();

// Classe de testes.

class Testes
{

    public static void Cadastro_Pessoa()
    {

        PessoaModel model = new PessoaModel(0, "Pablo", 18);

        bool sucesso = model.Save();

        Console.WriteLine("Pessoa cadastrada " + ((sucesso) ? "com" : "sem") + " sucesso.");

    }

    public static void Edicao_Pessoa()
    {

        PessoaModel model = new PessoaModel(1, "Pablo Valentin", 19);

        bool sucesso = model.Save();

        Console.WriteLine("Pessoa editada " + ((sucesso) ? "com" : "sem") + " sucesso.");

    }

    public static void Listagem_Pessoas()
    {

        foreach (PessoaModel pessoa in PessoaModel.List())
        {

            Console.WriteLine($"{pessoa.id} | {pessoa.nome} | {pessoa.idade}");

        }

    }

    public static void Pesquisa_Pessoa()
    {

        PessoaModel? model = PessoaModel.Find(1);

        Console.WriteLine("Pessoa encontrada:\n");

        if (model == null)
        {

            Console.WriteLine("Nenhuma.");

        }

        else
        {

            Console.WriteLine($"{model.id} | {model.nome} | {model.idade}");

        }

    }

    public static void Cadastro_Transacao()
    {

        TransacaoModel model = new TransacaoModel(0, "Testando...", 10.00, "Despesa", 1);

        bool sucesso = model.Save();

        Console.WriteLine("Transação cadastrada " + ((sucesso) ? "com" : "sem") + " sucesso.");

    }

    public static void Edicao_Transacao()
    {

        TransacaoModel model = new TransacaoModel(1, "Testando edição...", 100.00, "Receita", 1);

        bool sucesso = model.Save();

        Console.WriteLine("Transação editada " + ((sucesso) ? "com" : "sem") + " sucesso.");

    }

    public static void Listagem_Transacoes()
    {

        foreach (TransacaoModel transacao in TransacaoModel.List())
        {

            Console.WriteLine($"{transacao.id} | {transacao.descricao} | {transacao.valor} | {transacao.tipo} | {transacao.fk_pessoa}");

        }

    }

}