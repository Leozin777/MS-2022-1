using Solid;

//Liskov = A conta pai pode ser substituida pela conta filha
List<Pessoa> pessoas = new List<Pessoa>();
pessoas.Add(new PessoaFisica(1, "leo", "05451448"));
pessoas.Add(new PessoaJuridica(1, "leo"));

pessoas.ForEach(e => Console.WriteLine(e.ToString()));
