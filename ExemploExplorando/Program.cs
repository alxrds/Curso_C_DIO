using ExemploExplorando.Models;
using System.Globalization;

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("GO", "Goiás");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");
estados.Add("RJ", "Rio de Janeiro");

foreach(var item in estados)
{
    Console.WriteLine($"UF: {item.Key}, Nome: {item.Value}");
}

estados["GO"] = "Goyaz";
estados.Remove("BA");

foreach(var item in estados)
{
    Console.WriteLine($"UF: {item.Key}, Nome: {item.Value}");
}

Console.WriteLine(estados["GO"]);

/*
//LIFO - Last in first out
Stack<int> pilha = new Stack<int>();

pilha.Push(2);
pilha.Push(4);
pilha.Push(6);
pilha.Push(8);

foreach(int item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo {pilha.Pop()}");
Console.WriteLine($"Removendo {pilha.Pop()}");

foreach(int item in pilha)
{
    Console.WriteLine(item);
}


//FIFO - First in first out
Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);
fila.Enqueue(10);

foreach(int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo {fila.Dequeue()}");
Console.WriteLine($"Removendo {fila.Dequeue()}");
Console.WriteLine($"Removendo {fila.Dequeue()}");

foreach(int item in fila)
{
    Console.WriteLine(item);
}

//Exceção
ExemploExcecao excecao = new ExemploExcecao();
excecao.Metodo1();

try
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivo.txt");

    foreach(string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}catch(Exception ex)
{
    Console.WriteLine($"Erro generico: {ex.Message}");
}
finally
{
    Console.WriteLine("FIM");
}


//Data e Hora

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