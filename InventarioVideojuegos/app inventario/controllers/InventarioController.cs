using System.Collections.Generic;
using System.IO;
using System.Linq;
using app_inventario.models;

namespace app_inventario.controllers
{
    /// <summary>
    /// Controlador para entradas, salidas y cálculo de stock actual.
    /// </summary>
    public class InventarioController
    {
        private readonly string _rutaEntradas;
        private readonly string _rutaSalidas;
        private readonly ProductosController _productosCtrl;

        private const string CAB_MOV = "Fecha,CodigoProducto,Cantidad,Observacion";

        public InventarioController(
            ProductosController productosCtrl,
            string rutaEntradas = "entradas.csv",
            string rutaSalidas  = "salidas.csv")
        {
            _productosCtrl = productosCtrl;
            _rutaEntradas  = rutaEntradas;
            _rutaSalidas   = rutaSalidas;

            if (!File.Exists(_rutaEntradas))
                File.WriteAllText(_rutaEntradas, CAB_MOV + "\n");
            if (!File.Exists(_rutaSalidas))
                File.WriteAllText(_rutaSalidas, CAB_MOV + "\n");
        }

        // ─── Entradas ──────────────────────────────────────────────────────

        public List<Movimiento> ObtenerEntradas()
        {
            var lista = new List<Movimiento>();
            foreach (var l in File.ReadAllLines(_rutaEntradas).Skip(1))
            {
                if (!string.IsNullOrWhiteSpace(l))
                    lista.Add(Movimiento.FromCsv(l, TipoMovimiento.Entrada));
            }
            return lista;
        }

        public void RegistrarEntrada(Movimiento m)
        {
            m.Tipo = TipoMovimiento.Entrada;
            File.AppendAllText(_rutaEntradas, m.ToCsv() + "\n");
        }

        // ─── Salidas ───────────────────────────────────────────────────────

        public List<Movimiento> ObtenerSalidas()
        {
            var lista = new List<Movimiento>();
            foreach (var l in File.ReadAllLines(_rutaSalidas).Skip(1))
            {
                if (!string.IsNullOrWhiteSpace(l))
                    lista.Add(Movimiento.FromCsv(l, TipoMovimiento.Salida));
            }
            return lista;
        }

        /// <summary>
        /// Registra una salida. Retorna false si no hay stock suficiente.
        /// </summary>
        public bool RegistrarSalida(Movimiento m)
        {
            int stockActual = CalcularStock(m.CodigoProducto);
            if (m.Cantidad > stockActual) return false;

            m.Tipo = TipoMovimiento.Salida;
            File.AppendAllText(_rutaSalidas, m.ToCsv() + "\n");
            return true;
        }

        // ─── Stock ─────────────────────────────────────────────────────────

        /// <summary>Calcula el stock actual de un producto.</summary>
        public int CalcularStock(string codigo)
        {
            var vj = _productosCtrl.BuscarPorCodigo(codigo);
            if (vj == null) return 0;

            int entradas = ObtenerEntradas()
                .Where(m => m.CodigoProducto == codigo)
                .Sum(m => m.Cantidad);

            int salidas = ObtenerSalidas()
                .Where(m => m.CodigoProducto == codigo)
                .Sum(m => m.Cantidad);

            return vj.StockInicial + entradas - salidas;
        }

        /// <summary>Retorna el resumen de stock de todos los productos.</summary>
        public List<Inventario> ObtenerResumenStock()
        {
            var entradas = ObtenerEntradas();
            var salidas  = ObtenerSalidas();

            return _productosCtrl.ObtenerTodos().Select(vj => new Inventario
            {
                Codigo        = vj.Codigo,
                Nombre        = vj.Nombre,
                StockInicial  = vj.StockInicial,
                TotalEntradas = entradas.Where(m => m.CodigoProducto == vj.Codigo).Sum(m => m.Cantidad),
                TotalSalidas  = salidas.Where(m => m.CodigoProducto == vj.Codigo).Sum(m => m.Cantidad),
            }).ToList();
        }

        /// <summary>Retorna todos los movimientos combinados ordenados por fecha.</summary>
        public List<Movimiento> ObtenerTodosMovimientos()
        {
            var todos = new List<Movimiento>();
            todos.AddRange(ObtenerEntradas());
            todos.AddRange(ObtenerSalidas());
            return todos.OrderByDescending(m => m.Fecha).ToList();
        }
    }
}
