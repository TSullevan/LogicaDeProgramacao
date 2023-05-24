//Declarações de numeros inteiros byte, short, int e long seguem essa forma
int a = 0;
float b = 0.5f;
double c = 0.5;
decimal d = 0.5m;
char e = 'a';
string f = "";
string f1 = string.Empty;
object g = new { };
bool h = false;

//Todas as tipagens são passíveis de serem nulas, (substitua int por qual precisar)
int? a0 = null;
Nullable<int> a00 = null;

//Declarações em geral
int a2 = default(int);
int a3 = default;
int a4, a5;

//Encadeamentos de qualquer tipagem (substitua int por qual precisar)
int[] a6 = { };
IEnumerable<int> a7 = new List<int>();
List<int> a8 = new List<int>();

//Estruturas Condicionais

if(1 < 2)
{
    //Bloco
}

if (1 > 2)
{
    //Bloco
    return;
}

if (1 < 2)
{
    //Bloco
}
else if (1 < 2)
{
    //Bloco
}

if (1 < 2)
{
    //Bloco
}
else
{
    //Bloco
}

switch("Opção Y")
{
    case "Opção X":
        break;
    case "Opção Y":
        break;
    case "Opção Z":
        break;
    default:
        //Caso não caia em nenhuma
}

//Estruturas de Repetição

while(1 < 2)
{
    break;
}

do
{
    break;
} 
while (1 < 2);

for(int i = 0; i < 10; i++)
{
    continue;
}

foreach(int element in a8)
{
    return;
}

//Funções

Function();
Function1("Function1!");
string text = Function2("2");
Console.WriteLine(text);

static void Function()
{
    Console.WriteLine("Function!");
}

static void Function1(string text)
{
    Console.WriteLine(text);
}

static string Function2(string index)
{
    return "Function" + index + "!";
}

//Recursão

Recursion(1);

static int Recursion(int number)
{
    if(number > 10)
    {
        return number;
    }
    Console.WriteLine($"Recursion{number.ToString()}!");
    number++;
    Recursion(number);
    return number;
}

//Struct

Person person;

person.age = 23;
person.name = "Enzo";

Console.WriteLine($"Nome: {person.name}");
Console.WriteLine($"Idade: {person.age}");

struct Person
{
    public int age;
    public string name;
}
