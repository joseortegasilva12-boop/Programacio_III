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
    public class Entrada : Plato, IPreparable
    {
        public bool Esfria { get; set; }
        public int Porciones { get; set; }

        public Entrada(string id, string nombre, string desc, decimal precio, TipoComida tipo, NivelDificultad dif, EstadoOrden est, bool esfria, int porciones)
            : base(id, nombre, desc, precio, tipo, dif, est)
        {
            this.Esfria = esfria;
            this.Porciones = porciones;
        }

        public TimeSpan CalcularTiempoPreparacion()
        {
            int minutos = Esfria ? 10 : 20;
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

        public override void MostrarInformacionNutricional()
        {
            base.MostrarInformacionNutricional();
            Console.WriteLine($"Es Fria: {Esfria}");
            Console.WriteLine($"Costo Final: {CalcularCostoTotal()}");
        }
    }
}
