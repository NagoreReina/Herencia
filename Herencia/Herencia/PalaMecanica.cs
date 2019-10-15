using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    class PalaMecanica:Vehiculo
    {
        public int PesoMaximoLevante { get; set; }

        public PalaMecanica(int pesoMaximoLevante, int caballos, string marca):base(caballos, marca)
        {
            PesoMaximoLevante = pesoMaximoLevante;
        }
    }
}
