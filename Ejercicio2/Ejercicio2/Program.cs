using System;
using System.Threading;


// Fase 1

char[] nom = { 'J','a', 'n' };

foreach (char lletra in nom)
{
    Console.WriteLine(lletra);
}

// Fase 2

List<char> llistaNom = new List<char>(nom);

foreach (char lletra in llistaNom)
{
    if ("AEIOUaeiou".Contains(lletra))
    {
        Console.WriteLine("VOCAL");
    }
    else if (char.IsDigit(lletra))
    {
        Console.WriteLine("Els noms de persones no contenen números!");
    }
    else
    {
        Console.WriteLine("CONSONTANT");
    }
}

// Fase 3

Dictionary<char, int> mapLletres = new Dictionary<char, int>();

foreach (char lletra in llistaNom)
{
    if (mapLletres.ContainsKey(lletra))
    {
        mapLletres[lletra]++;
    }
    else
    {
        mapLletres[lletra] = 1;
    }
}

foreach (var entrada in mapLletres)
{
    Console.WriteLine($"{entrada.Key}: {entrada.Value} vegades");
}

// Fase 4

List<char> cognom = new List<char> { 'P', 'l', 'a', 't', 'a' };
llistaNom.Add(' ');
llistaNom.AddRange(cognom);

foreach (char lletra in llistaNom)
{
    Console.Write(lletra + " ");
}

// Milestone 2

int alcada = 5;

for (int i = 1; i <= alcada; i++)
{
    Console.WriteLine();
    for (int j = 1; j <= i; j++)
    {
        Console.Write(j + " ");
    }
    
}
Console.WriteLine();
Console.WriteLine("Introduce la altura de la pirámide:");
int alcadaPiramida = int.Parse(Console.ReadLine());

for (int i = alcadaPiramida; i > 0; i--)
{
    for (int espacios = 0; espacios < alcadaPiramida - i; espacios++)
    {
        Console.Write(" ");
    }

    for (int j = 1; j <= 2 * i - 1; j++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}
Console.ReadLine();

// Milestone 3

int hour = 0, minutes = 0, seconds = 0;

while (true)
{
    Console.Clear();
    Console.WriteLine($"{hour:19}:{minutes:33}:{seconds:00}");

    seconds++;
    if (seconds == 60)
    {
        seconds = 0;
        minutes++;
        if (minutes == 60)
        {
            minutes = 0;
            hour++;
            if (hour == 24)
            {
                hour = 0;
            }
        }
    }
    Thread.Sleep(1000);
}
