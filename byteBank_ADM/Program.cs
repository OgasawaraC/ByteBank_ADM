using byteBank_ADM.Comercial;
using byteBank_ADM.Funcionarios;
using byteBank_ADM.SistemaInterno;
using byteBank_ADM.Utilitario;

#region
//Funcionario jorge =  new Funcionario("123456789",2000);
//jorge.Nome = "Jorge Silva";

//Console.WriteLine(jorge.Nome);
//Console.WriteLine(jorge.GetBonificacao());

//Diretor roberto = new Diretor("987654321");
//roberto.Nome = "Roberto Souza";

//Console.WriteLine(roberto.Nome);
//Console.WriteLine(roberto.GetBonificacao());

//GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
//gerenciador.Registrar(jorge);
//gerenciador.Registrar(roberto);
//Console.WriteLine("Total de Bonificações: "+gerenciador.TotalBonificacoes);

//Console.WriteLine("Total de Funcionários: "+Funcionario.TotalFuncionarios);

//jorge.AumentarSalario();
//roberto.AumentarSalario();

//Console.WriteLine("Novo salário do Jorge: "+jorge.Salario);
//Console.WriteLine("Novo salário do Roberto: " + roberto.Salario);
#endregion

//CalcularBonificacao();
UsarSistema();
void CalcularBonificacao()
{
    GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

    Designer ulisses = new Designer("123456");
    ulisses.Nome = "Ulisses Teixeira";

    Diretor paula = new Diretor("987456");
    paula.Nome = "Paula Andrade";

    Auxiliar renato = new Auxiliar("74581");
    renato.Nome = "Renato Boal";

    GerenteDeContas camila = new GerenteDeContas("852963");
    camila.Nome = "Camila Oliveira";

    gerenciador.Registrar(ulisses);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(renato);
    gerenciador.Registrar(camila);

    Console.WriteLine("Total de Bonificação = "+gerenciador.TotalBonificacoes);
}

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor manuel = new Diretor("852741");
    manuel.Nome = "Manuel João";
    manuel.Login = "manuel@gmail.com";
    manuel.Senha = "123";

    GerenteDeContas tarcisio = new GerenteDeContas("963852");
    tarcisio.Nome = "Tarcísio Texas";
    tarcisio.Login = "tarcisio@gmail.com";
    tarcisio.Senha= "321";

    ParceiroComercial caio = new ParceiroComercial();
    caio.Login = "caio@gmail.com";
    caio.Senha = "999";

    sistema.Logar(manuel, "manuel@gmail.com", "123");
    sistema.Logar(tarcisio, "tarcisio", "321");
    sistema.Logar(caio, "caio@gmail.com", "999");
}