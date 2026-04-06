using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipoParcial3.SistemaRestaurante.Enums;
using TipoParcial3.SistemaRestaurante.Modelos;

namespace SistemaRestaurante
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            bool salir = false;

            while (salir == false)
            {
                Console.Clear();

                Console.WriteLine("========MENU DE REGISTRO DE PLATOS======");

                Console.WriteLine("1_Registrar Entrada");
                Console.WriteLine("2_Registrar Plato Principal");
                Console.WriteLine("3_Registrar Postre");
                Console.WriteLine("4_Salir");

                Console.Write("Seleccione una opcion: ");

                int opcion = int.Parse(Console.ReadLine());

                if (opcion == 4)
                {
                    salir = true;
                    Console.WriteLine("saliendooo");
                }
                else
                {
                    Console.Clear();
                    // Pedir datos comunes
                    Console.WriteLine("--- DATOS GENERALES ---");
                    Console.Write("Ingrese el id: ");
                    string id = Console.ReadLine();
                    Console.Write("Ingrese el nombre: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Ingrese la descripcion: ");
                    string descripcion = Console.ReadLine();
                    Console.Write("Ingrese el precio base: ");
                    decimal preciobase = decimal.Parse(Console.ReadLine());

                    TipoComida tipo = CalcularTipoComida();
                    NivelDificultad dificultad = CalcularDificultad();
                    EstadoOrden estado = CalcularEstadoOrden();

                    Console.Clear();
                    Console.WriteLine("--- DETALLES DEL PLATO ---");

                    if (opcion == 1)
                    {
                        Console.WriteLine("¿Es fria? (1 para SI, otro para NO):");
                        bool esfria = false;
                        if (Console.ReadLine() == "1") { esfria = true; }

                        Console.Write("¿Cuantas porciones tiene?: ");
                        int porciones = int.Parse(Console.ReadLine());

                        Entrada e = new Entrada(id, nombre, descripcion, preciobase, tipo, dificultad, estado, esfria, porciones);
                        e.MostrarInformacionNutricional();
                        e.CalcularTiempoPreparacion();
                    }
                    else if (opcion == 2)
                    {
                        Console.Write("¿Cual es la proteina principal?: ");
                        string proteina = Console.ReadLine();
                        Console.WriteLine("¿Incluye guarnicion? (1 para SI, otro para NO):");
                        bool guarnicion = false;
                        if (Console.ReadLine() == "1") { guarnicion = true; }

                        PlatoPrincipal pp = new PlatoPrincipal(id, nombre, descripcion, preciobase, tipo, dificultad, estado, proteina, guarnicion);
                        pp.MostrarInformacionNutricional();
                        pp.CalcularTiempoPreparacion();
                    }
                    else if (opcion == 3)
                    {
                        Console.Write("Ingrese calorias: ");
                        int calorias = int.Parse(Console.ReadLine());
                        Console.WriteLine("¿Contiene lactosa? (1 para SI, otro para NO):");
                        bool lactosa = false;
                        if (Console.ReadLine() == "1") { lactosa = true; }

                        Postre p = new Postre(id, nombre, descripcion, preciobase, tipo, dificultad, estado, calorias, lactosa);
                        p.MostrarInformacionNutricional();
                        p.CalcularTiempoPreparacion();
                    }

                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                }

            }

        }
        private static TipoComida CalcularTipoComida()
        {
            Console.WriteLine("Tipo " +
                "(1:Vegetariana, " +
                "2:Basico, " +
                "3:Carnivora, " +
                "4:Mariscos, " +
                "5:Mixta):");

            int s = int.Parse(Console.ReadLine());
            if (s == 1) return TipoComida.Vegetariana;
            if (s == 2) return TipoComida.Basico;
            if (s == 3) return TipoComida.Carnivora;
            if (s == 4) return TipoComida.Mariscos;
            if (s == 5) return TipoComida.Mixta;
            return TipoComida.Desconocida;
        }

        private static NivelDificultad CalcularDificultad()
        {
            Console.WriteLine("Dificultad " +
                "(1:Facil, " +
                "2:Intermedio, " +
                "3:Avanzado):");
            int s = int.Parse(Console.ReadLine());
            if (s == 1) return NivelDificultad.Facil;
            if (s == 2) return NivelDificultad.Intermedio;
            if (s == 3) return NivelDificultad.Avanzado;
            return NivelDificultad.Desconocido;
        }

        private static EstadoOrden CalcularEstadoOrden()
        {
            Console.WriteLine("Estado " +
                "(1:Pendiente, " +
                "2:Preparado, " +
                "3:Listo, " +
                "4:Entregado):");
            int s = int.Parse(Console.ReadLine());
            if (s == 1) return EstadoOrden.Pendiente;
            if (s == 2) return EstadoOrden.Preparado;
            if (s == 3) return EstadoOrden.Listo;
            if (s == 4) return EstadoOrden.Entregado;
            return EstadoOrden.Desconocido;
        }
    }
}
