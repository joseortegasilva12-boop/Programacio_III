using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    /*financiamento "AutoYa"
     * objetivo: cacalcular la tabla de amortización de un préstamo para la compra de un vehiculo.
     *  ¿que se debe hacer?
     *  1. entrada: solicite al usuario el vaor del vehiculo, el interes mensual (%) y la cantidad de cuotas
     *  2. calculo: calcule la cuota mensual y desglose cuando va a capital y cuanto a interes mes a mes
     *  3. salidad: muestre la tabla con:#Mes, Fecha de pago(incrementando un mes desde hoy con DateTime), Abono a capital, interes y saldo
     * 4. resumen: al final de la tabla muestre el total pagado y el total de intereses acumulados durante el credito.
     */
namespace parcial_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Ingrese el valor del vehiculo:");
                double valorVehiculo = double.Parse(Console.ReadLine());
    
                Console.WriteLine("Ingrese el interes mensual (%):");
                double interesMensual = double.Parse(Console.ReadLine()) / 100;
    
                Console.WriteLine("Ingrese la cantidad de cuotas:");
                int cantidadCuotas = int.Parse(Console.ReadLine());
    
                double cuotaMensual = valorVehiculo / cantidadCuotas;
                double saldo = valorVehiculo;
                double totalPagado = 0;
                double totalIntereses = 0;
                double interesMes = saldo * interesMensual;
                double totalTabla = cuotaMensual + interesMes;

            Console.WriteLine("Mes\tFecha de Pago\tCapital\tInteres\tTotal");
                for (int mes = 1; mes <= cantidadCuotas; mes++)
                {
                    DateTime fechaPago = DateTime.Now.AddMonths(mes);
                    
                    
                    totalPagado += cuotaMensual;
                    totalIntereses += interesMes;
    
                    Console.WriteLine($"{mes}\t{fechaPago.ToShortDateString()}\t{cuotaMensual}\t{interesMes:F2}\t{totalTabla}");
                }

            double total = 0;
            total = totalPagado + totalIntereses;


            Console.WriteLine($"\nTotal Pagado: {total:F2}");
                Console.WriteLine($"Total Intereses : {totalIntereses:F2}");

        }
    }
}
