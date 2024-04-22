
namespace ProyectoSistemaVentas
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu2 = new System.Windows.Forms.MenuStrip();
            this.menuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.menuMantenedor = new FontAwesome.Sharp.IconMenuItem();
            this.subMenuCategoria = new FontAwesome.Sharp.IconMenuItem();
            this.SubMProducto = new FontAwesome.Sharp.IconMenuItem();
            this.subMNegocio = new FontAwesome.Sharp.IconMenuItem();
            this.menuClientes = new FontAwesome.Sharp.IconMenuItem();
            this.menuReportes = new FontAwesome.Sharp.IconMenuItem();
            this.menuVentas = new FontAwesome.Sharp.IconMenuItem();
            this.subMVenta = new FontAwesome.Sharp.IconMenuItem();
            this.subMVerDTVenta = new FontAwesome.Sharp.IconMenuItem();
            this.menuCompras = new FontAwesome.Sharp.IconMenuItem();
            this.subMCompra = new FontAwesome.Sharp.IconMenuItem();
            this.subMVerDTCompra = new FontAwesome.Sharp.IconMenuItem();
            this.menuProveedor = new FontAwesome.Sharp.IconMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_contenedor = new System.Windows.Forms.Panel();
            this.lblnombreUsuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menu2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu2
            // 
            this.menu2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menu2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuarios,
            this.menuMantenedor,
            this.menuVentas,
            this.menuCompras,
            this.menuClientes,
            this.menuProveedor,
            this.menuReportes});
            this.menu2.Location = new System.Drawing.Point(0, 68);
            this.menu2.Name = "menu2";
            this.menu2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menu2.Size = new System.Drawing.Size(1102, 73);
            this.menu2.TabIndex = 0;
            this.menu2.Text = "menuStrip1";
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.menuUsuarios.IconColor = System.Drawing.Color.Black;
            this.menuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuUsuarios.IconSize = 50;
            this.menuUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.Size = new System.Drawing.Size(64, 69);
            this.menuUsuarios.Text = "Usuarios";
            this.menuUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuUsuarios.Click += new System.EventHandler(this.menuUsuarios_Click);
            // 
            // menuMantenedor
            // 
            this.menuMantenedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuCategoria,
            this.SubMProducto,
            this.subMNegocio});
            this.menuMantenedor.IconChar = FontAwesome.Sharp.IconChar.Toolbox;
            this.menuMantenedor.IconColor = System.Drawing.Color.Black;
            this.menuMantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuMantenedor.IconSize = 50;
            this.menuMantenedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuMantenedor.Name = "menuMantenedor";
            this.menuMantenedor.Size = new System.Drawing.Size(84, 69);
            this.menuMantenedor.Text = "Mantenedor";
            this.menuMantenedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMenuCategoria
            // 
            this.subMenuCategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMenuCategoria.IconColor = System.Drawing.Color.Black;
            this.subMenuCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMenuCategoria.Name = "subMenuCategoria";
            this.subMenuCategoria.Size = new System.Drawing.Size(125, 22);
            this.subMenuCategoria.Text = "Categoria";
            this.subMenuCategoria.Click += new System.EventHandler(this.subMenuCategoria_Click);
            // 
            // SubMProducto
            // 
            this.SubMProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMProducto.IconColor = System.Drawing.Color.Black;
            this.SubMProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMProducto.Name = "SubMProducto";
            this.SubMProducto.Size = new System.Drawing.Size(125, 22);
            this.SubMProducto.Text = "Producto";
            this.SubMProducto.Click += new System.EventHandler(this.SubMProducto_Click);
            // 
            // subMNegocio
            // 
            this.subMNegocio.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMNegocio.IconColor = System.Drawing.Color.Black;
            this.subMNegocio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMNegocio.Name = "subMNegocio";
            this.subMNegocio.Size = new System.Drawing.Size(125, 22);
            this.subMNegocio.Text = "Negocio";
            this.subMNegocio.Click += new System.EventHandler(this.subMNegocio_Click);
            // 
            // menuClientes
            // 
            this.menuClientes.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.menuClientes.IconColor = System.Drawing.Color.Black;
            this.menuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuClientes.IconSize = 50;
            this.menuClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(62, 69);
            this.menuClientes.Text = "Clientes";
            this.menuClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuClientes.Click += new System.EventHandler(this.menuClientes_Click);
            // 
            // menuReportes
            // 
            this.menuReportes.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.menuReportes.IconColor = System.Drawing.Color.Black;
            this.menuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuReportes.IconSize = 50;
            this.menuReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuReportes.Name = "menuReportes";
            this.menuReportes.Size = new System.Drawing.Size(65, 69);
            this.menuReportes.Text = "Reportes";
            this.menuReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuReportes.Click += new System.EventHandler(this.menuReportes_Click);
            // 
            // menuVentas
            // 
            this.menuVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMVenta,
            this.subMVerDTVenta});
            this.menuVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.menuVentas.IconColor = System.Drawing.Color.Black;
            this.menuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuVentas.IconSize = 50;
            this.menuVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuVentas.Name = "menuVentas";
            this.menuVentas.Size = new System.Drawing.Size(62, 69);
            this.menuVentas.Text = "Ventas";
            this.menuVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMVenta
            // 
            this.subMVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMVenta.IconColor = System.Drawing.Color.Black;
            this.subMVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMVenta.Name = "subMVenta";
            this.subMVenta.Size = new System.Drawing.Size(180, 22);
            this.subMVenta.Text = "Registrar Venta";
            this.subMVenta.Click += new System.EventHandler(this.subMVenta_Click);
            // 
            // subMVerDTVenta
            // 
            this.subMVerDTVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMVerDTVenta.IconColor = System.Drawing.Color.Black;
            this.subMVerDTVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMVerDTVenta.Name = "subMVerDTVenta";
            this.subMVerDTVenta.Size = new System.Drawing.Size(180, 22);
            this.subMVerDTVenta.Text = "Ver detalle venta";
            this.subMVerDTVenta.Click += new System.EventHandler(this.subMVerDTVenta_Click);
            // 
            // menuCompras
            // 
            this.menuCompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMCompra,
            this.subMVerDTCompra});
            this.menuCompras.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.menuCompras.IconColor = System.Drawing.Color.Black;
            this.menuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuCompras.IconSize = 50;
            this.menuCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCompras.Name = "menuCompras";
            this.menuCompras.Size = new System.Drawing.Size(67, 69);
            this.menuCompras.Text = "Compras";
            this.menuCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // subMCompra
            // 
            this.subMCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMCompra.IconColor = System.Drawing.Color.Black;
            this.subMCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMCompra.Name = "subMCompra";
            this.subMCompra.Size = new System.Drawing.Size(180, 22);
            this.subMCompra.Text = "Registrar compra";
            this.subMCompra.Click += new System.EventHandler(this.subMCompra_Click);
            // 
            // subMVerDTCompra
            // 
            this.subMVerDTCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.subMVerDTCompra.IconColor = System.Drawing.Color.Black;
            this.subMVerDTCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subMVerDTCompra.Name = "subMVerDTCompra";
            this.subMVerDTCompra.Size = new System.Drawing.Size(180, 22);
            this.subMVerDTCompra.Text = "Ver detalle compra";
            this.subMVerDTCompra.Click += new System.EventHandler(this.subMVerDTCompra_Click);
            // 
            // menuProveedor
            // 
            this.menuProveedor.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.menuProveedor.IconColor = System.Drawing.Color.Black;
            this.menuProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuProveedor.IconSize = 50;
            this.menuProveedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuProveedor.Name = "menuProveedor";
            this.menuProveedor.Size = new System.Drawing.Size(73, 69);
            this.menuProveedor.Text = "Proveedor";
            this.menuProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuProveedor.Click += new System.EventHandler(this.menuProveedor_Click);
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(1102, 68);
            this.menuTitulo.TabIndex = 1;
            this.menuTitulo.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenido";
            // 
            // pn_contenedor
            // 
            this.pn_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_contenedor.Location = new System.Drawing.Point(0, 141);
            this.pn_contenedor.Name = "pn_contenedor";
            this.pn_contenedor.Size = new System.Drawing.Size(1102, 489);
            this.pn_contenedor.TabIndex = 3;
            // 
            // lblnombreUsuario
            // 
            this.lblnombreUsuario.AutoSize = true;
            this.lblnombreUsuario.BackColor = System.Drawing.Color.SteelBlue;
            this.lblnombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombreUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblnombreUsuario.Location = new System.Drawing.Point(785, 22);
            this.lblnombreUsuario.Name = "lblnombreUsuario";
            this.lblnombreUsuario.Size = new System.Drawing.Size(0, 20);
            this.lblnombreUsuario.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SteelBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(703, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Usuario:";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 630);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblnombreUsuario);
            this.Controls.Add(this.pn_contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu2);
            this.Controls.Add(this.menuTitulo);
            this.MainMenuStrip = this.menu2;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu2.ResumeLayout(false);
            this.menu2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu2;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem menuUsuarios;
        private FontAwesome.Sharp.IconMenuItem menuMantenedor;
        private FontAwesome.Sharp.IconMenuItem menuVentas;
        private FontAwesome.Sharp.IconMenuItem menuClientes;
        private FontAwesome.Sharp.IconMenuItem menuReportes;
        private System.Windows.Forms.Panel pn_contenedor;
        private System.Windows.Forms.Label lblnombreUsuario;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconMenuItem subMenuCategoria;
        private FontAwesome.Sharp.IconMenuItem SubMProducto;
        private FontAwesome.Sharp.IconMenuItem subMVenta;
        private FontAwesome.Sharp.IconMenuItem subMVerDTVenta;
        private FontAwesome.Sharp.IconMenuItem subMNegocio;
        private FontAwesome.Sharp.IconMenuItem menuCompras;
        private FontAwesome.Sharp.IconMenuItem subMCompra;
        private FontAwesome.Sharp.IconMenuItem subMVerDTCompra;
        private FontAwesome.Sharp.IconMenuItem menuProveedor;
    }
}

