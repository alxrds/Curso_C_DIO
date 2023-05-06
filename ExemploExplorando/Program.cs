using ExemploExplorando.Models;

Pessoa p1 = new Pessoa("Alexandre","Rodrigues");

Pessoa p2 = new Pessoa("Daniella","Segati");

Curso cursodeIngles = new Curso();
cursodeIngles.Nome = "Ingles";

cursodeIngles.Alunos = new List<Pessoa>();
cursodeIngles.AdicionarAluno(p1);
cursodeIngles.AdicionarAluno(p2);

cursodeIngles.ListarAlunos();





/*
Pessoa p1 = new Pessoa();

p1.Nome = "Alexandre";
p1.Sobrenome = "Rodrigues";
p1.Idade = 42;

p1.Apresentar();
*/