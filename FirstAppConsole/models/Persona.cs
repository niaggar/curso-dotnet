using System;
using System.Collections.Generic;
using System.Text;

namespace FirstAppConsole.models
{
    class Persona
    {
        public string Nombre { get; set; }
        public string Pais { get; set; }
        public int Edad { get; set; }

        public Persona(string nombre, int edad, string pais)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Pais = pais;
        }

        public virtual void Presentarse()
        {
            string mensaje = $"Hola yo soy {this.Nombre} tengo {this.Edad} y soy de {this.Pais}";
            Console.WriteLine(mensaje);
        }
    }
}
