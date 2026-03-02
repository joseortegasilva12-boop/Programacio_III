using System;

/*Calculadora de Calificaciones (Clase Estudiante)

Objetivo: Procesar las notas de un alumno.
Clase: Estudiante.
Propiedades: Nombre, Materia y una lista o arreglo de Notas (3 parciales).
Métodos:
CalcularPromedio(): Devuelve el promedio de las 3 notas.
EstadoFinal(): Devuelve "Aprobado" si el promedio es >= 3.0 o "Reprobado" de lo contrario.
Interacción: El usuario ingresa el nombre del estudiante, la materia y las 3 notas una por una. 
Al final, el programa muestra el promedio y el estado.
 */

namespace Ejercicios_basicos.Ejercicios_basicos
{
    // 1. Definición de la Clase Estudiante
    class Estudiante
    {
        public string Nombre { get; set; }
        public string Materia { get; set; }
        public double[] Notas { get; set; } // Arreglo para los 3 parciales

        public Estudiante(string nombre, string materia)
        {
            Nombre = nombre;
            Materia = materia;
            Notas = new double[3]; // Inicializamos el espacio para 3 notas
        }

        // Método para calcular el promedio
        public double CalcularPromedio()
        {
            double suma = 0;
            foreach (double nota in Notas)
            {
                suma += nota;
            }
            return suma / Notas.Length;
        }

        // Método para determinar si aprobó
        public string EstadoFinal()
        {
            double promedio = CalcularPromedio();
            return (promedio >= 3.0) ? "APROBADO" : "REPROBADO";
        }

        // Método para mostrar el reporte completo
        public void MostrarReporte()
        {
            double promedio = CalcularPromedio();
            Console.WriteLine("\n--- REPORTE ACADÉMICO ---");
            Console.WriteLine($"Estudiante: {Nombre}");
            Console.WriteLine($"Materia:    {Materia}");
            Console.WriteLine($"Promedio:   {promedio:F2}"); // F2 formatea a 2 decimales
            Console.WriteLine($"Estado:     {EstadoFinal()}");
            Console.WriteLine("--------------------------");
        }
    }

    // 2. Interacción con el Usuario
    class RegistroCalificaciones
    {
        static void Main()
        {
            Console.WriteLine("=== SISTEMA DE CALIFICACIONES ===");

            Console.Write("Ingrese el nombre del estudiante: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese la materia: ");
            string materia = Console.ReadLine();

            // Creamos el objeto
            Estudiante alumno = new Estudiante(nombre, materia);

            // Captura de notas
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Ingrese la nota del Parcial {i + 1}: ");
                // Guardamos la nota directamente en el arreglo del objeto
                alumno.Notas[i] = double.Parse(Console.ReadLine());
            }

            // Resultado
            alumno.MostrarReporte();
        }
    }
}
