using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_basicos.Ejercicios_basicos
{
    internal class Semaforo_Inteligente
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el color actual del semáforo: ");
            string color = "amarillo";

            if (color == "verde")
            {

                Console.WriteLine("Sigue adelante");
            }
            else if (color == "amarillo")
            {

                Console.WriteLine("Prepárate para frenar");
            }
            else if (color == "rojo")
            {

                Console.WriteLine("¡Detente!");
            }
            else
            {
                Console.WriteLine("Color no reconocido");
            }

            Console.ReadLine();
            Console.Clear();
        }

    }
}
