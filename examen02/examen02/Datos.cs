using System;
using System.Collections.Generic;
using System.Text;

namespace examen02
{
    public class Datos
    {
        private String nombreFichero;

        public Datos()
        {
            this.nombreFichero = "";
        }

        public string NombreFichero { get => nombreFichero; set => nombreFichero = value; }
    }
}
