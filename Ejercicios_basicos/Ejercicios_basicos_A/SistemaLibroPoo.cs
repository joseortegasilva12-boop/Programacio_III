using System;

/*Sistema de Biblioteca: Crea una clase Libroque tenga un estado (Disponible o Prestado). 
 * Crea un método Prestar()para cambiar el estado solo si el libro está disponible.
 */

class Libro
{
    public string Titulo { get; set; }

    private bool Disponible { get; set; } = true; // Por defecto, el libro está disponible
    
    public Libro(string titulo)
    {
        Titulo = titulo;
    }
    public void Prestar()
    {
        if (Disponible)
        {
            Disponible = false;
            Console.WriteLine($"Has prestado el libro: {Titulo}");
        }
        else
        {
            Console.WriteLine($"Lo siento, el libro '{Titulo}' no está disponible en este momento.");
        }
    }

    
}