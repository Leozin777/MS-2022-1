namespace Facade.SubSystem;

public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string CPF { get; set; }

    public Cliente(int id, string nome, string cpf)
    {
        this.Id = id;
        this.Nome = nome;
        this.CPF = cpf;
    }
}