using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TzvetanPetiov
{
    public class Usuario
    {
        private String usuario, contrasena, nombre, queja;
        private DateTime fechaNacimiento;

        public Usuario(string usr, string contrasena, string nombre, DateTime fechaNacimiento)
        {
            this.usuario = usr;
            this.contrasena = contrasena;
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
        }

        public string Usr { get => usuario; set => usuario = value; }
        public string Queja { get => queja; set => queja = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
    }
}
