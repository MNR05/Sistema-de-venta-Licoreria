using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad1;
using CapaNegocio1;
using FontAwesome.Sharp;

namespace ProyectoSistemaVentas
{
    public partial class Inicio : Form
    {
        private static U_USUARIOS usuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;



        public Inicio(U_USUARIOS objusuario=null)
        {
            if (objusuario == null)

                usuarioActual = new U_USUARIOS()
                {
                    Nombre = "adminpredefinido", IdUser = 5};
            else
               
            usuarioActual = objusuario;
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            List<U_PERMISO> Listapermisos = new CN_PERMISO().Listar(usuarioActual.IdUser);

            foreach (IconMenuItem iconmenu in menu2.Items)
            {
                bool encontrado = Listapermisos.Any(m => m.nombreMenu == iconmenu.Name);
                if (encontrado == false) {
                    iconmenu.Visible=false;
                }
            }

            lblnombreUsuario.Text = usuarioActual.Nombre;
        }

        private void AbrirFromulario(IconMenuItem menu, Form Formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            if (FormularioActivo!=null) {
                FormularioActivo.Close();
            } 

            FormularioActivo = Formulario;
            Formulario.TopLevel = false;
            Formulario.FormBorderStyle = FormBorderStyle.None;
            Formulario.Dock = DockStyle.Fill;
            Formulario.BackColor = Color.SteelBlue;

            pn_contenedor.Controls.Add(Formulario);
            Formulario.Show();
        }
        private void menuUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFromulario((IconMenuItem)sender, new frmUsuario());
        }
        private void subMenuCategoria_Click(object sender, EventArgs e)
        {
            AbrirFromulario(menuMantenedor, new frmCategoria());
        }

        private void subMenuProducto_Click(object sender, EventArgs e)
        {
            AbrirFromulario(menuMantenedor, new frmMarca());
        }

        private void SubMProducto_Click(object sender, EventArgs e)
        {
            AbrirFromulario(menuMantenedor, new frmProducto());
        }

        private void subMVenta_Click(object sender, EventArgs e)
        {
            AbrirFromulario(menuVentas, new frmVentas());
        }

        private void subMVerDTVenta_Click(object sender, EventArgs e)
        {
            AbrirFromulario(menuVentas, new frmDetalleVenta());
        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            AbrirFromulario((IconMenuItem)sender, new frmClientes());
        }

        private void menuReportes_Click(object sender, EventArgs e)
        {
            AbrirFromulario((IconMenuItem)sender, new frmReportes());
        }

        private void subMNegocio_Click(object sender, EventArgs e)
        {
            AbrirFromulario(menuMantenedor, new frmNegocio());
        }

        private void subMCompra_Click(object sender, EventArgs e)
        {
            AbrirFromulario(menuCompras, new frmCompras());
        }

        private void subMVerDTCompra_Click(object sender, EventArgs e)
        {
            AbrirFromulario(menuCompras, new frmDetalleCompras());
        }

        private void menuProveedor_Click(object sender, EventArgs e)
        {
            AbrirFromulario((IconMenuItem)sender, new frmProveedores());
        }
    }
    
}
