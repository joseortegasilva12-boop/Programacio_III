using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_inventario.models
{
    public class Videojuego
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Genero { get; set; }
        public string Plataforma { get; set; }
        public decimal Precio { get; set; }
        public int StockInicial { get; set; }

        public Videojuego() { }

        public Videojuego(string codigo, string nombre, string genero,
                          string plataforma, decimal precio, int stockInicial)
        {
            Codigo = codigo;
            Nombre = nombre;
            Genero = genero;
            Plataforma = plataforma;
            Precio = precio;
            StockInicial = stockInicial;
        }

        public string ToCsv() =>
            $"{Codigo},{Nombre},{Genero},{Plataforma},{Precio},{StockInicial}";

        public static Videojuego FromCsv(string linea)
        {
            var d = linea.Split(',');
            return new Videojuego(
                d[0].Trim(), d[1].Trim(), d[2].Trim(), d[3].Trim(),
                decimal.TryParse(d[4].Trim(), out var p) ? p : 0,
                int.TryParse(d[5].Trim(), out var s) ? s : 0
            );
        }

        public override string ToString() => $"{Codigo} — {Nombre}";
    }
}