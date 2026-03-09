using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionariosVehiculos.Modelos
{
    internal class Auto : vehiculo
    {
        public int NumeroPuertas { get; set; }
        public bool TieneAireAcondicionado { get; set; }

        public Auto(int id, string marca, string modelo, int anio, decimal precioBase, int puertas, bool aire)
            : base(id, marca, modelo, anio, precioBase, Enums.TipoCombustible.Gasolina, Enums.EstadoVehiculo.Nuevo)
        {
            NumeroPuertas = puertas;
            TieneAireAcondicionado = aire;
        }

        public override decimal CalcularPrecioFinal()
        {
            decimal Preciofinal = PrecioBase + (AireAcondicionado ? 2000 : 0);
        }
        public override decimal CalcularComisionVendedor()
        {
            return PrecioBase * 0.03m; // Comisión del 3% sobre el precio base
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
