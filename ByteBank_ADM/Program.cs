using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.Utilitario;

Funcionario alvaro = new Funcionario("78945612300",2000);
alvaro.Nome = "Álvaro Teixeira";


Console.WriteLine(alvaro.Nome);
Console.WriteLine(alvaro.GetBonificacao());


Diretor roberta = new Diretor("78945612374",5000);
roberta.Nome = "Roberta Silva";


Console.WriteLine(roberta.Nome);
Console.WriteLine(roberta.GetBonificacao());

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(alvaro);
gerenciador.Registrar(roberta);

Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);
Console.WriteLine("Total de funcionários: " + Funcionario.TotalDeFuncionarios);

alvaro.AumentarSalario();
roberta.AumentarSalario();

Console.WriteLine("Novo salário do Alvaro " + alvaro.Salario);
Console.WriteLine("Novo salário da Roberta " + roberta.Salario);

