namespace SistemaVentasUI.Formularios
{
    partial class frmConfiguracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracion));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDatos = new System.Windows.Forms.TabPage();
            this.lblresultado1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.btnguardarcambios = new FontAwesome.Sharp.IconButton();
            this.label11 = new System.Windows.Forms.Label();
            this.txtrazonsocial = new System.Windows.Forms.TextBox();
            this.btnsubir = new FontAwesome.Sharp.IconButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtruc = new System.Windows.Forms.TextBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabCodigoBarra = new System.Windows.Forms.TabPage();
            this.lblresultado2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnguardartipocodigo = new FontAwesome.Sharp.IconButton();
            this.cbotipobarra = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabMonedaImporte = new System.Windows.Forms.TabPage();
            this.lblresultado4 = new System.Windows.Forms.Label();
            this.lblresultado3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtporcentaje = new System.Windows.Forms.NumericUpDown();
            this.btnguardarporcentaje = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtsimbolo = new System.Windows.Forms.TextBox();
            this.btnguardarsimbolo = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabCorreo = new System.Windows.Forms.TabPage();
            this.lblresultado5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.btnguardarcorreo = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabDatos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.tabCodigoBarra.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabMonedaImporte.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtporcentaje)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabCorreo.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDatos);
            this.tabControl1.Controls.Add(this.tabCodigoBarra);
            this.tabControl1.Controls.Add(this.tabMonedaImporte);
            this.tabControl1.Controls.Add(this.tabCorreo);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.HotTrack = true;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(12, 59);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(520, 295);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabDatos
            // 
            this.tabDatos.BackColor = System.Drawing.Color.White;
            this.tabDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabDatos.Controls.Add(this.lblresultado1);
            this.tabDatos.Controls.Add(this.groupBox2);
            this.tabDatos.Controls.Add(this.label9);
            this.tabDatos.ImageKey = "(ninguno)";
            this.tabDatos.Location = new System.Drawing.Point(4, 22);
            this.tabDatos.Name = "tabDatos";
            this.tabDatos.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatos.Size = new System.Drawing.Size(512, 269);
            this.tabDatos.TabIndex = 0;
            this.tabDatos.Text = "Datos del Negocio";
            // 
            // lblresultado1
            // 
            this.lblresultado1.AutoSize = true;
            this.lblresultado1.BackColor = System.Drawing.Color.White;
            this.lblresultado1.ForeColor = System.Drawing.Color.Black;
            this.lblresultado1.Location = new System.Drawing.Point(12, 243);
            this.lblresultado1.Name = "lblresultado1";
            this.lblresultado1.Size = new System.Drawing.Size(60, 13);
            this.lblresultado1.TabIndex = 208;
            this.lblresultado1.Text = "lblresultado";
            this.lblresultado1.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtdireccion);
            this.groupBox2.Controls.Add(this.btnguardarcambios);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtrazonsocial);
            this.groupBox2.Controls.Add(this.btnsubir);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtruc);
            this.groupBox2.Controls.Add(this.picLogo);
            this.groupBox2.Location = new System.Drawing.Point(15, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 204);
            this.groupBox2.TabIndex = 159;
            this.groupBox2.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(177, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 109;
            this.label10.Text = "Dirección:";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(180, 126);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(275, 20);
            this.txtdireccion.TabIndex = 110;
            // 
            // btnguardarcambios
            // 
            this.btnguardarcambios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardarcambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardarcambios.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnguardarcambios.IconColor = System.Drawing.Color.Black;
            this.btnguardarcambios.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnguardarcambios.IconSize = 16;
            this.btnguardarcambios.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnguardarcambios.Location = new System.Drawing.Point(180, 161);
            this.btnguardarcambios.Name = "btnguardarcambios";
            this.btnguardarcambios.Size = new System.Drawing.Size(275, 28);
            this.btnguardarcambios.TabIndex = 108;
            this.btnguardarcambios.Text = "Guardar Cambios";
            this.btnguardarcambios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardarcambios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardarcambios.UseVisualStyleBackColor = true;
            this.btnguardarcambios.Click += new System.EventHandler(this.btnguardarcambios_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(177, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 101;
            this.label11.Text = "Razón Social:";
            // 
            // txtrazonsocial
            // 
            this.txtrazonsocial.Location = new System.Drawing.Point(180, 35);
            this.txtrazonsocial.Name = "txtrazonsocial";
            this.txtrazonsocial.Size = new System.Drawing.Size(275, 20);
            this.txtrazonsocial.TabIndex = 102;
            // 
            // btnsubir
            // 
            this.btnsubir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsubir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubir.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btnsubir.IconColor = System.Drawing.Color.Black;
            this.btnsubir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsubir.IconSize = 16;
            this.btnsubir.Location = new System.Drawing.Point(15, 166);
            this.btnsubir.Name = "btnsubir";
            this.btnsubir.Size = new System.Drawing.Size(136, 23);
            this.btnsubir.TabIndex = 107;
            this.btnsubir.Text = "Subir";
            this.btnsubir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsubir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsubir.UseVisualStyleBackColor = true;
            this.btnsubir.Click += new System.EventHandler(this.btnsubir_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(177, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 103;
            this.label12.Text = "R.U.C:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 106;
            this.label13.Text = "Logo:";
            // 
            // txtruc
            // 
            this.txtruc.Location = new System.Drawing.Point(180, 82);
            this.txtruc.Name = "txtruc";
            this.txtruc.Size = new System.Drawing.Size(275, 20);
            this.txtruc.TabIndex = 104;
            // 
            // picLogo
            // 
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogo.Location = new System.Drawing.Point(15, 35);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(136, 125);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 105;
            this.picLogo.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 17);
            this.label9.TabIndex = 134;
            this.label9.Text = "Datos del Negocio";
            // 
            // tabCodigoBarra
            // 
            this.tabCodigoBarra.BackColor = System.Drawing.Color.White;
            this.tabCodigoBarra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabCodigoBarra.Controls.Add(this.lblresultado2);
            this.tabCodigoBarra.Controls.Add(this.groupBox3);
            this.tabCodigoBarra.Controls.Add(this.label3);
            this.tabCodigoBarra.Location = new System.Drawing.Point(4, 22);
            this.tabCodigoBarra.Name = "tabCodigoBarra";
            this.tabCodigoBarra.Padding = new System.Windows.Forms.Padding(3);
            this.tabCodigoBarra.Size = new System.Drawing.Size(512, 269);
            this.tabCodigoBarra.TabIndex = 1;
            this.tabCodigoBarra.Text = "Codigo de Barras";
            // 
            // lblresultado2
            // 
            this.lblresultado2.AutoSize = true;
            this.lblresultado2.BackColor = System.Drawing.Color.White;
            this.lblresultado2.ForeColor = System.Drawing.Color.Black;
            this.lblresultado2.Location = new System.Drawing.Point(12, 94);
            this.lblresultado2.Name = "lblresultado2";
            this.lblresultado2.Size = new System.Drawing.Size(60, 13);
            this.lblresultado2.TabIndex = 207;
            this.lblresultado2.Text = "lblresultado";
            this.lblresultado2.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnguardartipocodigo);
            this.groupBox3.Controls.Add(this.cbotipobarra);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(15, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(468, 54);
            this.groupBox3.TabIndex = 111;
            this.groupBox3.TabStop = false;
            // 
            // btnguardartipocodigo
            // 
            this.btnguardartipocodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardartipocodigo.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnguardartipocodigo.IconColor = System.Drawing.Color.Black;
            this.btnguardartipocodigo.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnguardartipocodigo.IconSize = 17;
            this.btnguardartipocodigo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnguardartipocodigo.Location = new System.Drawing.Point(251, 19);
            this.btnguardartipocodigo.Name = "btnguardartipocodigo";
            this.btnguardartipocodigo.Size = new System.Drawing.Size(138, 23);
            this.btnguardartipocodigo.TabIndex = 106;
            this.btnguardartipocodigo.Text = "Guardar Cambios";
            this.btnguardartipocodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardartipocodigo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardartipocodigo.UseVisualStyleBackColor = true;
            this.btnguardartipocodigo.Click += new System.EventHandler(this.btnguardartipocodigo_Click);
            // 
            // cbotipobarra
            // 
            this.cbotipobarra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbotipobarra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipobarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotipobarra.FormattingEnabled = true;
            this.cbotipobarra.Location = new System.Drawing.Point(48, 21);
            this.cbotipobarra.Name = "cbotipobarra";
            this.cbotipobarra.Size = new System.Drawing.Size(185, 21);
            this.cbotipobarra.TabIndex = 134;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 133;
            this.label1.Text = "Tipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Codigo de Barras";
            // 
            // tabMonedaImporte
            // 
            this.tabMonedaImporte.BackColor = System.Drawing.Color.White;
            this.tabMonedaImporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabMonedaImporte.Controls.Add(this.lblresultado4);
            this.tabMonedaImporte.Controls.Add(this.lblresultado3);
            this.tabMonedaImporte.Controls.Add(this.label6);
            this.tabMonedaImporte.Controls.Add(this.groupBox4);
            this.tabMonedaImporte.Controls.Add(this.groupBox1);
            this.tabMonedaImporte.Controls.Add(this.label4);
            this.tabMonedaImporte.Location = new System.Drawing.Point(4, 22);
            this.tabMonedaImporte.Name = "tabMonedaImporte";
            this.tabMonedaImporte.Size = new System.Drawing.Size(512, 269);
            this.tabMonedaImporte.TabIndex = 2;
            this.tabMonedaImporte.Text = "Tipo Moneda e Importe";
            // 
            // lblresultado4
            // 
            this.lblresultado4.AutoSize = true;
            this.lblresultado4.BackColor = System.Drawing.Color.White;
            this.lblresultado4.ForeColor = System.Drawing.Color.Black;
            this.lblresultado4.Location = new System.Drawing.Point(12, 198);
            this.lblresultado4.Name = "lblresultado4";
            this.lblresultado4.Size = new System.Drawing.Size(60, 13);
            this.lblresultado4.TabIndex = 210;
            this.lblresultado4.Text = "lblresultado";
            this.lblresultado4.Visible = false;
            // 
            // lblresultado3
            // 
            this.lblresultado3.AutoSize = true;
            this.lblresultado3.BackColor = System.Drawing.Color.White;
            this.lblresultado3.ForeColor = System.Drawing.Color.Black;
            this.lblresultado3.Location = new System.Drawing.Point(12, 93);
            this.lblresultado3.Name = "lblresultado3";
            this.lblresultado3.Size = new System.Drawing.Size(60, 13);
            this.lblresultado3.TabIndex = 209;
            this.lblresultado3.Text = "lblresultado";
            this.lblresultado3.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 17);
            this.label6.TabIndex = 136;
            this.label6.Text = "Porcentaje Importe";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtporcentaje);
            this.groupBox4.Controls.Add(this.btnguardarporcentaje);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(15, 140);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(449, 54);
            this.groupBox4.TabIndex = 135;
            this.groupBox4.TabStop = false;
            // 
            // txtporcentaje
            // 
            this.txtporcentaje.Location = new System.Drawing.Point(83, 22);
            this.txtporcentaje.Name = "txtporcentaje";
            this.txtporcentaje.Size = new System.Drawing.Size(150, 20);
            this.txtporcentaje.TabIndex = 134;
            // 
            // btnguardarporcentaje
            // 
            this.btnguardarporcentaje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardarporcentaje.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnguardarporcentaje.IconColor = System.Drawing.Color.Black;
            this.btnguardarporcentaje.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnguardarporcentaje.IconSize = 17;
            this.btnguardarporcentaje.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnguardarporcentaje.Location = new System.Drawing.Point(250, 19);
            this.btnguardarporcentaje.Name = "btnguardarporcentaje";
            this.btnguardarporcentaje.Size = new System.Drawing.Size(138, 23);
            this.btnguardarporcentaje.TabIndex = 106;
            this.btnguardarporcentaje.Text = "Guardar Cambios";
            this.btnguardarporcentaje.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardarporcentaje.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardarporcentaje.UseVisualStyleBackColor = true;
            this.btnguardarporcentaje.Click += new System.EventHandler(this.btnguardarporcentaje_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 133;
            this.label5.Text = "Porcentaje:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtsimbolo);
            this.groupBox1.Controls.Add(this.btnguardarsimbolo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 54);
            this.groupBox1.TabIndex = 112;
            this.groupBox1.TabStop = false;
            // 
            // txtsimbolo
            // 
            this.txtsimbolo.Location = new System.Drawing.Point(83, 21);
            this.txtsimbolo.Name = "txtsimbolo";
            this.txtsimbolo.Size = new System.Drawing.Size(150, 20);
            this.txtsimbolo.TabIndex = 134;
            // 
            // btnguardarsimbolo
            // 
            this.btnguardarsimbolo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardarsimbolo.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnguardarsimbolo.IconColor = System.Drawing.Color.Black;
            this.btnguardarsimbolo.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnguardarsimbolo.IconSize = 17;
            this.btnguardarsimbolo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnguardarsimbolo.Location = new System.Drawing.Point(250, 19);
            this.btnguardarsimbolo.Name = "btnguardarsimbolo";
            this.btnguardarsimbolo.Size = new System.Drawing.Size(138, 23);
            this.btnguardarsimbolo.TabIndex = 106;
            this.btnguardarsimbolo.Text = "Guardar Cambios";
            this.btnguardarsimbolo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardarsimbolo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardarsimbolo.UseVisualStyleBackColor = true;
            this.btnguardarsimbolo.Click += new System.EventHandler(this.btnguardarsimbolo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 133;
            this.label2.Text = "Simbolo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Simbolo Moneda";
            // 
            // tabCorreo
            // 
            this.tabCorreo.Controls.Add(this.lblresultado5);
            this.tabCorreo.Controls.Add(this.label8);
            this.tabCorreo.Controls.Add(this.groupBox5);
            this.tabCorreo.Location = new System.Drawing.Point(4, 22);
            this.tabCorreo.Name = "tabCorreo";
            this.tabCorreo.Size = new System.Drawing.Size(512, 269);
            this.tabCorreo.TabIndex = 3;
            this.tabCorreo.Text = "Datos del Correo";
            this.tabCorreo.UseVisualStyleBackColor = true;
            // 
            // lblresultado5
            // 
            this.lblresultado5.AutoSize = true;
            this.lblresultado5.BackColor = System.Drawing.Color.White;
            this.lblresultado5.ForeColor = System.Drawing.Color.Black;
            this.lblresultado5.Location = new System.Drawing.Point(12, 183);
            this.lblresultado5.Name = "lblresultado5";
            this.lblresultado5.Size = new System.Drawing.Size(60, 13);
            this.lblresultado5.TabIndex = 211;
            this.lblresultado5.Text = "lblresultado";
            this.lblresultado5.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 17);
            this.label8.TabIndex = 114;
            this.label8.Text = "Credenciales Correo";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.iconButton4);
            this.groupBox5.Controls.Add(this.txtclave);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.txtemail);
            this.groupBox5.Controls.Add(this.btnguardarcorreo);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(15, 34);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(387, 144);
            this.groupBox5.TabIndex = 113;
            this.groupBox5.TabStop = false;
            // 
            // iconButton4
            // 
            this.iconButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton4.IconSize = 17;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton4.Location = new System.Drawing.Point(180, 99);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(138, 23);
            this.iconButton4.TabIndex = 137;
            this.iconButton4.Text = "Enviar Correo Prueba";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = true;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(100, 56);
            this.txtclave.Name = "txtclave";
            this.txtclave.PasswordChar = '*';
            this.txtclave.Size = new System.Drawing.Size(218, 20);
            this.txtclave.TabIndex = 136;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(21, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 15);
            this.label14.TabIndex = 135;
            this.label14.Text = "Contraseña:";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(100, 21);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(218, 20);
            this.txtemail.TabIndex = 134;
            // 
            // btnguardarcorreo
            // 
            this.btnguardarcorreo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardarcorreo.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnguardarcorreo.IconColor = System.Drawing.Color.Black;
            this.btnguardarcorreo.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnguardarcorreo.IconSize = 17;
            this.btnguardarcorreo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnguardarcorreo.Location = new System.Drawing.Point(24, 99);
            this.btnguardarcorreo.Name = "btnguardarcorreo";
            this.btnguardarcorreo.Size = new System.Drawing.Size(138, 23);
            this.btnguardarcorreo.TabIndex = 106;
            this.btnguardarcorreo.Text = "Guardar Cambios";
            this.btnguardarcorreo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardarcorreo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardarcorreo.UseVisualStyleBackColor = true;
            this.btnguardarcorreo.Click += new System.EventHandler(this.btnguardarcorreo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 133;
            this.label7.Text = "Correo:";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.iconPictureBox2.IconColor = System.Drawing.Color.White;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconPictureBox2.IconSize = 39;
            this.iconPictureBox2.Location = new System.Drawing.Point(12, 9);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(43, 39);
            this.iconPictureBox2.TabIndex = 13;
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
            this.label15.Size = new System.Drawing.Size(540, 48);
            this.label15.TabIndex = 12;
            this.label15.Text = "Configuración";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(540, 362);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(556, 401);
            this.MinimumSize = new System.Drawing.Size(556, 401);
            this.Name = "frmConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración";
            this.Load += new System.EventHandler(this.frmConfiguracion_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabDatos.ResumeLayout(false);
            this.tabDatos.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.tabCodigoBarra.ResumeLayout(false);
            this.tabCodigoBarra.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabMonedaImporte.ResumeLayout(false);
            this.tabMonedaImporte.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtporcentaje)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabCorreo.ResumeLayout(false);
            this.tabCorreo.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDatos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabCodigoBarra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabMonedaImporte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtdireccion;
        private FontAwesome.Sharp.IconButton btnguardarcambios;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtrazonsocial;
        private FontAwesome.Sharp.IconButton btnsubir;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtruc;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.GroupBox groupBox3;
        private FontAwesome.Sharp.IconButton btnguardartipocodigo;
        private System.Windows.Forms.ComboBox cbotipobarra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabCorreo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown txtporcentaje;
        private FontAwesome.Sharp.IconButton btnguardarporcentaje;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtsimbolo;
        private FontAwesome.Sharp.IconButton btnguardarsimbolo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtemail;
        private FontAwesome.Sharp.IconButton btnguardarcorreo;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblresultado2;
        private System.Windows.Forms.Label lblresultado1;
        private System.Windows.Forms.Label lblresultado4;
        private System.Windows.Forms.Label lblresultado3;
        private System.Windows.Forms.Label lblresultado5;
    }
}