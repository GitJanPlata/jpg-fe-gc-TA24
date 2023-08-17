// Fase 1

Console.WriteLine("Introduce 6 nombres de ciudades:");
string ciudad1 = Console.ReadLine();
string ciudad2 = Console.ReadLine();
string ciudad3 = Console.ReadLine();
string ciudad4 = Console.ReadLine();
string ciudad5 = Console.ReadLine();
string ciudad6 = Console.ReadLine();


Console.WriteLine($"Las ciudades introducidas son: {ciudad1}, {ciudad2}, {ciudad3}, {ciudad4}, {ciudad5}, {ciudad6}");

// Fase 2

string[] arrayCiutats = { ciudad1, ciudad2, ciudad3, ciudad4, ciudad5, ciudad6 };
Array.Sort(arrayCiutats);
Console.WriteLine("Ciudades ordenadas alfabéticamente:");
foreach (string ciudad in arrayCiutats)
{
    Console.WriteLine(ciudad);
}

// Fase 3

string[] ArrayCiutatsModificades = arrayCiutats.Select(ciudad => ciudad.Replace('a', '4')).ToArray();
Array.Sort(ArrayCiutatsModificades);
Console.WriteLine("Ciudades modificadas y ordenadas:");
foreach (string ciudad in ArrayCiutatsModificades)
{
    Console.WriteLine(ciudad);
}

// Fase 4

string[] arrayInvertido = new string[6];
arrayInvertido[0] = new string(ciudad1.Reverse().ToArray());
arrayInvertido[1] = new string(ciudad2.Reverse().ToArray());
arrayInvertido[2] = new string(ciudad3.Reverse().ToArray());
arrayInvertido[3] = new string(ciudad4.Reverse().ToArray());
arrayInvertido[4] = new string(ciudad5.Reverse().ToArray());
arrayInvertido[5] = new string(ciudad6.Reverse().ToArray());

for (int i = 0; i < 6; i++)
{
    Console.WriteLine(arrayInvertido[i]);
}


// Milestone 2

double[,] notas = new double[5, 3];
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Introduce las notas del alumno {i + 1}:");
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"Nota {j + 1}: ");
        notas[i, j] = double.Parse(Console.ReadLine());
    }
}

for (int i = 0; i < 5; i++)
{
    double suma = 0;
    for (int j = 0; j < 3; j++)
    {
        suma += notas[i, j];
    }
    double media = suma / 3;
    string resultado = media >= 5 ? "Aprobado" : "Suspendido";
    Console.WriteLine($"Alumno {i + 1}: {resultado} (Media: {media})");
}

// Milestone 3

Console.WriteLine("Introduce un número para la secuencia de Fibonacci:");
int n = int.Parse(Console.ReadLine());
int a = 0;
int b = 1;
for (int i = 0; i < n; i++)
{
    Console.Write($"{a} ");
    int temp = a;
    a = b;
    b = temp + b;
}
