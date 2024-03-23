using OOP;

Pessoa pessoa = new Pessoa() { DataNascimento = new DateTime(1983, 09, 15)};

var resultado = pessoa.CalcularIdade();

Console.WriteLine(resultado);

