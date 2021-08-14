using System;
using System.Collections.Generic;
using System.Text;

namespace FirstConsoleApp.models
{
    class Persona
    {
        /* Uso de propiedades , las cuales limitan el acceso y declaracion
         * segun lo establecido en el get y set */
        public string Nombre { get; set; }

        /* El campo _pais es privado pero se permite acceder a el mediante 
         * el uso de la propiedad Pais, la cual modifica como se establece _pais */
        private string _pais;
        public string Pais 
        {
            get
            {
                return _pais;
            }
            set 
            {
                _pais = value.ToUpper();
            }
        }

        public int Edad { get; set; }

        //----------------//

        /* Es permitido el uso de multiples constructores dentro de una clase
         * estos seran usados dependiendo de como se instancie la clase */
        public Persona()
        {}

        public Persona(string nombre, int edad, string pais)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Pais = pais;
        }

        //----------------//

        /* La palabra clave "virtual" sirve como modificador de este metodo,
         * permitiendo que pueda sobreescribirse en alguna de sus clases derivadas */
        public virtual void Presentarse()
        {
            string mensaje = 
                $"Hola yo soy {this.Nombre} tengo {this.Edad} y soy de {this.Pais}";
            Console.WriteLine(mensaje);
        }
    }
}
