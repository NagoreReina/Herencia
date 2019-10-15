using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    class Futbolista: SeleccionFutbol
    {
        public  int Dorsal { get; set; }
        public  string demarcacion { get; set; }

        public Futbolista(int dorsal, string demarcacion, int id, string nombre, string apellidos, int edad):base(id,nombre,apellidos,edad)
        {
            Dorsal = dorsal;
            this.demarcacion = demarcacion;
        }
        public void JugarPartido()
        {
            Console.WriteLine($"{Nombre} {Apellidos} sale a jugar el partido");
        }
        public override void Accion()
        {
            base.Accion();
            Console.Write($"entrenando \n");

        }
        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine($"Doral: {Dorsal}");
            Console.WriteLine($"Demarcación: {demarcacion}");
        }
    }
}
