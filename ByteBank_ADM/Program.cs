using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.SistemaInterno;
using ByteBank_ADM.Utilitario;

#region

//Funcionario alvaro = new Funcionario("78945612300",2000);
//alvaro.Nome = "Álvaro Teixeira";


//Console.WriteLine(alvaro.Nome);
//Console.WriteLine(alvaro.GetBonificacao());


//Diretor roberta = new Diretor("78945612374");
//roberta.Nome = "Roberta Silva";


//Console.WriteLine(roberta.Nome);
//Console.WriteLine(roberta.GetBonificacao());

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(alvaro);
//gerenciador.Registrar(roberta);

//Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);
//Console.WriteLine("Total de funcionários: " + Funcionario.TotalDeFuncionarios);

//alvaro.AumentarSalario();
//roberta.AumentarSalario();

//Console.WriteLine("Novo salário do Alvaro " + alvaro.Salario);
//Console.WriteLine("Novo salário da Roberta " + roberta.Salario);

#endregion

//CalcularBonificacao();
void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer ulisses = new Designer("123456789");
    ulisses.Nome = "Ulisses Souza";

    Diretor paula = new Diretor("85245695178");
    paula.Nome = "Paula Souza";

    Auxiliar igor = new Auxiliar("75395185246");
    igor.Nome = "Igor Dias";

    GerenteDeContas camila = new GerenteDeContas("85212379852");
    camila.Nome = "Camila Oliveira";

    gerenciador.Registrar(ulisses);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(camila);

    Console.WriteLine("Total de bonificãções = " + gerenciador.TotalDeBonificacao);
}

void usarSistema()
{
    SistemaInterno sistema = new SistemaInterno();
    Diretor ingrid = new Diretor("74145695173");
    ingrid.Nome = "Ingrid Novais";
    ingrid.Senha = "123";

    GerenteDeContas ursula = new GerenteDeContas("85295175346");
    ursula.Nome = "Ursula Alcatara";
    ursula.Senha = "321";

    sistema.Logar(ingrid, "123");
    sistema.Logar(ursula, "963");

}

usarSistema();