using SistemaEnvios.Enum;
using SistemaEnvios.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEnvios
{
    internal class Program
    {
        const string Archivo = "envios.csv";

        static void Main()
        {
            int opcion;
            do
            {
                Console.WriteLine("\n====== SISTEMA GLOBALSHIP ======");
                Console.WriteLine("1. Nuevo Envío");
                Console.WriteLine("2. Ver Peso Total");
                Console.WriteLine("3. Buscar por Guía");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opción inválida, ingrese un número.");
                    continue;
                }

                switch (opcion)
                {
                    case 1: CrearEnvio(); break;
                    case 2: PesoTotal(); break;
                    case 3: BuscarPorGuia(); break;
                    case 0: Console.WriteLine("¡Hasta luego!"); break;
                    default: Console.WriteLine("Opción no reconocida."); break;
                }
            } while (opcion != 0);
        }

        static void CrearEnvio()
        {
            Console.Write("Guía: ");
            int guia = int.Parse(Console.ReadLine());
            Console.Write("Destinatario: ");
            string destinatario = Console.ReadLine();
            Console.Write("Peso (kg): ");
            double peso = double.Parse(Console.ReadLine());
            Console.Write("Tipo (1.Nacional, 2.Internacional): ");
            int tipoInt = int.Parse(Console.ReadLine());
            Enum.TipoPaquete tipo;

            
            


        }

        
    }
}
