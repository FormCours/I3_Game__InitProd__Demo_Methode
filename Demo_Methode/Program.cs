using System.Text;
using Demo_Methode.Models;

// Support de l'UTF8 (Ca sert a rien, je veux mon emoji :p)
Console.OutputEncoding = Encoding.UTF8;


// Syntaxe en C# d'une méthode:
// type_retour NomMethode(parametres)

// ↓ Méthodes déclarés directement dans la zone programme
bool EstPair(int nombre)
{
    return ((nombre / 2) * 2) == nombre;
}

string GetName()
{
    Console.WriteLine("Quel est votre prénom ?");
    Console.Write("> ");
    string name = Console.ReadLine()!;

    return name;
}

void SayGoodBye()
{
    Console.WriteLine("Au revoir !");
    Console.WriteLine("👋");
}


int val = 42;
bool test = EstPair(val);
Console.WriteLine($"La valeur {val} est {(test ? "pair" : "Impair")}");

string prenom = GetName();
Console.WriteLine($"Bien le bonjour {prenom}");
SayGoodBye();


MathService m = new MathService();
int r1 = m.Multi(21, 2);  // 42
int r2 = m.Multi(13);     // 13

int r3 = m.Addition(1, 2, 3, 4, 5);
