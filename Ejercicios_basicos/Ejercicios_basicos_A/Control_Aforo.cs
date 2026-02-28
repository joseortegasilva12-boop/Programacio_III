using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_basicos.Ejercicios_basicos
{
    internal class Control_Aforo
    {
        static void Main(string[] args)
        {
            
            int PuestosOcupados = 0;
            while (true)
            {
                int PuestosMaximos = 50;
                int EspaciosDisponibles = PuestosMaximos - PuestosOcupados;

                Console.WriteLine("¿Cuántas personas quieren entrar a la discoteca?: ");
                int PersonasEntrando = 10;

                if (PersonasEntrando <= EspaciosDisponibles)
                {
                    PuestosOcupados += PersonasEntrando;
                    Console.WriteLine("¡Bienvenidos a la discoteca!");
                    Console.WriteLine("Espacios ocupados: " + PuestosOcupados + "/50");
                }
                else
                {
                    int debenSalir = PersonasEntrando - EspaciosDisponibles;
                    Console.WriteLine("Lo siento, no hay suficiente espacio para todos.");
                    Console.WriteLine("Para que puedan entrar, deben salir " + debenSalir + " personas.");
                }

                Console.ReadLine();
                Console.Clear();
                break;
            }
        }

    }
}
