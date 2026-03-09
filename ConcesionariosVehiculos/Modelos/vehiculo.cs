using ConcesionariosVehiculos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionariosVehiculos.Modelos
{
    public abstract class vehiculo : IVendible
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }  
        public int Año { get; set; }
        public decimal PrecioBase { get; set; }
        public TipoCombustible Combustible { get; set; }
        public EstadoVehiculo Estado { get; set; }

        protected vehiculo(int id, string marca, string modelo, int año, decimal precioBase, TipoCombustible combustible, EstadoVehiculo estado)
        {
            Id = id;
            Marca = marca;
            Modelo = modelo;
            Año = año;
            PrecioBase = precioBase;
            Combustible = combustible;
            Estado = estado;
        }

        public virtual void MostrarEspesificaciones()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Año: {Año}");
            Console.WriteLine($"Precio Base: {PrecioBase:C}");
            Console.WriteLine($"Tipo de Combustible: {Combustible}");
            Console.WriteLine($"Estado del Vehículo: {Estado}");
        }

        // Métodos de la interfaz que deben implementar las clases hijas
        public abstract decimal CalcularPrecioFinal();
        public abstract void GenerarFacturaVenta();
        public abstract decimal CalcularComisionVendedor();


    }
}
