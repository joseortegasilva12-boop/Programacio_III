using SistemaEnvios.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEnvios.Modelos
{
    class Paquete
    {
        public int Guia { get; set; }
        public string Destinatario { get; set; }
        public double Peso { get; set; }
        public TipoPaquete Tipo { get; set; }


        public Paquete(int guia, string destinatario, double peso, TipoPaquete tipo)
        {
            Guia = guia;
            Destinatario = destinatario;
            Peso = peso;
            Tipo = tipo;
        }
        public string ACsv() => $"{Guia};{Destinatario};{Peso};{Tipo}";
    }
}
