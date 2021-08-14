using System;
using System.Collections.Generic;
using System.Text;

namespace FirstConsoleApp.learnig
{
    // Prueba/Recordatorio de los tipos de datos
    class TiposDeDatos
    {
        static void Cadenas()
        {
            string nombre = "Nicolas Aguilera";

            // Concatenacion de Cadenas
            string mensaje;
            mensaje = "Yo soy " + nombre;
            mensaje = $"Yo soy {nombre}";

            // Comparacion de Cadenas
            bool sonIguales = nombre.Equals("Nicolas");

            // Mayusculas minusculas
            var may = nombre.ToUpper();
            var min = nombre.ToLower();
        }
    }
}
