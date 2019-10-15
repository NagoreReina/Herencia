using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    class SeleccionPais
    {
        public string Pais { get; set; }
        public List<SeleccionFutbol> Participantes { get; set; }
        public int NParticipantes { get; set; }

        public SeleccionPais(string pais, List<SeleccionFutbol> participantes)
        {
            Pais = pais;
            Participantes = participantes;
            NParticipantes = participantes.Count;
        }
        public void MostrarDatosSeleccion()
        {
            Console.WriteLine("------DATOS SELECCION-------");
            Console.WriteLine($"Pais: {Pais}");
            Console.WriteLine($"Nº Participantes: {NParticipantes}");
            foreach (SeleccionFutbol persona in Participantes)
            {
                persona.MostrarDatos();
            }
        }
        public bool AltaSeleccion(SeleccionFutbol nuevoParticipante)
        {
            if (NParticipantes < 30)
            {
                if (nuevoParticipante is Futbolista)
                {
                    Participantes.Add(nuevoParticipante);
                    NParticipantes++;
                    return true;
                }
                else
                {
                    int numMasajistas = 0;
                    int numEntrenadores = 0;
                    foreach (SeleccionFutbol persona in Participantes)
                    {
                        if (persona is Masajista)
                        {
                            numMasajistas++;
                        }
                        else if (persona is Entrenador)
                        {
                            numEntrenadores++;
                        }
                    }
                    if (nuevoParticipante is Masajista && numMasajistas < 4)
                    {
                        Participantes.Add(nuevoParticipante);
                        NParticipantes++;
                        return true;
                    }
                    else if (nuevoParticipante is Entrenador && numEntrenadores < 2)
                    {
                        Participantes.Add(nuevoParticipante);
                        NParticipantes++;
                        return true;
                    }
                }
            }
            return false;
        }
        public bool BajaSeleccion(int id)
        {
            foreach (SeleccionFutbol persona in Participantes)
            {
                if (persona.Id == id)
                {
                    Participantes.Remove(persona);
                    NParticipantes--;
                    return true;
                }
            }
            return false;
        }
    }
}
