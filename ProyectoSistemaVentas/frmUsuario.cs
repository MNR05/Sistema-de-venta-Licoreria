using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoSistemaVentas.Utilidades;
using CapaEntidad1;
using CapaNegocio1;
namespace ProyectoSistemaVentas
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            cboEstado.Items.Add(new opcionCombo() { Valor = 1, Texto = "Activo" });
            cboEstado.Items.Add(new opcionCombo() { Valor = 0, Texto = "No Activo" });
            cboEstado.DisplayMember = "Texto";
            cboEstado.ValueMember = "Valor";
            cboEstado.SelectedIndex = 0;

            List<U_ROL> listarol = new CN_Rol().Listar();

            foreach(U_ROL item in listarol)
            {
                cboRol.Items.Add(new opcionCombo() {  Valor = item.IdRol, Texto = item.Descripcion } );
            }
            cboRol.DisplayMember = "Texto";
            cboRol.ValueMember = "Valor";
            cboRol.SelectedIndex = 0;

            foreach(DataGridViewColumn column in dgvDataUsuario.Columns)
            {
                if (column.Visible == true && column.Name!= "btnSeleccionar")
                {
                    cboBusqueda.Items.Add(new opcionCombo() { Valor = column.Name, Texto = column.HeaderText });
                }
            }
            cboBusqueda.DisplayMember = "Texto";
            cboBusqueda.ValueMember = "Valor";
            cboBusqueda.SelectedIndex = 0;

            //Mostrar usuarios
            List<U_USUARIOS> listauser = new CN_Usuario().Listar();

            foreach (U_USUARIOS item in listauser)
            {
                dgvDataUsuario.Rows.Add(new object[] {"",item.IdUser,item.Documento,item.Nombre,item.Apellido,item.Correo,item.Clave,
                item.oRol.IdRol,
                item.oRol.Descripcion,
                item.Estado == true ? 1:0,
                item.Estado == true ? "Activo" : "No Activo"
            }) ;
            }
            
        }
        private void Limpiar()
        {
            txtIndice.Text = "-1";
            txtId.Clear();
            txtDocumento.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtCorreo.Clear();
            txtClave.Clear();
            txtConfiClave.Clear();
            cboRol.SelectedIndex = 0;
            cboEstado.SelectedIndex = 0;

            txtDocumento.Select();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            U_USUARIOS obju = new U_USUARIOS()
            {
                IdUser = Convert.ToInt32(txtId.Text),
                Documento = txtDocumento.Text,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Correo = txtCorreo.Text,
                Clave = txtClave.Text,
                oRol = new U_ROL() {
                    IdRol = Convert.ToInt32(((opcionCombo)cboRol.SelectedItem).Valor)
                },
                Estado = Convert.ToInt32(((opcionCombo)cboEstado.SelectedItem).Valor) == 1 ? true : false

            };

            if(obju.IdUser == 0){


                int idusuariog = new CN_Usuario().Registrar(obju, out mensaje);

                if (idusuariog != 0)
                {
                    dgvDataUsuario.Rows.Add(new object[] {"",idusuariog,txtDocumento.Text,txtNombre.Text,txtApellido.Text,txtCorreo.Text,txtClave.Text,
                    ((opcionCombo)cboRol.SelectedItem).Valor.ToString(),
                    ((opcionCombo)cboRol.SelectedItem).Texto.ToString(),
                    ((opcionCombo)cboEstado.SelectedItem).Valor.ToString(),
                    ((opcionCombo)cboEstado.SelectedItem).Texto.ToString(),
                    });
                    Limpiar();
                }
                else {
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                
                bool resultado = new CN_Usuario().Editar(obju, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvDataUsuario.Rows[Convert.ToInt32(txtIndice.Text)];
                    row.Cells["id"].Value = txtId.Text;
                    row.Cells["Documento"].Value = txtDocumento.Text;
                    row.Cells["Nombre"].Value = txtNombre.Text;
                    row.Cells["Apellido"].Value = txtApellido.Text;
                    row.Cells["Correo"].Value = txtCorreo.Text;
                    row.Cells["Clave"].Value = txtClave.Text;
                    row.Cells["idRol"].Value = ((opcionCombo)cboRol.SelectedItem).Valor.ToString();
                    row.Cells["Rol"].Value = ((opcionCombo)cboRol.SelectedItem).Texto.ToString();
                    row.Cells["EstadoValor"].Value = ((opcionCombo)cboEstado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((opcionCombo)cboEstado.SelectedItem).Texto.ToString();

                    
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
                Limpiar();

            }

        }

       

        private void dgvDataUsuario_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.check.Width;
                var h = Properties.Resources.check.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - w) / 2;

                e.Graphics.DrawImage(Properties.Resources.check, new Rectangle(x, y, w, h));
                e.Handled = true;
            }

        }

        private void dgvDataUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvDataUsuario.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtIndice.Text = indice.ToString();
                    txtId.Text = dgvDataUsuario.Rows[indice].Cells["Id"].Value.ToString();
                    txtDocumento.Text= dgvDataUsuario.Rows[indice].Cells["Documento"].Value.ToString();
                    txtNombre.Text = dgvDataUsuario.Rows[indice].Cells["Nombre"].Value.ToString();
                    txtApellido.Text = dgvDataUsuario.Rows[indice].Cells["Apellido"].Value.ToString();
                    txtCorreo.Text = dgvDataUsuario.Rows[indice].Cells["Correo"].Value.ToString();
                    txtClave.Text = dgvDataUsuario.Rows[indice].Cells["Clave"].Value.ToString();
                    txtConfiClave.Text= dgvDataUsuario.Rows[indice].Cells["Clave"].Value.ToString();
                    foreach (opcionCombo op in cboRol.Items){
                        if (Convert.ToInt32(op.Valor) == Convert.ToInt32(dgvDataUsuario.Rows[indice].Cells["idRol"].Value))
                        {
                            int indice_combo = cboRol.Items.IndexOf(op);
                            cboRol.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                    foreach (opcionCombo op in cboEstado.Items)
                    {
                        if (Convert.ToInt32(op.Valor) == Convert.ToInt32(dgvDataUsuario.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = cboEstado.Items.IndexOf(op);
                            cboEstado.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                }



            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtId.Text)!=0)
            {
                if(MessageBox.Show("¿Desea eliminar el usuario?","Mensaje",MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    U_USUARIOS obj = new U_USUARIOS()
                    {
                        IdUser = Convert.ToInt32(txtId.Text)
                    };
                        bool respuesta = new CN_Usuario().Eliminar(obj, out mensaje);
                    if (respuesta)
                    {
                        dgvDataUsuario.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                    }
                }
            }
            Limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((opcionCombo)cboBusqueda.SelectedItem).Valor.ToString();

            if (dgvDataUsuario.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvDataUsuario.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                    
                }
            }
        }

        private void btnLimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            foreach (DataGridViewRow row in dgvDataUsuario.Rows)
            {
                row.Visible = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
