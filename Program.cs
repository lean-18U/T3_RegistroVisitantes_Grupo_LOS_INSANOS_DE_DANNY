using System;

class Program
{
    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("----------REGISTRO DE VISITANTES----------");
            Console.WriteLine("1. Registrar visitante");
            Console.WriteLine("2. Mostrar visitantes");
            Console.WriteLine("3. Buscar visitante por código");
            Console.WriteLine("4. Modificar visitante");
            Console.WriteLine("5. Insertar visitante");
            Console.WriteLine("6. Eliminar visitante");
            Console.WriteLine("7. Ordenar visitantes");
            Console.WriteLine("8. Mostrar resumen");
            Console.WriteLine("9. Salir");

            Console.Write("Seleccione una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

        } while (opcion != 9);
    }
}