using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonantesSangre
{
    public class Usuario
    {
        String dni, nombre, grupo, factor;
        bool activo;
        int telefono;

        public Usuario(){}

        public Usuario(string dni, string nombre, string grupo, string factor, int telefono)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.grupo = grupo;
            this.factor = factor;
            this.activo = true;
            this.telefono = telefono;
        }

        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Grupo { get => grupo; set => grupo = value; }
        public string Factor { get => factor; set => factor = value; }
        public bool Activo { get => activo; set => activo = value; }
        public int Telefono { get => telefono; set => telefono = value; }

        override
        public String ToString()
        {
            return "DNI: "+dni + "   Nombre: " + nombre + "   Teléfono: " + telefono + "   Grupo: " + grupo + factor + "   UsuarioActivo: " + activo;
        }
    }
}
