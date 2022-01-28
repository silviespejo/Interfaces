using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TzvetanPetiov
{
    public static class Utils
    {
        private static int numUsuarios=0;

        public static int NumUsuarios { get => numUsuarios; set => numUsuarios = value; }

        public static void sumarUsuario() { ++numUsuarios; }

    }
}
