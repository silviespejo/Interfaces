using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace examen02
{
    public partial class FormConsultaProductos : Form
    {
        Datos datos;
        private List<Producto> listaProductos;
        private BinaryFormatter binaryFormatter;
        private FileStream stream;
        public FormConsultaProductos(Datos datos)
        {
            InitializeComponent();
            this.datos = datos;
            this.binaryFormatter = new BinaryFormatter();
        }

        private void FormConsultaProductos_Load(object sender, EventArgs e)
        {
            stream = new FileStream(datos.NombreFichero, FileMode.Open, FileAccess.Read); // cargamos el fichero al abrir el form
            try
            {
                if (stream.Length != 0)// si el archivo esta vacío no se carga la lista, con lo cual su valor se queda a null
                    listaProductos = (List<Producto>)binaryFormatter.Deserialize(stream);
            }
            catch (System.Runtime.Serialization.SerializationException)
            {
                MessageBox.Show("Fichero no serializable seleccionado!", "Atención!");
            }
            stream.Close();
        }

        private void buttonPrimero_Click(object sender, EventArgs e)
        {
            mostrarInfo(listaProductos[0]);
        }

        private void buttonUltimo_Click(object sender, EventArgs e)
        {
            mostrarInfo(listaProductos[listaProductos.Count-1]);
        }

        private void mostrarInfo(Producto producto)
        {
            textBoxCodigoProducto.Text = producto.Codigo.ToString();
            textBoxNombre.Text = producto.Nombre;
            textBoxPrecio.Text = producto.Precio.ToString();
            textBoxStockMax.Text = producto.StockMax.ToString();
            textBoxStockMin.Text = producto.StockMin.ToString();
            textBoxUnidades.Text = producto.Unidades.ToString();
            textBoxTotal.Text = (producto.Precio * producto.Unidades).ToString();
        }

        
    }
}
