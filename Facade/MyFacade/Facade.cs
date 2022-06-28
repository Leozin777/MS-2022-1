using Facade.SubSystem;

namespace Facade.MyFacade;

public class Facade
{
    private Cadastro _cadastro;
    private LimiteCredito _limiteCredito;
    private Serasa _serasa;

    public Facade()
    {
        this._cadastro = new Cadastro();
        this._limiteCredito = new LimiteCredito();
        this._serasa = new Serasa();
    }

    public bool Emprestimo(Cliente cliente, double valor)
    {
        Console.WriteLine("O cliente " + cliente.Nome + " esta pedindo um empréstimo no valor de " + valor + "\n");
        _cadastro.CadastraCliente(cliente);

        bool Emprestimo = true;

        if (_serasa.VerificaSituacao(cliente) == false)
        {
            Console.WriteLine("Situação pendente no Serasa, crédito negado");
            Emprestimo = false;
        }
        else if (_limiteCredito.Credito(cliente, valor) == false)
        {
            Console.WriteLine("Limite de crédito inferior a " + valor + "\n");
            Emprestimo = false;
        }

        return Emprestimo;

    }

}