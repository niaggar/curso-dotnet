using System;
using System.Collections.Generic;
using System.Text;

namespace FirstAppConsole.models
{
    class Astronauta : Persona
    {
        public int TiempoEnElEspacio { get; set; }

        public Astronauta(string nombre, int edad, string pais, int tiepoEnElEspacio=0) 
            : base(nombre, edad, pais)
        {
            this.TiempoEnElEspacio = tiepoEnElEspacio;
        }

        public override void Presentarse()
        {
            string mensaje = $"Hola yo soy {this.Nombre} tengo {this.Edad} y he estado {this.TiempoEnElEspacio} en el espacio";
            Console.WriteLine(mensaje);
        }
    }
}
