using System;

namespace app_inventario.models
{
    public enum TipoMovimiento { Entrada, Salida }

    /// <summary>
    /// Modelo que representa un movimiento de stock (entrada o salida).
    /// </summary>
    public class Movimiento
    {
        public DateTime Fecha { get; set; }
        public string CodigoProducto { get; set; }
        public int Cantidad { get; set; }
        public string Observacion { get; set; }
        public TipoMovimiento Tipo { get; set; }

        public Movimiento() { Fecha = DateTime.Now; }

        public Movimiento(string codigoProducto, int cantidad,
                          string observacion, TipoMovimiento tipo)
        {
            Fecha           = DateTime.Now;
            CodigoProducto  = codigoProducto;
            Cantidad        = cantidad;
            Observacion     = observacion;
            Tipo            = tipo;
        }

        public string ToCsv() =>
            $"{Fecha:dd/MM/yyyy},{CodigoProducto},{Cantidad},{Observacion}";

        public static Movimiento FromCsv(string linea, TipoMovimiento tipo)
        {
            var d = linea.Split(',');
            return new Movimiento
            {
                Fecha          = DateTime.TryParse(d[0].Trim(), out var f) ? f : DateTime.Now,
                CodigoProducto = d[1].Trim(),
                Cantidad       = int.TryParse(d[2].Trim(), out var c) ? c : 0,
                Observacion    = d.Length > 3 ? d[3].Trim() : "",
                Tipo           = tipo
            };
        }
    }
}
