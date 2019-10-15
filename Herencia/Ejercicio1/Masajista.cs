using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    class Masajista: SeleccionFutbol
    {
        public string Titulacion { get; set; }
        public int AniosExperiencia { get; set; }

        public Masajista(string titulacion, int aniosExperiencia, int id, string nombre, string apellidos, int edad):base(id,nombre,apellidos,edad)
        {
            Titulacion = titulacion;
            AniosExperiencia = aniosExperiencia;
        }
        public override void Accion()
        {
            base.Accion();
            Console.Write($"dando masajes a quien lo necesita \n");

        }
        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine($"Titulación: {Titulacion}");
            Console.WriteLine($"Años de Experiencia: {AniosExperiencia}");
        }
    }
}
