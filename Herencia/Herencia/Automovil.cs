using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    class Automovil : Vehiculo
    {
        public int Puertas { get; set; }

        //Como es una clase hijo, en el constructor se expecifica de manera diferente los atributos que hereda del padre
        public Automovil(int puertas, int caballos, string marca):base(caballos, marca)
        {
            Puertas = puertas;
        }
        public void Acelerar(int cuanto)
        {
            Arrancar();
            Console.WriteLine($"Has acelarado {cuanto} Km/h");
            Detener();
        }
    }
}
