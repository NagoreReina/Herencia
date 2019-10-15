using System;
using System.Collections.Generic;

namespace Ejercicio1
{
    class Program
    {
        static List<SeleccionFutbol> seleccionFutbol = new List<SeleccionFutbol>();
        static SeleccionPais espania = new SeleccionPais("España", seleccionFutbol);
        static void Main(string[] args)
        {
            seleccionFutbol.Add(new Entrenador("12345QWE", 1, "Paco", "Garcia Santos", 49));
            seleccionFutbol.Add(new Masajista("FP Masajista", 5, 2, "Marcos", "Sanchez Reyes", 31));
            seleccionFutbol.Add(new Masajista("FP Masajista", 2, 3, "Lucia", "Tenor Leña", 26));
            seleccionFutbol.Add(new Futbolista(1, "Delantera", 4, "Marta", "Orozco Garcia", 23));
            seleccionFutbol.Add(new Futbolista(2, "Defensa", 5, "Sara", "Mayor Dentista", 25));
            seleccionFutbol.Add(new Futbolista(3, "Centro", 6, "Blanca", "Gutierrez Fernandez", 21));
            seleccionFutbol.Add(new Futbolista(4, "Defensa", 7, "Nuria", "Martinez Fernandez", 27));
            espania.Participantes = seleccionFutbol;
            espania.NParticipantes = seleccionFutbol.Count;
            //foreach (SeleccionFutbol persona in seleccionFutbol)
            //{
            //    persona.MostrarDatos();
            //}
            //Console.WriteLine("____________________________________________");
            //foreach (SeleccionFutbol persona in seleccionFutbol)
            //{
            //    persona.Viajar("Londres");
            //    persona.Concentrarse();
            //}
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("Ya han llegado todos al destino");
            //Console.ForegroundColor = ConsoleColor.White;
            //foreach (SeleccionFutbol persona in seleccionFutbol)
            //{
            //    persona.Accion();
            //}
            Menu();
        }
        public static void Menu()
        {
            int opcion = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("----- MENU -----");
                Console.WriteLine("1. Alta participante");
                Console.WriteLine("2. Baja participante");
                Console.WriteLine("3. Mostrar Selección");
                Console.WriteLine("4. Salir");
                Console.WriteLine("---------------");
                Console.WriteLine("Introduce tu opción (numero)");
                Console.ForegroundColor = ConsoleColor.White;
                if (ComprobarTexto(out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            DarseDeAlta();
                            break;
                        case 2:
                            DarseDeBaja();
                            break;
                        case 3:
                            espania.MostrarDatosSeleccion();
                            int numMasajistas = 0;
                            int numEntrenadores = 0;
                            int numFutbolistas = 0;
                            foreach (SeleccionFutbol persona in espania.Participantes)
                            {
                                if (persona is Futbolista)
                                {
                                    numFutbolistas++;
                                }
                                else if (persona is Masajista)
                                {
                                    numMasajistas++;
                                }
                                else if (persona is Entrenador)
                                {
                                    numEntrenadores++;
                                }
                            }
                            Console.WriteLine("-----------------------------");
                            Console.WriteLine($"Futbolistas: {numFutbolistas}");
                            Console.WriteLine($"Masajistas: {numMasajistas}");
                            Console.WriteLine($"Entrenadores: {numEntrenadores}");
                            Console.WriteLine("-----------------------------");
                            break;
                        case 4:
                            Console.WriteLine("Vuelve pronto");
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ERROR: Esa opción no existe");
                            Console.ForegroundColor = ConsoleColor.White;

                            break;
                    }
                }
            } while (opcion != 4);

        }
        public static void DarseDeAlta()
        {
            if (espania.NParticipantes < 30)
            {
                bool programaCompleto = false;
                do
                {
                    Console.WriteLine("¿Que tipo de participante quieres añadir?");
                    Console.WriteLine("1. Futbolista");
                    Console.WriteLine("2. Masajista");
                    Console.WriteLine("3. Entrenador");
                    Console.WriteLine("4. Salir");
                    int opcion = 0;
                    if (ComprobarTexto(out opcion))
                    {
                        int numMasajistas = 0;
                        int numEntrenadores = 0;
                        foreach (SeleccionFutbol persona in espania.Participantes)
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
                        switch (opcion)
                        {
                            //FUTBOLISTA
                            case 1:
                                Console.WriteLine("Introduce el nombre");
                                string nombre = Console.ReadLine();
                                Console.WriteLine("Introduce los apellidos");
                                string apellidos = Console.ReadLine();
                                Console.WriteLine("Introduce la demarcación");
                                string demarcacion = Console.ReadLine();
                                Console.WriteLine("Introduce la edad");
                                int edad = 0;
                                ComprobarTexto(out edad);
                                Random id = new Random();
                                Console.WriteLine("Introduce el dorsal");
                                int dorsal = 0;
                                ComprobarTexto(out dorsal);
                                

                                Futbolista futbolista = new Futbolista(dorsal, demarcacion, id.Next(0,10001), nombre, apellidos, edad);
                                espania.AltaSeleccion(futbolista);
                                programaCompleto = true;
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("Añadido a la lista");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;

                            //MASAJISTA
                            case 2:
                                if (numMasajistas < 4)
                                {
                                    Console.WriteLine("Introduce el nombre");
                                    nombre = Console.ReadLine();
                                    Console.WriteLine("Introduce los apellidos");
                                    apellidos = Console.ReadLine();
                                    Console.WriteLine("Introduce la edad");
                                    edad = 0;
                                    ComprobarTexto(out edad);
                                    Console.WriteLine("Introduce la titulación");
                                    string titulacion = Console.ReadLine();
                                    Console.WriteLine("Introduce los años de experiencia");
                                    int aniosExp = 0;
                                    ComprobarTexto(out aniosExp);
                                    id = new Random();

                                    Masajista masajista = new Masajista(titulacion, aniosExp, id.Next(0, 10001), nombre, apellidos, edad);
                                    espania.AltaSeleccion(masajista);
                                    programaCompleto = true;
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("Añadido a la lista");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("ERROR: se ha alcanzado el numero máximo de masajistas, da de baja uno para añadir uno nuevo");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                break;

                            //ENTRENADOR
                            case 3:
                                if (numEntrenadores < 2)
                                {
                                    Console.WriteLine("Introduce el nombre");
                                    nombre = Console.ReadLine();
                                    Console.WriteLine("Introduce los apellidos");
                                    apellidos = Console.ReadLine();
                                    Console.WriteLine("Introduce la edad");
                                    edad = 0;
                                    ComprobarTexto(out edad);
                                    Console.WriteLine("Introduce la id de Federación");
                                    string idFederacion = Console.ReadLine();
                                    id = new Random();

                                    Entrenador entrenador = new Entrenador(idFederacion, id.Next(0, 10001), nombre, apellidos, edad);
                                    espania.AltaSeleccion(entrenador);
                                    programaCompleto = true;
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("Añadido a la lista");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("ERROR: se ha alcanzado el numero máximo de entrenadores, da de baja uno para añadir uno nuevo");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                
                                break;
                            case 4:
                                programaCompleto = true;
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("ERROR: la opción seleccionada no es valida");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                        }
                    }
                } while (!programaCompleto);

               
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: La selección esta completa, para dar de alta a alguien, primero da de baja a una persona");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public static void DarseDeBaja()
        {
            int id = 0;
            Console.WriteLine("Introduce el id del participante");
            ComprobarTexto(out id);
            if (espania.BajaSeleccion(id))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Baja correcta");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: no hay ningun participante con esa ID");
                Console.ForegroundColor = ConsoleColor.White;
            }
            
        }
        public static bool ComprobarTexto(out int opcion)
        {
            bool programaCompleto = false;
            do
            {
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    programaCompleto = true;
                    return true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: Por favor, introduce un numero");
                    Console.ForegroundColor = ConsoleColor.White;

                }
            } while (!programaCompleto);
            return false;
        }

    }
}
