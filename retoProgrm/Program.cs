using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace retoProgrm
{
    class Amigo
    {
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Amigo(string nombre, DateTime fechaNacimiento)
        {
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
        }

        public int DiasParaCumpleanos()
        {
            DateTime hoy = DateTime.Today;

            
            DateTime cumpleEsteAno = new DateTime(hoy.Year, FechaNacimiento.Month, FechaNacimiento.Day);

            
            if (cumpleEsteAno < hoy)
            {
                cumpleEsteAno = cumpleEsteAno.AddYears(1);
            }

            
            if (cumpleEsteAno == hoy)
            {
                return 0;
            }

            return (cumpleEsteAno - hoy).Days;
        }
    }

    class GestorCumpleanos
    {
        static void Main(string[] args)
        {
            string archivo = "cumpleaños.txt";
            Amigo[] amigos = new Amigo[3];

            Console.WriteLine("=== GESTOR DE CUMPLEAÑOS ===\n");

            
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"--- Amigo {i + 1} ---");

                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();

                DateTime fecha;
                while (true)
                {
                    Console.Write("Fecha de nacimiento (DD/MM/YYYY): ");
                    string input = Console.ReadLine();

                    if (DateTime.TryParseExact(input, "dd/MM/yyyy",
                        System.Globalization.CultureInfo.InvariantCulture,
                        System.Globalization.DateTimeStyles.None, out fecha))
                    {
                        break;
                    }

                    Console.WriteLine("Formato inválido. Usa DD/MM/YYYY (ej: 20/03/1995)");
                }

                amigos[i] = new Amigo(nombre, fecha);
                Console.WriteLine();
            }

            
            Console.WriteLine("===RESULTADOS ===\n");

            using (StreamWriter writer = new StreamWriter(archivo, append: false))
            {
                writer.WriteLine("=== Lista de Amigos Registrados ===");
                writer.WriteLine($"Generado el: {DateTime.Now:dd/MM/yyyy HH:mm:ss}");
                writer.WriteLine();

                foreach (Amigo amigo in amigos)
                {
                    int dias = amigo.DiasParaCumpleanos();

                    
                    if (dias == 0)
                        Console.WriteLine($" ¡Hoy es el cumpleaños de {amigo.Nombre}!");
                    else
                        Console.WriteLine($"A {amigo.Nombre} le faltan {dias} días para su cumpleaños.");

                    
                    writer.WriteLine($"{amigo.Nombre} - {amigo.FechaNacimiento:dd/MM/yyyy}");
                }
            }
        }
    }

}
