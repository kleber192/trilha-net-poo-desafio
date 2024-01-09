using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
class Program {
static void Main() {

string numero ;
string modelo ;
string imei ;
int memoria ;

string app;

Console.WriteLine("  Digite o Numero do SmartPhone");
numero = Console.ReadLine();

Console.WriteLine("  Digite o Modelo ");
modelo = Console.ReadLine();

Console.WriteLine("  Digite o Imei");
imei  = Console.ReadLine();

Console.WriteLine("  Digite a Memoria ");
memoria = int.Parse(Console.ReadLine());;


Nokia nokia = new Nokia(numero,modelo,imei,memoria);

Iphone iphone = new Iphone(numero,modelo,imei,memoria);


Console.WriteLine(" Usando o nokia :  ");
nokia.Ligar();
nokia.ReceberLigacao();

Console.WriteLine(" Digite o nome do app ");
app = Console.ReadLine();
nokia.InstalarAplicativo(app);


Console.WriteLine(" Usando o Iphone :  ");

iphone.Ligar();
iphone.ReceberLigacao();

Console.WriteLine(" Digite o nome do app ");
app = Console.ReadLine();
iphone.InstalarAplicativo(app);

}

  }