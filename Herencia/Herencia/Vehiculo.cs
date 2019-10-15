using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    class Vehiculo
    {
        public int Caballos { get; set; }
        public string Marca { get; set; }

        public Vehiculo(int caballos)
        {
            Caballos = caballos;
        }
        public Vehiculo(int caballos, string marca)
        {
            Caballos = caballos;
            Marca = marca;
        }
        public void Arrancar()
        {
            Console.WriteLine("El vehiculo esta en marcha");
        }
        public void Detener()
        {
            Console.WriteLine("El vehiculo se ha detenido");
        }
    }
}
