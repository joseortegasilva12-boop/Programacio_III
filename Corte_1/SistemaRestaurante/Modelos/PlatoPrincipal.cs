using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipoParcial3.SistemaRestaurante.Interfaces;
using TipoParcial3.SistemaRestaurante.Enums;
using TipoParcial3.SistemaRestaurante.Modelos;

namespace TipoParcial3.SistemaRestaurante.Modelos
{
    public class PlatoPrincipal : Plato, IPreparable
    {
        public string ProteinaPrincipal { get; set; }
        public bool IncluyeGuarnicion { get; set; }

        public PlatoPrincipal(string id, string nombre, string desc, decimal precio, TipoComida tipo, NivelDificultad dif, EstadoOrden est, string proteina, bool guarnicion)
            : base(id, nombre, desc, precio, tipo, dif, est)
        {
            this.ProteinaPrincipal = proteina;
            this.IncluyeGuarnicion = guarnicion;
        }

        public TimeSpan CalcularTiempoPreparacion()
        {
            int minutos = 30 + ((int)Dificultad * 15);
            TimeSpan duracion = TimeSpan.FromMinutes(minutos);
            DateTime entrega = DateTime.Now.Add(duracion);
            Console.WriteLine($"Su pedido sale a las: {entrega:HH:mm:ss}");
            return duracion;
        }

        public decimal CalcularCostoTotal()
        {
            if (Dificultad == NivelDificultad.Intermedio) return PrecioBase * 2;
            if (Dificultad == NivelDificultad.Avanzado) return PrecioBase * 4;
            return PrecioBase;
        }

        public void GenerarOrdenCocina() { /* Vacio */ }
    }
}
