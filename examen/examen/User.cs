using System;
using System.Collections.Generic;
using System.Text;

namespace examen
{
    public class User
    {
        private String usr, pass, nombre, comentario = "";
        private DateTime fechaNacimiento;

        public User(string usr, string pass, string nombre, DateTime fechaNacimiento)
        {
            this.usr = usr;
            this.pass = pass;
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
        }

        public string Usr { get => usr; set => usr = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Comentario { get => comentario; set => comentario = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
    }
}
