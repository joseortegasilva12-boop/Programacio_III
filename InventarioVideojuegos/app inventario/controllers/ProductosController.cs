using System.Collections.Generic;
using System.IO;
using System.Linq;
using app_inventario.models;

namespace app_inventario.controllers
{
    /// <summary>
    /// Controlador CRUD para videojuegos. Lee y escribe en videojuegos.csv.
    /// </summary>
    public class ProductosController
    {
        private readonly string _rutaCsv;
        private const string CABECERA = "Codigo,Nombre,Genero,Plataforma,Precio,StockInicial";

        public ProductosController(string rutaCsv = "videojuegos.csv")
        {
            _rutaCsv = rutaCsv;
            if (!File.Exists(_rutaCsv))
                File.WriteAllText(_rutaCsv, CABECERA + "\n");
        }

        /// <summary>Retorna todos los videojuegos del CSV.</summary>
        public List<Videojuego> ObtenerTodos()
        {
            var lista = new List<Videojuego>();
            foreach (var linea in File.ReadAllLines(_rutaCsv).Skip(1))
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;
                lista.Add(Videojuego.FromCsv(linea));
            }
            return lista;
        }

        /// <summary>Busca un videojuego por código. Retorna null si no existe.</summary>
        public Videojuego BuscarPorCodigo(string codigo) =>
            ObtenerTodos().FirstOrDefault(v => v.Codigo == codigo);

        /// <summary>Agrega un videojuego. Retorna false si el código ya existe.</summary>
        public bool Agregar(Videojuego vj)
        {
            if (BuscarPorCodigo(vj.Codigo) != null) return false;
            File.AppendAllText(_rutaCsv, vj.ToCsv() + "\n");
            return true;
        }

        /// <summary>Elimina un videojuego por código.</summary>
        public bool Eliminar(string codigo)
        {
            var lineas = File.ReadAllLines(_rutaCsv).ToList();
            int antes = lineas.Count;
            lineas.RemoveAll(l => !l.StartsWith("Codigo") && l.Split(',')[0].Trim() == codigo);
            if (lineas.Count == antes) return false;
            File.WriteAllLines(_rutaCsv, lineas);
            return true;
        }

        /// <summary>Actualiza un videojuego existente.</summary>
        public bool Actualizar(Videojuego vjActualizado)
        {
            var lineas = File.ReadAllLines(_rutaCsv).ToList();
            bool encontrado = false;
            for (int i = 1; i < lineas.Count; i++)
            {
                if (string.IsNullOrWhiteSpace(lineas[i])) continue;
                if (lineas[i].Split(',')[0].Trim() == vjActualizado.Codigo)
                {
                    lineas[i] = vjActualizado.ToCsv();
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado) return false;
            File.WriteAllLines(_rutaCsv, lineas);
            return true;
        }
    }
}
