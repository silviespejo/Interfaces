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
    public partial class FormAltaProducto : Form
    {
        private Datos datos;
        private List<Producto> listaProductos;
        private BinaryFormatter binaryFormatter;
        private FileStream stream;
        public FormAltaProducto(Datos datos)
        {
            InitializeComponent();
            this.datos = datos;
            this.binaryFormatter = new BinaryFormatter();
            this.listaProductos = null; // lo dejamos por defecto en null
            //this.stream = new FileStream(datos.NombreFichero, FileMode.Open, FileAccess.ReadWrite);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            stream.Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            stream = new FileStream(datos.NombreFichero, FileMode.Open, FileAccess.Write); // cargamos el fichero al abrir el form
            Producto producto = new Producto(textBoxNombre.Text, Convert.ToInt32(textBoxCodigoProducto.Text),
                Convert.ToInt32(textBoxStockMin.Text), Convert.ToInt32(textBoxStockMax.Text));
            
            if (listaProductos == null) // si es null es porque es el primer producto, con lo cual habrá que crear una lista
            {
                listaProductos = new List<Producto>();
                listaProductos.Add(producto);
                binaryFormatter.Serialize(stream, listaProductos);
            }
            else // si no es null es porque ya tenía una lista almacenada
            {
                listaProductos.Add(producto);
                binaryFormatter.Serialize(stream, listaProductos);
            }
            stream.Close();
        }

        private void FormAltaProducto_Load(object sender, EventArgs e)
        {
            stream = new FileStream(datos.NombreFichero, FileMode.Open, FileAccess.ReadWrite); // cargamos el fichero al abrir el form
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

        private void FormAltaProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            stream.Close();
        }
    }
}
