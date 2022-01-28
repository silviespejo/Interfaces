using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInstituto
{
    [Serializable]
    class InfoModulo
    {
        private bool activo;
        private int notaFinal;

        public InfoModulo(bool activo)
        {
            this.activo = activo;
            this.notaFinal = 0;
        }

        public bool Activo { get => activo; set => activo = value; }
        public int NotaFinal { get => notaFinal; set => notaFinal = value; }
    }
}
