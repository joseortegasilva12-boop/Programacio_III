using ConcesionarioVehiculos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ejemplo de uso
Auto miAuto = new Auto(1, "Toyota", "Corolla", 2024, 25000, 4, true);
Motocicleta miMoto = new Motocicleta(2, "Yamaha", "R6", 2023, 12000, 600, true);
Camion miCamion = new Camion(3, "Volvo", "FH16", 2022, 80000, 20, 4);

List<vehiculo> inventario = new List<vehiculo> { miAuto, miMoto, miCamion };

foreach (var v in inventario)
{
    v.MostrarSpecifications();
    v.GenerarFacturaVenta();
    Console.WriteLine($"Comisión: {v.CalcularComisionVendedor():C}");
    Console.WriteLine("-----------------------------");
}
