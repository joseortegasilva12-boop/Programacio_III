using System;

/*Control de Vehículos Eléctricos: Crea una clase VehiculoElectricocon un nivel de batería. 
 * Implementa un método Viajar(int km)que reste 1% de batería por cada kilómetro. 
 * Si la batería llega a 0, el coche debe avisar que necesita carga inmediata
 */

class VehiculoElectrico
{
    public string Modelo { get; set; }
    private double NivelBateria { get; set; } = 100.0; // Batería al 100% por defecto
    public VehiculoElectrico(string modelo)
    {
        Modelo = modelo;
    }
    public void Viajar(int km)
    {
        double consumo = km * 1.0; // 1% de batería por km
        if (consumo <= NivelBateria)
        {
            NivelBateria -= consumo;
            Console.WriteLine($"Has viajado {km} km. Nivel de batería restante: {NivelBateria}%");
        }
        else
        {
            Console.WriteLine($"¡Batería agotada! Necesitas cargar tu {Modelo} inmediatamente.");
            NivelBateria = 0; // La batería se agota completamente
        }
    }
}