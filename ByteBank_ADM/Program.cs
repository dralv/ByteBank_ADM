using ByteBank_ADM.Funcionarios;

Funcionario alvaro = new Funcionario();
alvaro.Nome = "Álvaro Teixeira";
alvaro.Cpf = "78945612300";
alvaro.Salario = 1100;

Console.WriteLine(alvaro.Nome);
Console.WriteLine(alvaro.GetBonificacao());