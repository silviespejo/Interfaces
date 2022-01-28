using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInstituto
{
    class Curso
    {
        private String nombreCurso, grupo;
        Dictionary<String, InfoModulo> modulos; // clave -> nombreModulo, valor -> InfoModulo

        public Curso(string nombreCurso, string grupo, Dictionary<String, bool> modulos)
        {
            this.nombreCurso = nombreCurso;
            this.grupo = grupo;
            this.modulos = decidirModulos(nombreCurso, modulos);
        }

        // Este métoddo sirve
        private Dictionary<string, InfoModulo> decidirModulos(String nombreCurso,
            Dictionary<String, bool> modulosActivos)
        {
            Dictionary<String, InfoModulo> modulos = new Dictionary<string, InfoModulo>();
            InfoModulo infoModulo;
            if (nombreCurso.Equals("1º DAM"))
            {
                // modulosActivos es el diccionario que creamos en FomrAltaAlumno, este diccionario contiene
                // como clave un String con el nombre del módulo y como valor un bool indicando si el módulo
                // esta dado de alta o de baja, ya que cada alumno será diferente
                modulos.Add("Programacion", new InfoModulo(modulosActivos.ContainsKey("Programacion")));
                modulos.Add("Entornos", new InfoModulo(modulosActivos.ContainsKey("Entornos")));
                modulos.Add("BBDD", new InfoModulo(modulosActivos.ContainsKey("BBDD")));
                return modulos;
            }
            else
            {
                modulos.Add("Interfaces",new InfoModulo(modulosActivos.ContainsKey("Interfaces")));
                modulos.Add("SGE", new InfoModulo(modulosActivos.ContainsKey("SGE")));
                modulos.Add("Procesos", new InfoModulo(modulosActivos.ContainsKey("Procesos")));
                return modulos;
            }
        }
        public string NombreCurso { get => nombreCurso; set => nombreCurso = value; }
        public string Grupo { get => grupo; set => grupo = value; }
        internal Dictionary<string, InfoModulo> Modulos { get => modulos; set => modulos = value; }
    }
}
