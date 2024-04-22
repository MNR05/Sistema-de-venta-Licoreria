
namespace ProyectoSistemaVentas
{
    partial class frmNegocio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuardarN = new FontAwesome.Sharp.IconButton();
            this.txtDireccionN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRUC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSubirF = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.picGlobo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGlobo)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(13, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(206, 31);
            this.label11.TabIndex = 25;
            this.label11.Text = "Detalle Negocio";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 450);
            this.label1.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnGuardarN);
            this.groupBox1.Controls.Add(this.txtDireccionN);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtRUC);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNombreN);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSubirF);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.picGlobo);
            this.groupBox1.Location = new System.Drawing.Point(20, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 355);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // btnGuardarN
            // 
            this.btnGuardarN.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGuardarN.IconColor = System.Drawing.Color.Black;
            this.btnGuardarN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarN.Location = new System.Drawing.Point(266, 236);
            this.btnGuardarN.Name = "btnGuardarN";
            this.btnGuardarN.Size = new System.Drawing.Size(154, 23);
            this.btnGuardarN.TabIndex = 9;
            this.btnGuardarN.Text = "Guardar cambios";
            this.btnGuardarN.UseVisualStyleBackColor = true;
            this.btnGuardarN.Click += new System.EventHandler(this.btnGuardarN_Click);
            // 
            // txtDireccionN
            // 
            this.txtDireccionN.Location = new System.Drawing.Point(231, 170);
            this.txtDireccionN.Name = "txtDireccionN";
            this.txtDireccionN.Size = new System.Drawing.Size(223, 20);
            this.txtDireccionN.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Direccion";
            // 
            // txtRUC
            // 
            this.txtRUC.Location = new System.Drawing.Point(231, 116);
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Size = new System.Drawing.Size(223, 20);
            this.txtRUC.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "RUC";
            // 
            // txtNombreN
            // 
            this.txtNombreN.Location = new System.Drawing.Point(231, 68);
            this.txtNombreN.Name = "txtNombreN";
            this.txtNombreN.Size = new System.Drawing.Size(223, 20);
            this.txtNombreN.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre de negocio";
            // 
            // btnSubirF
            // 
            this.btnSubirF.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btnSubirF.IconColor = System.Drawing.Color.Black;
            this.btnSubirF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSubirF.IconSize = 16;
            this.btnSubirF.Location = new System.Drawing.Point(49, 196);
            this.btnSubirF.Name = "btnSubirF";
            this.btnSubirF.Size = new System.Drawing.Size(120, 23);
            this.btnSubirF.TabIndex = 2;
            this.btnSubirF.Text = "Subir";
            this.btnSubirF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubirF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSubirF.UseVisualStyleBackColor = true;
            this.btnSubirF.Click += new System.EventHandler(this.btnSubirF_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Logo";
            // 
            // picGlobo
            // 
            this.picGlobo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGlobo.Location = new System.Drawing.Point(33, 52);
            this.picGlobo.Name = "picGlobo";
            this.picGlobo.Size = new System.Drawing.Size(152, 138);
            this.picGlobo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGlobo.TabIndex = 0;
            this.picGlobo.TabStop = false;
            // 
            // frmNegocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Name = "frmNegocio";
            this.Text = "frmNegocio";
            this.Load += new System.EventHandler(this.frmNegocio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGlobo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnSubirF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picGlobo;
        private FontAwesome.Sharp.IconButton btnGuardarN;
        private System.Windows.Forms.TextBox txtDireccionN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRUC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreN;
        private System.Windows.Forms.Label label3;
    }
}