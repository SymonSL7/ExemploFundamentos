
using ExemploFundamentos.Models;

Pessoa pessoa = new Pessoa();

pessoa.Nome = "Symon";
pessoa.Idade = 27;

pessoa
.Apresentar();

Console.WriteLine("---------------------------------------------------------------------");

string palavra = "Palavra Qualquer";
int inteiro = int.MaxValue;
long inteiroLong = long.MaxValue;
double valorDouble = 1.80;
decimal valorMonetario = decimal.MaxValue;
bool booleano = true;

Console.WriteLine(
$"Palavra(string): {palavra}\n" +
$"Inteiro(int): {inteiro}\n" +
$"Inteiro Long(long): {inteiroLong}\n" +
$"Decimal(double): {valorDouble}\n" +
$"Decimal Com Duas Casas Decimais(double): {valorDouble.ToString("0.00")}\n" +
$"Valor Monetario(decimal): {valorMonetario}\n" +
$"Booleano(bool): {booleano}"
);

DateTime dataAtual = DateTime.Now;

Console.WriteLine($"Data e Hora Atual: {dataAtual}");

DateTime dataAtualMaisCincoDias = dataAtual.AddDays(5);

Console.WriteLine($"Data e Hora Atual, Adicionando 5 Dias: {dataAtualMaisCincoDias}");

Console.WriteLine($"Somente a Data Atual: {dataAtual.ToString("dd/MM/yyyy")}"); // "dd/MM/yyyy HH:mm:ss" - Formatação de Data e Horas

Console.WriteLine("---------------------------------------------------------------------");

int a;
string b = "5";

a = int.Parse(b);

Console.WriteLine(a);

DateTime data2;

string data3 = "24/07/2025";

data2 = Convert.ToDateTime(data3);

// data2 = DateTime.Parse(data3);

Console.WriteLine(data2);

Console.WriteLine("---------------------------------------------------------------------");

string data4;

DateTime data5 = DateTime.Now;

data4 = data5.ToString();

Console.WriteLine(data4);

Console.WriteLine("---------------------------------------------------------------------");

string d = "15-";

int.TryParse(d, out int e);

Console.WriteLine(e);
Console.WriteLine("Teste");

Console.WriteLine("---------------------------------------------------------------------");

int quantidadeEmEstoque = 10;

int quantidadeCompra;

// Console.WriteLine("Digite a quantidade desejada:");
// quantidadeCompra = Convert.ToInt32(Console.ReadLine());

quantidadeCompra = -1;

if (quantidadeCompra.Equals(0) || quantidadeCompra < 0)
{
    Console.WriteLine("Venda inválida, quantidade de compra não pode ser 0 ou negativa");
}
else if (quantidadeEmEstoque >= quantidadeCompra)
{
    Console.WriteLine("Quantidade Disponivel");
}
else
{
    Console.WriteLine("Quantidade Indisponivel");
}

Console.WriteLine("---------------------------------------------------------------------");

Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine().ToLower();
string letra = "A".ToLower();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;
    default:
        Console.WriteLine("Não é uma vogal");
        break;
}

Console.WriteLine("---------------------------------------------------------------------");

bool possuiPresencaMinima = true;
double media = 6.5;

if (possuiPresencaMinima && media >= 7)
{
    Console.WriteLine("Aprovado!");
}
else
{
    Console.WriteLine("Reprovado!");
}

Console.WriteLine("---------------------------------------------------------------------");

bool choveu = true;
bool estaTarde = true;

if (!choveu && !estaTarde)
{
    Console.WriteLine("Vou pedalar!");
}
else
{
    Console.WriteLine("Não vou pedalar!");
}

Console.WriteLine("---------------------------------------------------------------------");

Calculadora calculadora = new Calculadora();

calculadora.Somar(5, 2);
calculadora.Subtrair(5, 2);
calculadora.Multiplicar(5, 2);
calculadora.Dividir(5, 2);
calculadora.Resto(5, 2);
calculadora.Potencia(5, 2);
calculadora.Seno(30);
calculadora.Coseno(30);
calculadora.Tangente(30);
calculadora.RaizQuadrada(16);

Console.WriteLine("---------------------------------------------------------------------");

Console.WriteLine("Kaio Jorge fez gol?");

//string resposta = Console.ReadLine().ToLower();

string resposta = "sim";

if (resposta.Equals("sim"))
{
    Console.WriteLine("Faça o K imediatamente!");
}
else
{
    Console.WriteLine("Espere mais um pouco para fazer o K");
}

Console.WriteLine("---------------------------------------------------------------------");

calculadora.Tabuada(10, "*", 10);

Console.WriteLine("---------------------------------------------------------------------");

string condicao = "";

for (int i = 0; !condicao.Equals("nao"); i++)
{
    Console.WriteLine("Deseja continua");
    //condicao = Console.ReadLine();
    condicao = "nao";
    if (condicao.Equals("nao"))
    {
        Console.WriteLine("Programa Encerrado!");
    }
}

// int teste = 0;
// for (int i = 0; !teste.Equals(1); i++)
// {
//     //teste++;
//     Console.WriteLine("Deseja continua");
//     condicao = Console.ReadLine();
//     //condicao = "nao";

//     if (condicao.Equals("nao"))
//     {
//         Console.WriteLine("Programa Encerrado!");
//         break;
//     }
// }

Console.WriteLine("---------------------------------------------------------------------");

string fezGol = "";
int quantidadeGol = 0;
for (int i = 0; !fezGol.Equals("não"); i++)
{

    Console.WriteLine("O Kaio Jorge fez gol?");
    Console.WriteLine("");
    fezGol = Console.ReadLine().ToLower();
    Console.WriteLine("");

    if (fezGol.Equals("sim"))
    {
        Console.WriteLine("Faça o K imediatamente!");
        Console.WriteLine("");
        quantidadeGol++;
    }
    else
    {
        Console.WriteLine("Espera mais um pouco para fazer o K novamente!");
        Console.WriteLine("");
        if (quantidadeGol.Equals(1))
        {
            Console.WriteLine($"Você fez o K {quantidadeGol} vez, nesse jogo! ");
        }
        else
        {
            Console.WriteLine($"Você fez o K {quantidadeGol} vezes, nesse jogo! ");
        }
    }

}




