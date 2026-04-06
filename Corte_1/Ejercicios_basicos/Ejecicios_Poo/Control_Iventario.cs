using System;

/*2. Control de Inventario (Clase Producto)
Objetivo: Gestionar la entrada y salida de mercancía.

Clase: Producto.
Propiedades: Nombre, Codigo, Precio y CantidadStock.
Métodos:
AgregarStock(int cantidad): Aumenta el inventario.
VenderProducto(int cantidad): Disminuye el inventario y devuelve el total de la venta (Precio * Cantidad).
MostrarInfo(): Muestra todos los detalles del producto.
Interacción: El usuario ingresa los datos de un producto y luego decide cuántas unidades "entran" al almacén y cuántas se "venden".
*/

namespace Ejercicios_basicos.Ejercicios_basicos
{
    class Producto
    {
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public decimal Precio { get; set; }
        public int CantidadStock { get; private set; } // Solo la clase puede modificar el stock

        public Producto(string nombre, string codigo, decimal precio, int stockInicial)
        {
            Nombre = nombre;
            Codigo = codigo;
            Precio = precio;
            CantidadStock = stockInicial;
        }

        // Método para aumentar inventario
        public void AgregarStock(int cantidad)
        {
            if (cantidad > 0)
            {
                CantidadStock += cantidad;
                Console.WriteLine($" Se agregaron {cantidad} unidades. Nuevo stock: {CantidadStock}");
            }
        }

        // Método para vender
        public void VenderProducto(int cantidad)
        {
            if (cantidad <= 0)
            {
                Console.WriteLine(" La cantidad a vender debe ser mayor a cero.");
            }
            else if (cantidad > CantidadStock)
            {
                Console.WriteLine($" Solo quedan {CantidadStock} unidades.");
            }
            else
            {
                CantidadStock -= cantidad;
                decimal total = cantidad * Precio;
                Console.WriteLine($"   Venta realizada.");
                Console.WriteLine($"   Total a cobrar: ${total}");
                Console.WriteLine($"   Stock restante: {CantidadStock}");
            }
        }

        // Método para mostrar detalles
        public void MostrarInfo()
        {
            Console.WriteLine("\n--- DETALLES DEL PRODUCTO ---");
            Console.WriteLine($"Código: {Codigo}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Precio Unitario: ${Precio}");
            Console.WriteLine($"Stock Disponible: {CantidadStock}");
            Console.WriteLine("------------------------------");
        }
    }

    // 2. Interacción con el usuario
    class RegistrarProducto
    {
        static void Main()
        {
            Console.WriteLine("=== REGISTRO UN NUEVO PRODUCTO ===");

            Console.Write("Nombre del producto: ");
            string nombre = Console.ReadLine();

            Console.Write("Código: ");
            string codigo = Console.ReadLine();

            Console.Write("Precio: ");
            decimal precio = decimal.Parse(Console.ReadLine());

            Console.Write("Cantidad inicial en stock: ");
            int stock = int.Parse(Console.ReadLine());

            // Crear el objeto
            Producto miProducto = new Producto(nombre, codigo, precio, stock);

            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("\n¿Qué desea hacer?");
                Console.WriteLine("1. Ver información");
                Console.WriteLine("2. Agregar stock (Entrada)");
                Console.WriteLine("3. Vender producto (Salida)");
                Console.WriteLine("0. Salir");
                Console.Write("Opción: ");

                string opc = Console.ReadLine();

                switch (opc)
                {
                    case "1":
                        miProducto.MostrarInfo();
                        break;
                    case "2":
                        Console.Write("Cantidad que entra al almacén: ");
                        int entrada = int.Parse(Console.ReadLine());
                        miProducto.AgregarStock(entrada);
                        break;
                    case "3":
                        Console.Write("Cantidad a vender: ");
                        int venta = int.Parse(Console.ReadLine());
                        miProducto.VenderProducto(venta);
                        break;
                    case "0":
                        contisnuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }
}
