using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipoParcial3.SistemaRestaurante.Enums;
using TipoParcial3.SistemaRestaurante.Interfaces;
using TipoParcial3.SistemaRestaurante.Modelos;

namespace TipoParcial3.SistemaRestaurante.Modelos
{
    public class Postre : Plato, IPreparable
    {
        public bool ContieneLactosa { get; set; }
        public int CaloriasPorPorcion { get; set; }

        public Postre(string id, string nombre, string descripcion, decimal precioBase, TipoComida tipo, NivelDificultad dificultad, EstadoOrden estado, int calorias, bool lactosa)
            : base(id, nombre, descripcion, precioBase, tipo, dificultad, estado)
        {
            CaloriasPorPorcion = calorias;
            ContieneLactosa = lactosa;
        }

        public TimeSpan CalcularTiempoPreparacion()
        {
            int tiempo = 25 + (ContieneLactosa ? 5 : 0);
            TimeSpan duracion = TimeSpan.FromMinutes(tiempo);
            DateTime entrega = DateTime.Now.Add(duracion);
            Console.WriteLine($"Tiempo de preparación estimado: {tiempo} min. Su pedido sale a las: {entrega:HH:mm:ss}");
            return duracion;
        }

        public decimal CalcularCostoTotal()
        {
            if (Dificultad == NivelDificultad.Intermedio) return PrecioBase * 2;
            if (Dificultad == NivelDificultad.Avanzado) return PrecioBase * 4;
            return PrecioBase;
        }

        public void GenerarOrdenCocina()
        {
            // Implementación mínima: podría enviar datos a cocina
        }

        public override void MostrarInformacionNutricional()
        {
            base.MostrarInformacionNutricional();
            Console.WriteLine($"Calorías: {CaloriasPorPorcion} kcal | Lactosa: {(ContieneLactosa ? "Sí" : "No")}");
        }
    }
}
