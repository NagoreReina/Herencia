using System;
using System.Collections.Generic;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo v1 = new Vehiculo(120, "Ferrari");
            Automovil a1 = new Automovil(5, 120, "Renault");
            PalaMecanica p1 = new PalaMecanica(140, 60, "Bosch");
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            vehiculos.Add(v1);
            vehiculos.Add(p1);
            vehiculos.Add(a1);
            
        }
    }
}
