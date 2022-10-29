using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.Utilitario;

Funcionario alvaro = new Funcionario();
alvaro.Nome = "Álvaro Teixeira";
alvaro.Cpf = "78945612300";
alvaro.Salario = 1100;

Console.WriteLine(alvaro.Nome);
Console.WriteLine(alvaro.GetBonificacao());


Diretor roberta = new Diretor();
roberta.Nome = "Roberta Silva";
roberta.Cpf = "78945612374";
roberta.Salario = 5000;

Console.WriteLine(roberta.Nome);
Console.WriteLine(roberta.GetBonificacao());

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(alvaro);
gerenciador.Registrar(roberta);

Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);

