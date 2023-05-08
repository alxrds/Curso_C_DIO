using ExemploExplorando.Models;
using System.Globalization;

string dataString = "2023-05-08 10:57";
bool conversao = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);
if(conversao){
    Console.WriteLine(data);
}else{
    Console.WriteLine("data inválida");
}

DateTime dataAtual = DateTime.Now;

Console.WriteLine(dataAtual.ToString("dd-MM-yyyy HH:mm"));
Console.WriteLine(dataAtual.ToShortDateString());
Console.WriteLine(dataAtual.ToShortTimeString());


/*
decimal valorMonetario = 7100.00M;

Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
Console.WriteLine(valorMonetario.ToString("C2"));

double porcentagem = .3580;
Console.WriteLine(porcentagem.ToString("P"));

int numero = 12345678;
Console.WriteLine(numero.ToString("##-##-##"));

Pessoa p1 = new Pessoa("Alexandre","Rodrigues");

Pessoa p2 = new Pessoa("Daniella","Segati");

Curso cursodeIngles = new Curso();
cursodeIngles.Nome = "Ingles";

cursodeIngles.Alunos = new List<Pessoa>();
cursodeIngles.AdicionarAluno(p1);
cursodeIngles.AdicionarAluno(p2);

cursodeIngles.ListarAlunos();

Pessoa p1 = new Pessoa();

p1.Nome = "Alexandre";
p1.Sobrenome = "Rodrigues";
p1.Idade = 42;

p1.Apresentar();
*/