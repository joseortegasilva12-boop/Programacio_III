using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionariosVehiculos.Modelos
{
    internal class Motocicleta : vehiculo
    {
        public int Cilindraje { get; set; }
        public bool Esdeportista { get; set; }

        public Motocicleta(int id, string marca, string modelo, int anio, decimal precioBase, int cilindraje, bool deportiva)
            : base(id, marca, modelo, anio, precioBase, Enums.TipoCombustible.Gasolina, Enums.EstadoVehiculo.Nuevo)
        {
            Cilindraje = cilindraje;
            EsDeportiva = deportiva;
        }

        public override decimal CalcularPrecioFinal()
        {
            decimal Preciofinal = PrecioBase + (EsDeportiva ? 10 : 0);
            return Preciofinal;
        }
        public override decimal CalcularComisionVendedor()
        {
            return PrecioBase * 0.05m; // Comisión del 5% sobre el precio base
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
