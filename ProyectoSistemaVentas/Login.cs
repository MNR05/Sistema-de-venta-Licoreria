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
namespace ProyectoSistemaVentas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            List<U_USUARIOS> TEST = new CN_Usuario().Listar();
            U_USUARIOS oUser = new CN_Usuario().Listar().Where(u => u.Documento == txtUsuario.Text &&
            u.Clave == txtPass.Text).FirstOrDefault();

           if(oUser!=null) {
                Inicio form = new Inicio(oUser);
                form.Show();
                this.Hide();
                form.FormClosing += frm_closing;
            }
           else
            {
                MessageBox.Show("No se encontro un usuario", "Alerta",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                txtUsuario.Text = "";
                txtPass.Text = "";
            }   


        }
        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtUsuario.Text = "";
            txtPass.Text = "";

            this.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
