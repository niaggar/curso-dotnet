using System;
using System.Collections.Generic;
using System.Text;

namespace FirstConsoleApp.models
{
    /* Forma en la que se indica que una clase hereda de otra */
    class Astronauta : Persona
    {
        // Propiedades unicas de la clase Astronauta
        public int TiempoEnElEspacio { get; set; }

        //---------------//

        /* El llamado a "base()" ejecuta el constructor de la superclase
         * por lo que hay que pasarle como parametros los atributos requeridos */
        public Astronauta(
            string nombre,
            int edad,
            string pais,
            int tiepoEnElEspacio=0
            ) : base(nombre, edad, pais)
        {
            this.TiempoEnElEspacio = tiepoEnElEspacio;
        }

        //---------------//

        /* Se sobreescribe el metodo "Presentarse", esto es indicado con la palabra "override" */
        public override void Presentarse()
        {
            string mensaje = 
                $"Hola yo soy {this.Nombre} tengo {this.Edad} y he estado {this.TiempoEnElEspacio} en el espacio";
            Console.WriteLine(mensaje);
        }
    }
}
