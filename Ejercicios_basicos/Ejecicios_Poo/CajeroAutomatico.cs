using System;

/*-Simulador de Cajero Automático (Clase Cuenta)
Objetivo: Crear una clase que gestione el dinero de un usuario.
Clase: CuentaBancaria .
Propiedades: Titular (cadena) y Saldo(decimal).
Métodos:
ConsultarSaldo(): Muestra el saldo actual.
Depositar(decimal cantidad): Suma al saldo (validar que la cantidad sea positiva).
Retirar(decimal cantidad): Resta al saldo (validar que tenga fondos suficientes).
Interacción: El usuario debe ingresar su nombre al inicio y luego elegir opciones de un menú para depositar o retirar dinero repetidamente.
 */

namespace Ejercicios_basicos.Ejercicios_basicos
{
    class CuentaBancaria
    {
        public string Titular { get; set; }
        private decimal Saldo;
        public CuentaBancaria(string nombreTitular, decimal saldoInicial)
        {
            Titular = nombreTitular;
            Saldo = saldoInicial;
        }

        // Método para ver el saldo
        public void ConsultarSaldo()
        {
            Console.WriteLine($"\nSaldo actual de {Titular}: ${Saldo}");
        }

        // Método para depositar
        public void Depositar(decimal cantidad)
        {
            if (cantidad > 0)
            {
                Saldo += cantidad;
                Console.WriteLine($" Se han depositado: ${cantidad}");
            }
            else
            {
                Console.WriteLine(" Error: La cantidad a depositar debe ser positiva.");
            }
        }

        // Método para retirar
        public void Retirar(decimal cantidad)
        {
            if (cantidad <= 0)
            {
                Console.WriteLine(" Error: Cantidad no válida.");
            }
            else if (cantidad > _saldo)
            {
                Console.WriteLine(" Fondos insuficientes para esta operación.");
            }
            else
            {
                Saldo -= cantidad;
                Console.WriteLine($" Retiro exitoso: ${cantidad}");
            }
        }
    }

    // 2. Interacción con el usuario
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== BIENVENIDO AL CAJERO AUTOMÁTICO ===");
            Console.Write("Por favor, ingrese su nombre: ");
            string nombre = Console.ReadLine();

            // Creamos la cuenta con un saldo inicial de $0
            CuentaBancaria miCuenta = new CuentaBancaria(nombre, 0);

            bool salir = false;
            do
            {
                Console.WriteLine("\n--- MENÚ DE OPERACIONES ---");
                Console.WriteLine("1. Consultar Saldo");
                Console.WriteLine("2. Depositar Dinero");
                Console.WriteLine("3. Retirar Dinero");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        miCuenta.ConsultarSaldo();
                        break;
                    case "2":
                        Console.Write("Monto a depositar: ");
                        decimal deposito = decimal.Parse(Console.ReadLine());
                        miCuenta.Depositar(deposito);
                        break;
                    case "3":
                        Console.Write("Monto a retirar: ");
                        decimal retiro = decimal.Parse(Console.ReadLine());
                        miCuenta.Retirar(retiro);
                        break;
                    case "0":
                        salir = true;
                        Console.WriteLine("Gracias por usar nuestros servicios. ¡Buen día!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

            } while (!salir);
        }
    }
}