
using System;

/*App de Streaming de Música: Crea una interfaz IReproductorcon métodos Play()y Stop(). 
 * Implementa esta interfaz en clases como Canciony Podcast. 
 * El usuario debe poder "darle play" a cualquiera de los dos.
 */

namespace EjerciciosPOOEjercicios_basicos.Ejercicios_basicos
{
    public interface IReproductor
    {
        void Play();
        void Stop();
    }
    //modelo
    class Cancion : IReproductor
    {
        public string Titulo { get; set; }
        public string Artista { get; set; }
        public string Album { get; set; }
        public void Play()
        {
            Console.WriteLine($"Reproduciendo canción: {Titulo} de {Artista} del album {Album}");
        }
        public void Stop()
        {
            Console.WriteLine($"Deteniendo canción: {Titulo} de {Artista} ");
        }
    }
    //modelo
    class Podcast : IReproductor
    {
        public string Tema { get; set; }
        public string Creador { get; set; }
        public string Episodio { get; set; }
        public void Play()
        {
            Console.WriteLine($"Escuchando podcast sobre: {Tema} de {Creador}, episodio {Episodio}");
        }
        public void Stop()
        {
            Console.WriteLine($"Deteniendo podcast sobre: {Tema} de {Creador}, episocio {Episodio}");
        }
    }
    static void Main (string[] args)
    {
            bool continuar = true;

            while (continuar)
            {
                console.WriteLine("========Menu========");
                console.WriteLine("1. Reproducir Canción");
                console.WriteLine("2. Reproducir Podcast");
                console.WriteLine("3. Salir");
                console.WriteLine("Seleccione una opción (1-3): ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Cancion miCancion = new Cancion { Titulo = "Shape of You", Artista = "Ed Sheeran", Album = "Divide" };
                        miCancion.Play();
                        Console.WriteLine("Presione Enter para detener la canción...");
                        Console.ReadLine();
                        miCancion.Stop();
                        break;
                    case 2:
                        Podcast miPodcast = new Podcast { Tema = "Tecnología", Creador = "TechTalks", Episodio = "Episodio 5: El futuro de la IA" };
                        miPodcast.Play();
                        Console.WriteLine("Presione Enter para detener el podcast...");
                        Console.ReadLine();
                        miPodcast.Stop();
                        break;
                    case 3:
                        continuar = false;
                        Console.WriteLine("¡Gracias por usar el reproductor de música!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción del 1 al 3.");
                        break;
                }

            }


        }
}
// Uso: Ambas pueden tratarse como 'IReproductor'