namespace Facade.SubSystem;

public class LimiteCredito
{
    public bool Credito(Cliente cliente, double valor)
    {
        Console.WriteLine("Verificando o limite de crédito do cliente " + cliente.Nome);
        
        if (valor > 10000)
            return false;
        else
            return true;
    }
}