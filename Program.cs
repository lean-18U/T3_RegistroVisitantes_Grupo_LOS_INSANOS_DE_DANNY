using System;
class Program
{
    const int MAX = 100;
    static string[] codigos = new string[MAX];
    static string[] nombres = new string[MAX];
    static int[] departamentos = new int[MAX];
    static int[] cantidadPersonas = new int[MAX];
    static string[] motivos = new string[MAX];
    static string[] horasIngreso = new string[MAX];
    static string[] horasSalida = new string[MAX];
    static int total = 0;
    static void Main()
    {
        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("---------REGISTRO DE VISITANTES -----------");
            Console.WriteLine("1. Registrar visitante");
            Console.WriteLine("2. Mostrar visitantes");
            Console.WriteLine("3. Buscar visitante por codigo");
            Console.WriteLine("4. Modificar visitante");
            Console.WriteLine("5. Insertar visitante");
            Console.WriteLine("6. Eliminar visitante");
            Console.WriteLine("7. Ordenar visitantes");
            Console.WriteLine("8. Mostrar resumen");
            Console.WriteLine("9. Salir");

            Console.Write("\nSeleccione una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
    if (total < MAX)
    {
        Console.Write("Ingrese codigo: ");
        codigos[total] = Console.ReadLine();

        if (codigos[total] == "")
        {
            Console.WriteLine("El codigo no puede estar vacio");
            break;
        }

        Console.Write("Ingrese nombre del visitante: ");
        nombres[total] = Console.ReadLine();

        if (nombres[total] == "")
        {
            Console.WriteLine("El nombre no puede estar vacio");
            break;
        }

        Console.Write("Ingrese departamento: ");
        departamentos[total] = Convert.ToInt32(Console.ReadLine());

        if (departamentos[total] <= 0)
        {
            Console.WriteLine("Departamento invalido");
            break;
        }

        Console.Write("Cantidad de personas: ");
        cantidadPersonas[total] = Convert.ToInt32(Console.ReadLine());

        if (cantidadPersonas[total] <= 0)
        {
            Console.WriteLine("La cantidad debe ser mayor a 0");
            break;
        }

        Console.Write("Motivo de la visita: ");
        motivos[total] = Console.ReadLine();

        Console.Write("Hora de ingreso: ");
        horasIngreso[total] = Console.ReadLine();

        Console.Write("Hora de salida: ");
        horasSalida[total] = Console.ReadLine();

        total++;

        Console.WriteLine("\nVisitante registrado correctamente");
    }
    else
    {
        Console.WriteLine("No hay espacio para mas visitantes");
    }
    break;

                case 2:
    if (total == 0)
    {
        Console.WriteLine("No hay visitantes registrados");
    }
    else
    {
        Console.WriteLine("\nLISTA DE VISITANTES");

        for (int i = 0; i < total; i++)
        {
            Console.WriteLine("\n------------------------");
            Console.WriteLine("Codigo: " + codigos[i]);
            Console.WriteLine("Nombre: " + nombres[i]);
            Console.WriteLine("Departamento: " + departamentos[i]);
            Console.WriteLine("Cantidad de personas: " + cantidadPersonas[i]);
            Console.WriteLine("Motivo: " + motivos[i]);
            Console.WriteLine("Hora ingreso: " + horasIngreso[i]);
            Console.WriteLine("Hora salida: " + horasSalida[i]);
        }
    }
    break;

                case 3:
                    Console.WriteLine("Estamos agregando cosas");
                    break;

                case 4:
                    Console.WriteLine("Estamos agregando cosas");
                    break;

                case 5:
                    Console.WriteLine("Estamos agregando cosas");
                    break;

                case 6:
                    Console.WriteLine("Estamos agregando cosas");
                    break;

                case 7:
                    Console.WriteLine("Estamos agregando cosas");
                    break;

                case 8:
                    Console.WriteLine("Estamos agregando cosas");
                    break;

                case 9:
                    Console.WriteLine("Saliendo del sistema");
                    break;

                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
            if (opcion != 9)
            {
                Console.WriteLine("\nPresione una tecla para continuar porfavor");
                Console.ReadKey();
            }

        } while (opcion != 9);
    }
}