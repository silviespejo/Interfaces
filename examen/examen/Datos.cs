using System;
using System.Collections.Generic;
using System.Text;

namespace examen
{
    public class Datos
    {
        User[] arrayUsers;
        public Datos() {
            arrayUsers = new User[0];
        }

        public User[] ArrayUsers { get => arrayUsers; set => arrayUsers = value; }

        public void aniadirUsr(User user) {
            Array.Resize<User>(ref arrayUsers, arrayUsers.Length + 1);
            arrayUsers[arrayUsers.Length-1] = user;
        }

        public bool existeUser(String usr, String pass) {
            bool existe = false;
            for (int i = 0; i < arrayUsers.Length; ++i)
                if (usr.Equals(arrayUsers[i].Usr) && pass.Equals(arrayUsers[i].Pass)) existe = true;
            return existe;
        }

        public User extraerUsuario(String usr, String pass)
        {
            User user = null;
            for (int i = 0; i < arrayUsers.Length; ++i)
                if (usr.Equals(arrayUsers[i].Usr) && pass.Equals(arrayUsers[i].Pass)) user = arrayUsers[i];
            return user;
        }

        public bool esMayorDeEdad(DateTime fechaNacimiento)
        {
            TimeSpan resultado = DateTime.Now - fechaNacimiento;
            return (int)resultado.TotalDays > 6570; // 365 x 18 años = 6570 días
        }

    }
}
