using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    class SeleccionFutbol
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public static int Participantes { get; set; }

        public SeleccionFutbol(int id, string nombre, string apellidos, int edad)
        {
            Id = id;
            Nombre = nombre;
            Apellidos = apellidos;
            Edad = edad;
            Participantes++;
        }

        public void Concentrarse()
        {
            Console.WriteLine($"{Nombre} {Apellidos} se esta concentrando...");
        }
        public void Viajar(string lugar)
        {
            Console.WriteLine($"{Nombre} {Apellidos} se ha ido de viaje a {lugar}");
        }
        public virtual void MostrarDatos()
        {
            Console.WriteLine("------DATOS------");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Apellidos: {Apellidos}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"ID: {Id}");
        }
        public virtual void Accion()
        {
            Console.Write($"{Nombre} {Apellidos} esta ");
        }
    }
}
