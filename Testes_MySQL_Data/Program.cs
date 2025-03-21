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

        Console.WriteLine("Pessoa cadastrada " + ((sucesso) ? "com" : "sem") + " sucesso!");

    }

    public static void Edicao_Pessoa()
    {

        PessoaModel model = new PessoaModel(1, "Pablo Valentin", 19);

        bool sucesso = model.Save();

        Console.WriteLine("Pessoa editada " + ((sucesso) ? "com" : "sem") + " sucesso!");

    }

    public static void Remocao_Pessoa()
    {

        bool sucesso = PessoaModel.Erase(1);

        if (sucesso)
        {

            Console.WriteLine("Pessoa removida com sucesso! Todas as transações associadas também foram removidas.");

        }

        else
        {

            Console.WriteLine("Pessoa removida sem sucesso!");

        }

    }

    public static void Listagem_Pessoas()
    {

        List<PessoaModel> lista_pessoas = PessoaModel.List();

        if (lista_pessoas.Count > 0)
        {

            foreach (PessoaModel pessoa in lista_pessoas)
            {

                Console.WriteLine($"{pessoa.id} | {pessoa.nome} | {pessoa.idade}");

            }

        }

        else
        {

            Console.WriteLine("Nada a exibir.");

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

        Console.WriteLine("Transação cadastrada " + ((sucesso) ? "com" : "sem") + " sucesso!");

    }

    public static void Edicao_Transacao()
    {

        TransacaoModel model = new TransacaoModel(1, "Testando edição...", 100.00, "Receita", 1);

        bool sucesso = model.Save();

        Console.WriteLine("Transação editada " + ((sucesso) ? "com" : "sem") + " sucesso!");

    }

    public static void Remocao_Transacao()
    {

        bool sucesso = TransacaoModel.Erase(1);

        Console.WriteLine("Transação removida " + ((sucesso) ? "com" : "sem") + " sucesso!");

    }

    public static void Listagem_Transacoes()
    {

        List<TransacaoModel> lista_transacoes = TransacaoModel.List();

        if (lista_transacoes.Count > 0)
        {

            foreach (TransacaoModel transacao in lista_transacoes)
            {

                Console.WriteLine($"{transacao.id} | {transacao.descricao} | {transacao.valor} | {transacao.tipo} | {transacao.fk_pessoa}");

            }

        }

        else
        {

            Console.WriteLine("Nada a exibir.");

        }

    }

}