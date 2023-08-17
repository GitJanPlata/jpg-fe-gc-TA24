// Milestone 1
/*

// Fase 1

int billete5 = 5, billete10 = 10, billete20 = 20, billete50 = 50, billete100 = 100, billete200 = 200, billete500 = 500;
int precioTotal = 0;

string[] menu = { "Macarrones", "Espagueti a la carbonara", "Albóndigas" }; 
int[] precios = { 10, 15, 20 };

// Fase 2

List<string> pedido = new List<string>();
int continuar = 1;

while (continuar == 1)
{
    Console.WriteLine("¿Qué desea comer?");
    Console.WriteLine("Precios:");
    for (int i = 0; i < menu.Length; i++)
    {
        Console.WriteLine(menu[i] + ": " + precios[i] + " euros");
    }

    string eleccion = Console.ReadLine();
    pedido.Add(eleccion);
        
    Console.WriteLine("¿Desea pedir algo más? (1:Si / 0:No)");
    continuar = int.Parse(Console.ReadLine());
}

// Fase 3

foreach (string platillo in pedido)
{
    bool existe = false;
    for (int i = 0; i < menu.Length; i++)
    {
        if (platillo == menu[i])
        {
            precioTotal += precios[i];
            existe = true;
            break;
        }
    }

    if (!existe)
    {
        Console.WriteLine("El producto " + platillo + " no existe.");
    }
}
Console.WriteLine("Precio total: " + precioTotal + " euros");

// Contador de billetes 

int[] valoresBilletes = { billete500, billete200, billete100, billete50, billete20, billete10, billete5 };
string[] nombresBilletes = { "billete(s) de 500", "billete(s) de 200", "billete(s) de 100", "billete(s) de 50", "billete(s) de 20", "billete(s) de 10", "billete(s) de 5" };

Console.WriteLine("Billetes necesarios para pagar:");

for (int i = 0; i < valoresBilletes.Length; i++)
{
    if (precioTotal >= valoresBilletes[i])
    {
        int numBilletes = precioTotal / valoresBilletes[i];
        Console.WriteLine(numBilletes + " " + nombresBilletes[i]);
        precioTotal -= numBilletes * valoresBilletes[i];
    }
}

if (precioTotal > 0)
{
    Console.WriteLine("Necesitas " + precioTotal + " euros adicionales en monedas.");
}
else
{
    Console.WriteLine("Con estos billetes puedes pagar de forma exacta.");
}



// Milestone 2 

// Declaración de excepciones
public class ProductoNoExisteException : Exception
{
    public ProductoNoExisteException() : base("El producto que has introducido no existe en nuestro menú.") { }
}

public class OpcionNoValidaException : Exception
{
    public OpcionNoValidaException() : base("La opción introducida no es válida. Por favor, introduce 1 para 'Sí' o 0 para 'No'.") { }
}

public class Milestone2
{
    public static void Main(string[] args)
    {
        // Fase 1
        int billete5 = 5, billete10 = 10, billete20 = 20, billete50 = 50, billete100 = 100, billete200 = 200, billete500 = 500;
        int precioTotal = 0;

        string[] menu = { "Macarrones", "Espagueti", "Albóndigas" };
        int[] precios = { 10, 15, 20 };

        // Fase 2
        List<string> pedido = new List<string>();
        int continuar = 1;

        while (continuar == 1)
        {
            Console.WriteLine("¿Qué desea comer?");
            Console.WriteLine("Precios:");
            for (int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine(menu[i] + ": " + precios[i] + " euros");
            }

            try
            {
                string eleccion = Console.ReadLine();
                if (!menu.Contains(eleccion))
                {
                    throw new ProductoNoExisteException();
                }
                pedido.Add(eleccion);
            }
            catch (ProductoNoExisteException e)
            {
                Console.WriteLine(e.Message);
                continue;
            }

            do
            {
                try
                {
                    Console.WriteLine("¿Desea pedir algo más? (1:Si / 0:No)");
                    continuar = int.Parse(Console.ReadLine());

                    if (continuar != 1 && continuar != 0)
                    {
                        throw new OpcionNoValidaException();
                    }
                }
                catch (OpcionNoValidaException e)
                {
                    Console.WriteLine(e.Message);
                    continuar = -1;
                }
            } while (continuar == -1);

        }

        // Fase 3

        foreach (string platillo in pedido)
        {
            bool existe = false;
            for (int i = 0; i < menu.Length; i++)
            {
                if (platillo == menu[i])
                {
                    precioTotal += precios[i];
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                Console.WriteLine("El producto " + platillo + " no existe en nuestra base de datos.");
            }
        }

        int[] valoresBilletes = { billete500, billete200, billete100, billete50, billete20, billete10, billete5 };
        string[] nombresBilletes = { "billete(s) de 500", "billete(s) de 200", "billete(s) de 100", "billete(s) de 50", "billete(s) de 20", "billete(s) de 10", "billete(s) de 5" };

        Console.WriteLine("Billetes necesarios para pagar:");

        for (int i = 0; i < valoresBilletes.Length; i++)
        {
            if (precioTotal >= valoresBilletes[i])
            {
                int numBilletes = precioTotal / valoresBilletes[i];
                Console.WriteLine(numBilletes + " " + nombresBilletes[i]);
                precioTotal -= numBilletes * valoresBilletes[i];
            }
        }

        if (precioTotal > 0)
        {
            Console.WriteLine("Necesitas " + precioTotal + " euros adicionales en monedas.");
        }
        else
        {
            Console.WriteLine("Con estos billetes puedes pagar exactamente.");
        }

        Console.WriteLine("Precio total: " + precioTotal + " euros");
    }

}
*/
public class Milestone3
{
    public static void Main(string[] args)
    {
        // Fase 1
        int billete5 = 5, billete10 = 10, billete20 = 20, billete50 = 50, billete100 = 100, billete200 = 200, billete500 = 500;
        int precioTotal = 0;

        string[] menu = { "Macarrones", "Espagueti", "Albóndigas" };
        int[] precios = { 10, 15, 20 };

        // Fase 2
        List<string> pedido = new List<string>();
        int continuar = 1;

        while (continuar == 1)
        {
            Console.WriteLine("¿Qué desea comer?");
            Console.WriteLine("Precios:");
            for (int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine(menu[i] + ": " + precios[i] + " euros");
            }

            try
            {
                string eleccion = Console.ReadLine();
                if (!menu.Contains(eleccion))
                {
                    throw new IntroPlatosException();
                }
                pedido.Add(eleccion);
            }
            catch (IntroPlatosException e)
            {
                Console.WriteLine(e.Message);
                continue;
            }

            do
            {
                try
                {
                    Console.WriteLine("¿Desea pedir algo más? (1:Si / 0:No)");
                    continuar = int.Parse(Console.ReadLine());

                    if (continuar != 1 && continuar != 0)
                    {
                        throw new RevisionDeTipoException();
                    }
                }
                catch (RevisionDeTipoException e)
                {
                    Console.WriteLine(e.Message);
                    continuar = -1;
                }
            } while (continuar == -1);
        }

        // Fase 3

        foreach (string platillo in pedido)
        {
            bool existe = false;
            for (int i = 0; i < menu.Length; i++)
            {
                if (platillo == menu[i])
                {
                    precioTotal += precios[i];
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                throw new RevisionPlatosException();
            }
        }

        int precioOriginal = precioTotal;

        int[] valoresBilletes = { billete500, billete200, billete100, billete50, billete20, billete10, billete5 };
        string[] nombresBilletes = { "billete(s) de 500", "billete(s) de 200", "billete(s) de 100", "billete(s) de 50", "billete(s) de 20", "billete(s) de 10", "billete(s) de 5" };

        Console.WriteLine("Billetes necesarios para pagar:");

        for (int i = 0; i < valoresBilletes.Length; i++)
        {
            if (precioTotal >= valoresBilletes[i])
            {
                int numBilletes = precioTotal / valoresBilletes[i];
                Console.WriteLine(numBilletes + " " + nombresBilletes[i]);
                precioTotal -= numBilletes * valoresBilletes[i];
            }
        }

        if (precioTotal > 0)
        {
            Console.WriteLine("Necesitas " + precioTotal + " euros adicionales en monedas.");
        }
        else
        {
            Console.WriteLine("Con estos billetes puedes pagar exactamente.");
        }

        Console.WriteLine("Precio total: " + precioOriginal + " euros");

    }
}

