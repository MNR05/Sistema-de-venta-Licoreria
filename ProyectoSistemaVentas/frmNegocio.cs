using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio1;
using CapaEntidad1;
namespace ProyectoSistemaVentas
{
    public partial class frmNegocio : Form
    {
        public frmNegocio()
        {
            InitializeComponent();
        }

        public Image ByteToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = new Bitmap(ms);

            return image;
        }

        private void frmNegocio_Load(object sender, EventArgs e)
        {
            bool obtenido = true;
            byte[] byteimage = new CN_Negocio().ObtenerLogo(out obtenido);

            if (obtenido) picGlobo.Image = ByteToImage(byteimage);

            Negocio datos = new CN_Negocio().ObtenerDatos();

            txtNombreN.Text = datos.Nombre;
            txtRUC.Text = datos.RUC;
            txtDireccionN.Text = datos.Direccion;

        }

        private void btnSubirF_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = "Files|*.jps;*.jpeg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] byteimage = File.ReadAllBytes(openFileDialog.FileName);
                bool respuesta = new CN_Negocio().ActualizarLogo(byteimage, out mensaje);
                if (respuesta)
                {
                    picGlobo.Image = ByteToImage(byteimage);
                }else
                {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            
         }

        private void btnGuardarN_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Negocio obj = new Negocio()
            {
                Nombre = txtNombreN.Text,
                RUC = txtRUC.Text,
                Direccion = txtDireccionN.Text
            };
            bool respuesta = new CN_Negocio().GuardarDatos(obj, out mensaje);

            if (respuesta)
                MessageBox.Show("Los cambios fueron guardados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                MessageBox.Show("No se pudo guardar los cambios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
