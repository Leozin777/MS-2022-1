namespace Facade.SubSystem;

public class Cadastro
{
    public void CadastraCliente(Cliente cliente)
    {
        Console.WriteLine("O cliente " + cliente.Nome + " foi cadastrado com sucesso");
    }
}