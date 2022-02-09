using System;
using System.Collections.Generic;
using System.Text;

namespace EditorTexto02
{
    public class Datos
    {
        String nombreFicheroActual;

        public Datos()
        {
            this.nombreFicheroActual = "";
        }

        public string NombreFicheroActual { get => nombreFicheroActual; set => nombreFicheroActual = value; }
    }
}
