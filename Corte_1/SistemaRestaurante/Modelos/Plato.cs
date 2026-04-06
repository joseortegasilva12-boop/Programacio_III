using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipoParcial3.SistemaRestaurante.Enums;

namespace TipoParcial3.SistemaRestaurante.Modelos
{
    public abstract class Plato
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioBase { get; set; }
        public TipoComida TipoComida { get; set; }
        public NivelDificultad Dificultad { get; set; }
        public EstadoOrden EstadoOrden { get; set; }

        protected Plato(string id, string nombre, string descripcion, decimal preciobase, TipoComida tipocomida, NivelDificultad dificultad, EstadoOrden estadoorden)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.PrecioBase = preciobase;
            this.TipoComida = tipocomida;
            this.Dificultad = dificultad;
            this.EstadoOrden = estadoorden;
        }

        public virtual void MostrarInformacionNutricional()
        {
            Console.WriteLine("////////// DESCRIPCION NUTRICIONAL //////////");
            Console.WriteLine($"ID = {Id}");
            Console.WriteLine($"Nombre = {Nombre}");
            Console.WriteLine($"Precio Base = {PrecioBase}");
            Console.WriteLine($"Dificultad = {Dificultad}");
        }
    }
}