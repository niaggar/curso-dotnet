using System;
using FirstConsoleApp.models;
using FirstConsoleApp.learnig;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CrearListaDePersonas();
        }

        static void CrearListaDePersonas()
        {
            Console.WriteLine("Numero de persona:");
            int numeroPersonas = int.Parse(Console.ReadLine());

            // Declasracion de Arrays en csharp
            Persona[] listaPersonas = new Persona[numeroPersonas];
            for (int i = 0; i < numeroPersonas; i++)
            {
                listaPersonas[i] = CrearPersona();
            }

            // Metodo para recorrer una lista sin la necesidad de un index
            foreach (Persona persona in listaPersonas)
            {
                persona.Presentarse();
            }
        }

        static Persona CrearPersona()
        { 
            Persona nuevaPersona;

            // Escritura y lectura de datos por consola
            Console.WriteLine("Cual es el nombre?");
            string nombre = Console.ReadLine();

            Console.WriteLine("Cual es la edad?");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Cual es el pais?");
            string pais = Console.ReadLine();

            Console.WriteLine("Es astronauta? (True, False)");
            bool esAstronauta = bool.Parse(Console.ReadLine());

            // Sentencias if
            if (esAstronauta)
            {
                Console.WriteLine("Cual es el tiempo que ha estado en el espacio?");
                int tiempoEnEspacio = int.Parse(Console.ReadLine());

                nuevaPersona = new Astronauta(nombre, edad, pais, tiempoEnEspacio);
            }
            else
            {
                nuevaPersona = new Persona(nombre, edad, pais);
            }

            return nuevaPersona;
        }

        static void UsoConsola()
        {
            // Cambia los colores de la consola
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;

            // Aplica la configuracion a toda la consola
            Console.Clear();

            Console.WriteLine("hola");
        }
    }
}
