using System;
using System.Collections.Generic;
using System.Text;

namespace examen02
{
    [Serializable]
    public class Producto
    {
        private int codigo, stockMin, stockMax, unidades, precio;
        private String nombre;

        public Producto(String nombre, int codigo, int stockMin, int stockMax)
        {
            this.nombre = nombre;
            this.codigo = codigo;
            this.stockMin = stockMin;
            this.stockMax = stockMax;
            this.unidades = 0;
            this.precio = 0;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public int StockMin { get => stockMin; set => stockMin = value; }
        public int StockMax { get => stockMax; set => stockMax = value; }
        public int Unidades { get => unidades; set => unidades = value; }
        public int Precio { get => precio; set => precio = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
