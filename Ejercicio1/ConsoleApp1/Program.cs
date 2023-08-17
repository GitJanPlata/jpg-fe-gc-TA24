// Fase 1

string nom = "Jan";
string cognom1 = "Plata";
string cognom2 = "Garcia";
int dia = 10;
int mes = 10;
int any = 2000;

Console.WriteLine(cognom1 + " " + cognom2 + ", " + nom);
Console.WriteLine(dia + "/" + mes + "/" + any);

// Fase 2

const int ANY_TRASPAS = 1948;
int intervalTraspas = 4;
int anysTraspas = (any - ANY_TRASPAS) / intervalTraspas;

Console.WriteLine("Hi ha " + anysTraspas + " anys de traspàs des de 1948 fins al meu any de naixement.");

// Fase 3

bool esTraspas = false;
string fraseSi = "El meu any de naixement és de traspàs.";
string fraseNo = "El meu any de naixement no és de traspàs.";

for (int i = ANY_TRASPAS; i <= any; i += intervalTraspas)
{
    Console.WriteLine(i);
    if (i == any)
    {
        esTraspas = true;
    }
}

Console.WriteLine(esTraspas ? fraseSi : fraseNo);

// Fase 4

string nomComplet = nom + " " + cognom1 + " " + cognom2;
string dataNaixement = dia + "/" + mes + "/" + any;

Console.WriteLine("El meu nom és " + nomComplet);
Console.WriteLine("Vaig néixer el " + dataNaixement);
Console.WriteLine(esTraspas ? fraseSi : fraseNo);

// Milestone 2

double valor = 1234.5678;
int valorInt = (int)valor;
float valorFloat = (float)valor;
string valorString = valor.ToString();

Console.WriteLine("Double: " + valor);
Console.WriteLine("Int: " + valorInt);
Console.WriteLine("Float: " + valorFloat);
Console.WriteLine("String: " + valorString);

// Milestone 3

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

int longitud = array.Length;
for (int i = 0; i < longitud / 2; i++)
{
    int temporal = array[i];
    array[i] = array[longitud - 1 - i];
    array[longitud - 1 - i] = temporal;
}

foreach (int num in array)
{
    Console.Write(num + " ");
}

