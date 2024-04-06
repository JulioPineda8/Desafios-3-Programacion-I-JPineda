using System;
using System.Collections.Generic;

class Program
{
    static List<string> tareas = new List<string>();

    static void Main(string[] args)
    {
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("===== Menú de Tareas =====");
            Console.WriteLine("1. Mostrar Tareas");
            Console.WriteLine("2. Agregar Tarea");
            Console.WriteLine("3. Eliminar Tarea");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    MostrarTareas();
                    break;
                case "2":
                    AgregarTarea();
                    break;
                case "3":
                    EliminarTarea();
                    break;
                case "4":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void MostrarTareas()
    {
        if (tareas.Count == 0)
        {
            Console.WriteLine("No hay tareas por realizar.");
        }
        else
        {
            Console.WriteLine("===== Tareas por Realizar =====");
            for (int i = 0; i < tareas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tareas[i]}");
            }
        }
    }

    static void AgregarTarea()
    {
        Console.Write("Ingrese la nueva tarea: ");
        string nuevaTarea = Console.ReadLine();
        tareas.Add(nuevaTarea);
        Console.WriteLine("Tarea agregada correctamente.");
    }

    static void EliminarTarea()
    {
        MostrarTareas();

        if (tareas.Count == 0)
        {
            Console.WriteLine("No hay tareas por realizar para eliminar.");
        }
        else
        {
            Console.Write("Ingrese el número de la tarea a eliminar: ");
            if (int.TryParse(Console.ReadLine(), out int indice) && indice >= 1 && indice <= tareas.Count)
            {
                tareas.RemoveAt(indice - 1);
                Console.WriteLine("Tarea eliminada correctamente.");
            }
            else
            {
                Console.WriteLine("Índice no válido. Por favor, ingrese un número de tarea válido.");
            }
        }
    }
}
