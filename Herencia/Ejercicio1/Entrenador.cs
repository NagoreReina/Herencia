using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    class Entrenador:SeleccionFutbol
    {
        public string IdFederacion { get; set; }

        public Entrenador(string idFederacion, int id, string nombre, string apellidos, int edad):base(id,nombre,apellidos,edad)
        {
            IdFederacion = idFederacion;
        }
        public void DirigirPartido()
        {
            Console.WriteLine($"{Nombre} {Apellidos} se ha puesto a dirigir el partido");
        }
        public override void Accion()
        {
            base.Accion();
            Console.Write($"dirigiendo el entrenamiento \n");

        }
        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine($"Id Federacion: {IdFederacion}");
        }
    }
}
