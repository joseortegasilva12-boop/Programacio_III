using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionariosVehiculos.Modelos
{
    internal class Camion : vehiculo
    {
        public decimal CapacidadCarga { get; set; }
        public int NumeroEjes { get; set; }
        public Camion(int id, string marca, string modelo, int anio, decimal precioBase, decimal carga, int ejes)
            : base(id, marca, modelo, anio, precioBase, Enums.TipoCombustible.Diesel, Enums.EstadoVehiculo.Nuevo)
        {
            CapacidadCarga = carga;
            NumeroEjes = ejes;
        }
        public override decimal CalcularPrecioFinal()
        {
            decimal Preciofinal = PrecioBase + ((CapacidadCarga * 500));
            return Preciofinal;
        }
        public override decimal CalcularComisionVendedor()
        {
            return PrecioBase * 0.07m; // Comisión del 4% sobre el precio base
        }
        public override void GenerarFacturaVenta()
        {
            Console.WriteLine("Factura de Venta:");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Año: {Año}");
            Console.WriteLine($"Precio Final: {CalcularPrecioFinal():C}");
        }
    }
}
