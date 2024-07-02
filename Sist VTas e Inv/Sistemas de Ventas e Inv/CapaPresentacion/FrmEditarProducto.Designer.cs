namespace CapaPresentacion
{
    partial class FrmEditarProducto
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
            this.btnEditar = new System.Windows.Forms.Button();
            this.cboTipoCargo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPresentProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCostoUnitario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId_Producto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(622, 225);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.BackColor = System.Drawing.Color.Azure;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::CapaPresentacion.Properties.Resources.edit11;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(478, 226);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(120, 30);
            this.btnEditar.TabIndex = 32;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // cboTipoCargo
            // 
            this.cboTipoCargo.BackColor = System.Drawing.Color.PapayaWhip;
            this.cboTipoCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoCargo.FormattingEnabled = true;
            this.cboTipoCargo.Items.AddRange(new object[] {
            "IVA RESP INSCRIPTO 21%",
            "CONSUMIDOR FINAL 21%",
            "EXCENTO"});
            this.cboTipoCargo.Location = new System.Drawing.Point(542, 176);
            this.cboTipoCargo.Name = "cboTipoCargo";
            this.cboTipoCargo.Size = new System.Drawing.Size(200, 24);
            this.cboTipoCargo.TabIndex = 31;
            this.cboTipoCargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboTipoCargo_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(545, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 16);
            this.label8.TabIndex = 30;
            this.label8.Text = "Tipo de Cargo";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtPrecioVenta.Location = new System.Drawing.Point(278, 175);
            this.txtPrecioVenta.Multiline = true;
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(200, 25);
            this.txtPrecioVenta.TabIndex = 29;
            this.txtPrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVenta_KeyPress);
            this.txtPrecioVenta.Leave += new System.EventHandler(this.txtPrecioVenta_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(275, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Precio Venta";
            // 
            // txtNomProducto
            // 
            this.txtNomProducto.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtNomProducto.Location = new System.Drawing.Point(193, 35);
            this.txtNomProducto.Multiline = true;
            this.txtNomProducto.Name = "txtNomProducto";
            this.txtNomProducto.Size = new System.Drawing.Size(549, 25);
            this.txtNomProducto.TabIndex = 0;
            this.txtNomProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomProducto_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(234, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Nombre de Producto";
            // 
            // txtDescProducto
            // 
            this.txtDescProducto.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtDescProducto.Location = new System.Drawing.Point(12, 96);
            this.txtDescProducto.Multiline = true;
            this.txtDescProducto.Name = "txtDescProducto";
            this.txtDescProducto.Size = new System.Drawing.Size(550, 25);
            this.txtDescProducto.TabIndex = 25;
            this.txtDescProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescProducto_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Descripcion de Producto";
            // 
            // txtPresentProducto
            // 
            this.txtPresentProducto.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtPresentProducto.Location = new System.Drawing.Point(592, 96);
            this.txtPresentProducto.Multiline = true;
            this.txtPresentProducto.Name = "txtPresentProducto";
            this.txtPresentProducto.Size = new System.Drawing.Size(150, 25);
            this.txtPresentProducto.TabIndex = 23;
            this.txtPresentProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPresentProducto_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(592, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Presentacion Producto";
            // 
            // txtCostoUnitario
            // 
            this.txtCostoUnitario.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtCostoUnitario.Location = new System.Drawing.Point(12, 176);
            this.txtCostoUnitario.Multiline = true;
            this.txtCostoUnitario.Name = "txtCostoUnitario";
            this.txtCostoUnitario.Size = new System.Drawing.Size(200, 25);
            this.txtCostoUnitario.TabIndex = 21;
            this.txtCostoUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCostoUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostoUnitario_KeyPress);
            this.txtCostoUnitario.Leave += new System.EventHandler(this.txtCostoUnitario_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Costo Unitario";
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtCodProducto.Location = new System.Drawing.Point(12, 35);
            this.txtCodProducto.Multiline = true;
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.ReadOnly = true;
            this.txtCodProducto.Size = new System.Drawing.Size(156, 25);
            this.txtCodProducto.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Codigo Producto";
            // 
            // txtId_Producto
            // 
            this.txtId_Producto.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtId_Producto.Location = new System.Drawing.Point(127, 4);
            this.txtId_Producto.Multiline = true;
            this.txtId_Producto.Name = "txtId_Producto";
            this.txtId_Producto.ReadOnly = true;
            this.txtId_Producto.Size = new System.Drawing.Size(41, 25);
            this.txtId_Producto.TabIndex = 33;
            this.txtId_Producto.Visible = false;
            // 
            // FrmEditarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 267);
            this.Controls.Add(this.txtId_Producto);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.cboTipoCargo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNomProducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescProducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPresentProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCostoUnitario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodProducto);
            this.Controls.Add(this.label1);
            this.Name = "FrmEditarProducto";
            this.Text = "Editar Producto";
            this.Load += new System.EventHandler(this.FrmEditarProducto_Load);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtCodProducto, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtCostoUnitario, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtPresentProducto, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtDescProducto, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtNomProducto, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtPrecioVenta, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.cboTipoCargo, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.txtId_Producto, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.ComboBox cboTipoCargo;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtNomProducto;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtDescProducto;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtPresentProducto;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtCostoUnitario;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtCodProducto;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtId_Producto;
    }
}