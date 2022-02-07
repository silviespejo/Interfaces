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

        public void aniadirUsr(User user) {
            Array.Resize<User>(ref arrayUsers, arrayUsers.Length + 1);
            arrayUsers[arrayUsers.Length-1] = user;
        }

        public bool existeUser(String user) {
            bool existe = false;
            for (int i = 0; i < arrayUsers.Length; ++i)
                if (user.Equals(arrayUsers[i].Usr)) existe = true;
            return existe;
        }

    }
}
