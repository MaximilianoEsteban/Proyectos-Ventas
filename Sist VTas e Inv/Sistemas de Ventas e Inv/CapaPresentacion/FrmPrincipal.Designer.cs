namespace CapaPresentacion
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productos = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventario = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmTiempo = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PapayaWhip;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeProductosToolStripMenuItem,
            this.gestionDeProveedoresToolStripMenuItem,
            this.gestionDeClientesToolStripMenuItem,
            this.gestionDeComprasToolStripMenuItem,
            this.gestionDeVentasToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.configuracionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1130, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionDeProductosToolStripMenuItem
            // 
            this.gestionDeProductosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productos});
            this.gestionDeProductosToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.Ajusss;
            this.gestionDeProductosToolStripMenuItem.Name = "gestionDeProductosToolStripMenuItem";
            this.gestionDeProductosToolStripMenuItem.Size = new System.Drawing.Size(170, 28);
            this.gestionDeProductosToolStripMenuItem.Text = "Gestion de Productos";
            // 
            // productos
            // 
            this.productos.Image = global::CapaPresentacion.Properties.Resources.proddd;
            this.productos.Name = "productos";
            this.productos.Size = new System.Drawing.Size(188, 30);
            this.productos.Text = "Productos";
            this.productos.Click += new System.EventHandler(this.productos_Click);
            // 
            // gestionDeProveedoresToolStripMenuItem
            // 
            this.gestionDeProveedoresToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.Proveedores;
            this.gestionDeProveedoresToolStripMenuItem.Name = "gestionDeProveedoresToolStripMenuItem";
            this.gestionDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(185, 28);
            this.gestionDeProveedoresToolStripMenuItem.Text = "Gestion de Proveedores";
            // 
            // gestionDeClientesToolStripMenuItem
            // 
            this.gestionDeClientesToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.Clientes;
            this.gestionDeClientesToolStripMenuItem.Name = "gestionDeClientesToolStripMenuItem";
            this.gestionDeClientesToolStripMenuItem.Size = new System.Drawing.Size(156, 28);
            this.gestionDeClientesToolStripMenuItem.Text = "Gestion de Clientes";
            // 
            // gestionDeComprasToolStripMenuItem
            // 
            this.gestionDeComprasToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.Compras;
            this.gestionDeComprasToolStripMenuItem.Name = "gestionDeComprasToolStripMenuItem";
            this.gestionDeComprasToolStripMenuItem.Size = new System.Drawing.Size(164, 28);
            this.gestionDeComprasToolStripMenuItem.Text = "Gestion de Compras";
            // 
            // gestionDeVentasToolStripMenuItem
            // 
            this.gestionDeVentasToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.vtas;
            this.gestionDeVentasToolStripMenuItem.Name = "gestionDeVentasToolStripMenuItem";
            this.gestionDeVentasToolStripMenuItem.Size = new System.Drawing.Size(149, 28);
            this.gestionDeVentasToolStripMenuItem.Text = "Gestion de Ventas";
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventario});
            this.inventarioToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources._in;
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(168, 28);
            this.inventarioToolStripMenuItem.Text = "Gestion de Inventario";
            this.inventarioToolStripMenuItem.Click += new System.EventHandler(this.inventario_Click);
            // 
            // inventario
            // 
            this.inventario.Image = global::CapaPresentacion.Properties.Resources.inv;
            this.inventario.Name = "inventario";
            this.inventario.Size = new System.Drawing.Size(188, 30);
            this.inventario.Text = "Inventario";
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.imagess;
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(125, 28);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            // 
            // tmTiempo
            // 
            this.tmTiempo.Enabled = true;
            this.tmTiempo.Tick += new System.EventHandler(this.tmTiempo_Tick);
            // 
            // lblHora
            // 
            this.lblHora.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblHora.Location = new System.Drawing.Point(401, 315);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(158, 50);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "23:21:00";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblFecha.Location = new System.Drawing.Point(403, 382);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(259, 40);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "8 de Junio de 2024";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 450);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Ventas e Inventarios - ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.Timer tmTiempo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ToolStripMenuItem productos;
        private System.Windows.Forms.ToolStripMenuItem inventario;
    }
}

