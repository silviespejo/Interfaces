using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autobus
{
    public class Usuario
    {
        String dni;
        String nombre;
        String direccion;
        int    telefono;
        int    asiento;

        public Usuario(){}

        public Usuario(String dni, String nombre, String direccion, int telefono) {
            this.dni       = dni;
            this.nombre    = nombre;
            this.direccion = direccion;
            this.telefono  = telefono;
            this.asiento   = 0;
        }

        public String GetDni() {
            return dni;
        }

        public void SetDni(String dni) {
            this.dni = dni;
        }

        public String GetNombre()
        {
            return nombre;
        }

        public void SetNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public String GetDireccion()
        {
            return direccion;
        }

        public void SetDireccion(String direccion)
        {
            this.direccion = direccion;
        }

        public int GetTelefono()
        {
            return telefono;
        }

        public void SetTelefono(int telefono)
        {
            this.telefono = telefono;
        }

        public int GetAsiento()
        {
            return asiento;
        }

        public void SetAsiento(int asiento)
        {
            this.asiento = asiento;
        }

        override
        public String ToString()
        {
            return dni + "\t" + nombre + "\t" + direccion + "\t" + telefono + "\t" + asiento;
        }
    }
}
