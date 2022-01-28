using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInstituto
{
    [Serializable]
    class Alumno
    {
        private String nombre, apellidos, dni, mail;
        private Curso curso;
        private bool estado; // true = alta, flase = baja

        public Alumno(string nombre, string apellidos, string dni, string mail,
            String nombreCurso, String grupo, Dictionary<String, bool> modulosActivos)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
            this.mail = mail;
            this.curso = new Curso(nombreCurso, grupo, modulosActivos);
            this.estado = true;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Mail { get => mail; set => mail = value; }
        public bool Estado { get => estado; set => estado = value; }
        internal Curso Curso { get => curso; set => curso = value; }
    }
}
