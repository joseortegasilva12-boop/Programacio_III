namespace app_inventario.models
{
    /// <summary>
    /// Modelo auxiliar que representa el stock calculado de un videojuego.
    /// </summary>
    public class Inventario
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int StockInicial { get; set; }
        public int TotalEntradas { get; set; }
        public int TotalSalidas { get; set; }

        public int StockActual => StockInicial + TotalEntradas - TotalSalidas;

        public string EstadoStock
        {
            get
            {
                if (StockActual == 0)   return "Sin stock";
                if (StockActual <= 5)   return "Stock bajo";
                return "Disponible";
            }
        }
    }
}
