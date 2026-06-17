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
            Console.WriteLine("5. Insertar visitante en la lista");
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
        Console.Write("Ingrese el DNI del visitante: ");
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
            Console.WriteLine("DNI: " + codigos[i]);
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
     if (total == 0)
    {
        Console.WriteLine("No hay visitantes registrados");
    }
    else
    {
        Console.Write("Ingrese el DNI del visitante a buscar: ");
        string codBuscar = Console.ReadLine();
        int posEncontrada = -1;

        for (int i = 0; i < total; i++)
        {
            if (codigos[i] == codBuscar)
            {
                posEncontrada = i;
                break;
            }
        }

        if (posEncontrada != -1)
        {
            Console.WriteLine("\n--- VISITANTE ENCONTRADO ---");
            Console.WriteLine("Nombre: " + nombres[posEncontrada]);
            Console.WriteLine("Departamento: " + departamentos[posEncontrada]);
            Console.WriteLine("Cantidad de personas: " + cantidadPersonas[posEncontrada]);
            Console.WriteLine("Motivo: " + motivos[posEncontrada]);
            Console.WriteLine("Hora ingreso: " + horasIngreso[posEncontrada]);
            Console.WriteLine("Hora salida: " + horasSalida[posEncontrada]);
        }
        else
        {
            Console.WriteLine("Visitante no encontrado");
        }
    }
    break;

                case 4:
    if (total == 0)
    {
        Console.WriteLine("No hay visitantes registrados para modificar");
    }
    else
    {
        Console.Write("Ingrese el DNI del visitante a modificar: ");
        string codModificar = Console.ReadLine();
        int posModificar = -1;

        for (int i = 0; i < total; i++)
        {
            if (codigos[i] == codModificar)
            {
                posModificar = i;
                break;
            }
        }

        if (posModificar != -1)
        {
            Console.WriteLine("\nModificando datos de: " + nombres[posModificar]);
            
            Console.Write("Nuevo nombre (Actual: " + nombres[posModificar] + "): ");
            nombres[posModificar] = Console.ReadLine();

            Console.Write("Nuevo departamento (Actual: " + departamentos[posModificar] + "): ");
            departamentos[posModificar] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nueva cantidad de personas (Actual: " + cantidadPersonas[posModificar] + "): ");
            cantidadPersonas[posModificar] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nuevo motivo: ");
            motivos[posModificar] = Console.ReadLine();

            Console.Write("Nueva hora de ingreso: ");
            horasIngreso[posModificar] = Console.ReadLine();

            Console.Write("Nueva hora de salida: ");
            horasSalida[posModificar] = Console.ReadLine();

            Console.WriteLine("\nVisitante modificado correctamente");
        }
        else
        {
            Console.WriteLine("Visitante no encontrado");
        }
    }
    break;

                case 5:
    if (total >= MAX)
    {
        Console.WriteLine("No hay espacio para insertar más visitantes");
    }
    else
    {
        Console.Write("Ingrese la posición donde desea insertar (0 a " + total + "): ");
        int posInsertar = Convert.ToInt32(Console.ReadLine());

        if (posInsertar >= 0 && posInsertar <= total)
        {
            for (int i = total; i > posInsertar; i--)
            {
                codigos[i] = codigos[i - 1];
                nombres[i] = nombres[i - 1];
                departamentos[i] = departamentos[i - 1];
                cantidadPersonas[i] = cantidadPersonas[i - 1];
                motivos[i] = motivos[i - 1];
                horasIngreso[i] = horasIngreso[i - 1];
                horasSalida[i] = horasSalida[i - 1];
            }

            Console.Write("Ingrese el DNI del Visitante: ");
            codigos[posInsertar] = Console.ReadLine();

            Console.Write("Ingrese nombre del visitante: ");
            nombres[posInsertar] = Console.ReadLine();

            Console.Write("Ingrese departamento: ");
            departamentos[posInsertar] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Cantidad de personas: ");
            cantidadPersonas[posInsertar] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Motivo de la visita: ");
            motivos[posInsertar] = Console.ReadLine();

            Console.Write("Hora de ingreso: ");
            horasIngreso[posInsertar] = Console.ReadLine();

            Console.Write("Hora de salida: ");
            horasSalida[posInsertar] = Console.ReadLine();

            total++;
            Console.WriteLine("\nVisitante insertado correctamente en la posición " + posInsertar);
        }
        else
        {
            Console.WriteLine("Posición fuera de rango válido");
        }
    }
    break;

                case 6:
                    EliminarVisitante();
                    break;

                case 7:
                    OrdenarVisitantes();
                    break;

                case 8:
                    MostrarResumen();
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
    static void EliminarVisitante()
    {
        if (total == 0)
        {
            Console.WriteLine("No hay visitantes registrados para eliminar");
            return;
        }

        Console.Write("Ingrese el DNI del visitante a eliminar: ");
        string codEliminar = Console.ReadLine();
        int posEliminar = -1;

        for (int i = 0; i < total; i++)
        {
            if (codigos[i] == codEliminar)
            {
                posEliminar = i;
                break;
            }
        }

        if (posEliminar != -1)
        {
            for (int i = posEliminar; i < total - 1; i++)
            {
                codigos[i] = codigos[i + 1];
                nombres[i] = nombres[i + 1];
                departamentos[i] = departamentos[i + 1];
                cantidadPersonas[i] = cantidadPersonas[i + 1];
                motivos[i] = motivos[i + 1];
                horasIngreso[i] = horasIngreso[i + 1];
                horasSalida[i] = horasSalida[i + 1];
            }

            total--;
            Console.WriteLine("\nVisitante eliminado Correctamente");
        }
        else
        {
            Console.WriteLine("Visitante no encontrado");
        }
    }

    static void OrdenarVisitantes()
    {
        if (total < 2)
        {
            Console.WriteLine("No se puede organizar ingrese mas visitantes");
            return;
        }

        for (int i = 0; i < total - 1; i++)
        {
            for (int j = 0; j < total -1 -i; j++)
            {
                if (departamentos[j] > departamentos[j + 1])
                {
                    int tempCant = cantidadPersonas[j];
                    cantidadPersonas[j] = cantidadPersonas[j + 1];
                    cantidadPersonas[j + 1] = tempCant;

                    string tempCod = codigos[j];
                    codigos[j] = codigos[j + 1];
                    codigos[j + 1] = tempCod;

                    string tempNom = nombres[j];
                    nombres[j] = nombres[j + 1];
                    nombres[j + 1] = tempNom;

                    int tempDep = departamentos[j];
                    departamentos[j] = departamentos[j + 1];
                    departamentos[j + 1] = tempDep;

                    string tempMot = motivos[j];
                    motivos[j] = motivos[j + 1];
                    motivos[j + 1] = tempMot;

                    string tempIng = horasIngreso[j];
                    horasIngreso[j] = horasIngreso[j + 1];
                    horasIngreso[j + 1] = tempIng;

                    string tempSal = horasSalida[j];
                    horasSalida[j] = horasSalida[j + 1];
                    horasSalida[j + 1] = tempSal;
                }
            }
        }
        Console.WriteLine("\nVisitantes organizados correctamente por departamento");
    }
    
    static void MostrarResumen()
    {
        int sumaTotalPersonas = 0;
        int mayorValor = cantidadPersonas[0];
        int menorValor = cantidadPersonas[0];
        int indiceMayor = 0;
        int indiceMenor = 0;

        for (int i = 0; i < total; i++ )
        {
            sumaTotalPersonas = sumaTotalPersonas + cantidadPersonas[i];

            if (cantidadPersonas[i] > mayorValor)
            {
                mayorValor = cantidadPersonas[i];
                indiceMayor = i;
            }

            if (cantidadPersonas[i] < menorValor)
            {
                menorValor = cantidadPersonas[i];
                indiceMenor = i;
            }
        }

        Console.WriteLine("\n--- RESUMEN DE VISITANTES ---");
        Console.WriteLine("1. Total de visitantes registrados: " + total);
        Console.WriteLine("2. Suma total de acompañantes: " + sumaTotalPersonas);
        Console.WriteLine("3. Registro con MAYOR cantidad de acompañantes: " + nombres[indiceMayor] + " (DNI: " + codigos[indiceMayor] + ") con " + mayorValor + " acompañantes.");
        Console.WriteLine("4. Registro con MENOR cantidad de acompañantes: " + nombres[indiceMenor] + " (DNI: " + codigos[indiceMenor] + ") con " + menorValor + " acompañantes.");
    }    
}