namespace SistemaVentasUI.Modales
{
    partial class mdProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnsalir = new FontAwesome.Sharp.IconButton();
            this.btncargamasiva = new FontAwesome.Sharp.IconButton();
            this.btncategorias = new FontAwesome.Sharp.IconButton();
            this.btnproductos = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 273);
            this.label1.TabIndex = 4;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnsalir.IconColor = System.Drawing.Color.Black;
            this.btnsalir.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalir.Location = new System.Drawing.Point(21, 197);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnsalir.Size = new System.Drawing.Size(144, 47);
            this.btnsalir.TabIndex = 3;
            this.btnsalir.Text = "Cerrar";
            this.btnsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btncargamasiva
            // 
            this.btncargamasiva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncargamasiva.IconChar = FontAwesome.Sharp.IconChar.FileUpload;
            this.btncargamasiva.IconColor = System.Drawing.Color.Black;
            this.btncargamasiva.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncargamasiva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncargamasiva.Location = new System.Drawing.Point(21, 144);
            this.btncargamasiva.Name = "btncargamasiva";
            this.btncargamasiva.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btncargamasiva.Size = new System.Drawing.Size(144, 47);
            this.btncargamasiva.TabIndex = 2;
            this.btncargamasiva.Text = "Carga Masiva";
            this.btncargamasiva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncargamasiva.UseVisualStyleBackColor = true;
            this.btncargamasiva.Click += new System.EventHandler(this.btncargamasiva_Click);
            // 
            // btncategorias
            // 
            this.btncategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncategorias.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.btncategorias.IconColor = System.Drawing.Color.Black;
            this.btncategorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncategorias.Location = new System.Drawing.Point(21, 91);
            this.btncategorias.Name = "btncategorias";
            this.btncategorias.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btncategorias.Size = new System.Drawing.Size(144, 47);
            this.btncategorias.TabIndex = 1;
            this.btncategorias.Text = "Categorias";
            this.btncategorias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncategorias.UseVisualStyleBackColor = true;
            this.btncategorias.Click += new System.EventHandler(this.btncategorias_Click);
            // 
            // btnproductos
            // 
            this.btnproductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnproductos.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.btnproductos.IconColor = System.Drawing.Color.Black;
            this.btnproductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnproductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproductos.Location = new System.Drawing.Point(21, 38);
            this.btnproductos.Name = "btnproductos";
            this.btnproductos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnproductos.Size = new System.Drawing.Size(144, 47);
            this.btnproductos.TabIndex = 0;
            this.btnproductos.Text = "Productos";
            this.btnproductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnproductos.UseVisualStyleBackColor = true;
            this.btnproductos.Click += new System.EventHandler(this.btnproductos_Click);
            // 
            // mdProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(188, 281);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btncargamasiva);
            this.Controls.Add(this.btncategorias);
            this.Controls.Add(this.btnproductos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mdProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "mdProducto";
            this.Load += new System.EventHandler(this.mdProducto_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnproductos;
        private FontAwesome.Sharp.IconButton btncategorias;
        private FontAwesome.Sharp.IconButton btncargamasiva;
        private FontAwesome.Sharp.IconButton btnsalir;
        private System.Windows.Forms.Label label1;
    }
}