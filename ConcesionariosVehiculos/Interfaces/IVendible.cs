using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcesionariosVehiculos.Interfaces
{
    internal interface IVendible
    {
        decimal CalcularPrecioFinal();
        void GenerarFacturaVenta();
        decimal CalcularComisionVendedor();
    }
}
