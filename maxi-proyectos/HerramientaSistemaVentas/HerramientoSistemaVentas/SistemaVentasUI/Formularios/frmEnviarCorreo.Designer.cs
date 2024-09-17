namespace SistemaVentasUI.Formularios
{
    partial class frmEnviarCorreo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnviarCorreo));
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnenviar = new FontAwesome.Sharp.IconButton();
            this.btncerrar = new FontAwesome.Sharp.IconButton();
            this.lblresultado5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.iconPictureBox2.IconColor = System.Drawing.Color.White;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconPictureBox2.IconSize = 39;
            this.iconPictureBox2.Location = new System.Drawing.Point(12, 9);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(43, 39);
            this.iconPictureBox2.TabIndex = 15;
            this.iconPictureBox2.TabStop = false;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label15.Dock = System.Windows.Forms.DockStyle.Top;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(429, 48);
            this.label15.TabIndex = 14;
            this.label15.Text = "Enviar Correo Prueba";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(90, 66);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(274, 20);
            this.txtcorreo.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Correo:";
            // 
            // btnenviar
            // 
            this.btnenviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnenviar.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.btnenviar.IconColor = System.Drawing.Color.Black;
            this.btnenviar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnenviar.IconSize = 17;
            this.btnenviar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnenviar.Location = new System.Drawing.Point(90, 101);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(130, 23);
            this.btnenviar.TabIndex = 138;
            this.btnenviar.Text = "Enviar";
            this.btnenviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnenviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnenviar.UseVisualStyleBackColor = true;
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btncerrar.IconColor = System.Drawing.Color.Black;
            this.btncerrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btncerrar.IconSize = 17;
            this.btncerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncerrar.Location = new System.Drawing.Point(234, 101);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(130, 23);
            this.btncerrar.TabIndex = 139;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // lblresultado5
            // 
            this.lblresultado5.AutoSize = true;
            this.lblresultado5.BackColor = System.Drawing.Color.White;
            this.lblresultado5.ForeColor = System.Drawing.Color.Black;
            this.lblresultado5.Location = new System.Drawing.Point(87, 129);
            this.lblresultado5.Name = "lblresultado5";
            this.lblresultado5.Size = new System.Drawing.Size(60, 13);
            this.lblresultado5.TabIndex = 212;
            this.lblresultado5.Text = "lblresultado";
            this.lblresultado5.Visible = false;
            // 
            // frmEnviarCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(429, 156);
            this.Controls.Add(this.lblresultado5);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnenviar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.label15);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(445, 195);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(445, 195);
            this.Name = "frmEnviarCorreo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEnviarCorreo";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnenviar;
        private FontAwesome.Sharp.IconButton btncerrar;
        private System.Windows.Forms.Label lblresultado5;
    }
}