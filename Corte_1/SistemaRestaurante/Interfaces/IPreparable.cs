using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoParcial3.SistemaRestaurante.Interfaces
{
    public interface IPreparable
    {
        TimeSpan CalcularTiempoPreparacion();
        void GenerarOrdenCocina();
        decimal CalcularCostoTotal();
    }
}
