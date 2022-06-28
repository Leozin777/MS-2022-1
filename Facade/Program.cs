using Facade.SubSystem;

Facade.MyFacade.Facade facade = new Facade.MyFacade.Facade(); 

Cliente cliente1 = new Cliente(1, "Leonardo", "04583215");

bool res = facade.Emprestimo(cliente1, 200000);

Console.WriteLine("O emprestimo pedido pelo " + cliente1.Nome + " foi ");
if (!res)
    Console.Write("negado");
else
    Console.Write("aprovado");

