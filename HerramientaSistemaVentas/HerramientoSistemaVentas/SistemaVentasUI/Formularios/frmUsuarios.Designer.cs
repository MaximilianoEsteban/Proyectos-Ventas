namespace SistemaVentasUI.Formularios
{
    partial class frmUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.lblresultado2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnbuscarusuario = new FontAwesome.Sharp.IconButton();
            this.tabModificar = new System.Windows.Forms.TabPage();
            this.cborol2 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtconfirmclave2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtclave2 = new System.Windows.Forms.TextBox();
            this.txtnombrecompleto2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnrodocumento2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtusuario2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnguardarmodificar = new FontAwesome.Sharp.IconButton();
            this.lblresultado1 = new System.Windows.Forms.Label();
            this.tabNuevo = new System.Windows.Forms.TabPage();
            this.cborol1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtconfirmclave1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtclave1 = new System.Windows.Forms.TextBox();
            this.txtnombrecompleto1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtnrodocumento1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtusuario1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnguardarnuevo = new FontAwesome.Sharp.IconButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCatalogo = new System.Windows.Forms.TabPage();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btneditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btneliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.btnborrar = new FontAwesome.Sharp.IconButton();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.cbobuscar = new System.Windows.Forms.ComboBox();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.tabModificar.SuspendLayout();
            this.tabNuevo.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabCatalogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox2.IconColor = System.Drawing.Color.White;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconPictureBox2.IconSize = 39;
            this.iconPictureBox2.Location = new System.Drawing.Point(13, 9);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(43, 39);
            this.iconPictureBox2.TabIndex = 14;
            this.iconPictureBox2.TabStop = false;
            // 
            // lblresultado2
            // 
            this.lblresultado2.AutoSize = true;
            this.lblresultado2.BackColor = System.Drawing.Color.White;
            this.lblresultado2.ForeColor = System.Drawing.Color.Black;
            this.lblresultado2.Location = new System.Drawing.Point(132, 286);
            this.lblresultado2.Name = "lblresultado2";
            this.lblresultado2.Size = new System.Drawing.Size(66, 13);
            this.lblresultado2.TabIndex = 205;
            this.lblresultado2.Text = "lblresultado2";
            this.lblresultado2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Modificar Usuario";
            // 
            // btnbuscarusuario
            // 
            this.btnbuscarusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(124)))));
            this.btnbuscarusuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarusuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbuscarusuario.ForeColor = System.Drawing.Color.White;
            this.btnbuscarusuario.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnbuscarusuario.IconColor = System.Drawing.Color.White;
            this.btnbuscarusuario.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnbuscarusuario.IconSize = 18;
            this.btnbuscarusuario.Location = new System.Drawing.Point(305, 52);
            this.btnbuscarusuario.Name = "btnbuscarusuario";
            this.btnbuscarusuario.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnbuscarusuario.Size = new System.Drawing.Size(36, 23);
            this.btnbuscarusuario.TabIndex = 12;
            this.btnbuscarusuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscarusuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscarusuario.UseVisualStyleBackColor = false;
            this.btnbuscarusuario.Click += new System.EventHandler(this.btnbuscarusuario_Click);
            // 
            // tabModificar
            // 
            this.tabModificar.BackColor = System.Drawing.Color.White;
            this.tabModificar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabModificar.Controls.Add(this.cborol2);
            this.tabModificar.Controls.Add(this.label17);
            this.tabModificar.Controls.Add(this.txtid);
            this.tabModificar.Controls.Add(this.txtconfirmclave2);
            this.tabModificar.Controls.Add(this.label5);
            this.tabModificar.Controls.Add(this.txtclave2);
            this.tabModificar.Controls.Add(this.txtnombrecompleto2);
            this.tabModificar.Controls.Add(this.label8);
            this.tabModificar.Controls.Add(this.txtnrodocumento2);
            this.tabModificar.Controls.Add(this.label14);
            this.tabModificar.Controls.Add(this.txtusuario2);
            this.tabModificar.Controls.Add(this.label15);
            this.tabModificar.Controls.Add(this.label16);
            this.tabModificar.Controls.Add(this.lblresultado2);
            this.tabModificar.Controls.Add(this.label4);
            this.tabModificar.Controls.Add(this.btnbuscarusuario);
            this.tabModificar.Controls.Add(this.btnguardarmodificar);
            this.tabModificar.Location = new System.Drawing.Point(4, 22);
            this.tabModificar.Name = "tabModificar";
            this.tabModificar.Size = new System.Drawing.Size(795, 425);
            this.tabModificar.TabIndex = 2;
            this.tabModificar.Text = "Modificar Usuario";
            // 
            // cborol2
            // 
            this.cborol2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cborol2.FormattingEnabled = true;
            this.cborol2.Location = new System.Drawing.Point(135, 149);
            this.cborol2.Name = "cborol2";
            this.cborol2.Size = new System.Drawing.Size(164, 21);
            this.cborol2.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(83, 152);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(26, 13);
            this.label17.TabIndex = 223;
            this.label17.Text = "Rol:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(305, 26);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(36, 20);
            this.txtid.TabIndex = 221;
            this.txtid.Visible = false;
            // 
            // txtconfirmclave2
            // 
            this.txtconfirmclave2.Location = new System.Drawing.Point(135, 212);
            this.txtconfirmclave2.Name = "txtconfirmclave2";
            this.txtconfirmclave2.PasswordChar = '*';
            this.txtconfirmclave2.Size = new System.Drawing.Size(164, 20);
            this.txtconfirmclave2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 219;
            this.label5.Text = "Confirmar Contraseña:";
            // 
            // txtclave2
            // 
            this.txtclave2.Location = new System.Drawing.Point(135, 181);
            this.txtclave2.Name = "txtclave2";
            this.txtclave2.PasswordChar = '*';
            this.txtclave2.Size = new System.Drawing.Size(164, 20);
            this.txtclave2.TabIndex = 5;
            // 
            // txtnombrecompleto2
            // 
            this.txtnombrecompleto2.Location = new System.Drawing.Point(135, 118);
            this.txtnombrecompleto2.Name = "txtnombrecompleto2";
            this.txtnombrecompleto2.Size = new System.Drawing.Size(164, 20);
            this.txtnombrecompleto2.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 216;
            this.label8.Text = "Nombre Completo:";
            // 
            // txtnrodocumento2
            // 
            this.txtnrodocumento2.Location = new System.Drawing.Point(135, 86);
            this.txtnrodocumento2.Name = "txtnrodocumento2";
            this.txtnrodocumento2.Size = new System.Drawing.Size(164, 20);
            this.txtnrodocumento2.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(65, 184);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 214;
            this.label14.Text = "Contraseña:";
            // 
            // txtusuario2
            // 
            this.txtusuario2.Location = new System.Drawing.Point(135, 54);
            this.txtusuario2.Name = "txtusuario2";
            this.txtusuario2.Size = new System.Drawing.Size(164, 20);
            this.txtusuario2.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(41, 89);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 13);
            this.label15.TabIndex = 212;
            this.label15.Text = "Nro. Documento:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(83, 57);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 211;
            this.label16.Text = "Usuario:";
            // 
            // btnguardarmodificar
            // 
            this.btnguardarmodificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(101)))), ((int)(((byte)(168)))));
            this.btnguardarmodificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardarmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnguardarmodificar.ForeColor = System.Drawing.Color.White;
            this.btnguardarmodificar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnguardarmodificar.IconColor = System.Drawing.Color.White;
            this.btnguardarmodificar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnguardarmodificar.IconSize = 18;
            this.btnguardarmodificar.Location = new System.Drawing.Point(135, 253);
            this.btnguardarmodificar.Name = "btnguardarmodificar";
            this.btnguardarmodificar.Size = new System.Drawing.Size(164, 23);
            this.btnguardarmodificar.TabIndex = 7;
            this.btnguardarmodificar.Text = "Guardar";
            this.btnguardarmodificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardarmodificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardarmodificar.UseVisualStyleBackColor = false;
            this.btnguardarmodificar.Click += new System.EventHandler(this.btnguardarmodificar_Click);
            // 
            // lblresultado1
            // 
            this.lblresultado1.AutoSize = true;
            this.lblresultado1.BackColor = System.Drawing.Color.White;
            this.lblresultado1.ForeColor = System.Drawing.Color.Black;
            this.lblresultado1.Location = new System.Drawing.Point(131, 294);
            this.lblresultado1.Name = "lblresultado1";
            this.lblresultado1.Size = new System.Drawing.Size(66, 13);
            this.lblresultado1.TabIndex = 204;
            this.lblresultado1.Text = "lblresultado1";
            this.lblresultado1.Visible = false;
            // 
            // tabNuevo
            // 
            this.tabNuevo.BackColor = System.Drawing.Color.White;
            this.tabNuevo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabNuevo.Controls.Add(this.cborol1);
            this.tabNuevo.Controls.Add(this.label6);
            this.tabNuevo.Controls.Add(this.txtconfirmclave1);
            this.tabNuevo.Controls.Add(this.label13);
            this.tabNuevo.Controls.Add(this.txtclave1);
            this.tabNuevo.Controls.Add(this.txtnombrecompleto1);
            this.tabNuevo.Controls.Add(this.label11);
            this.tabNuevo.Controls.Add(this.txtnrodocumento1);
            this.tabNuevo.Controls.Add(this.lblresultado1);
            this.tabNuevo.Controls.Add(this.label7);
            this.tabNuevo.Controls.Add(this.label3);
            this.tabNuevo.Controls.Add(this.txtusuario1);
            this.tabNuevo.Controls.Add(this.label2);
            this.tabNuevo.Controls.Add(this.label1);
            this.tabNuevo.Controls.Add(this.btnguardarnuevo);
            this.tabNuevo.Location = new System.Drawing.Point(4, 22);
            this.tabNuevo.Name = "tabNuevo";
            this.tabNuevo.Padding = new System.Windows.Forms.Padding(3);
            this.tabNuevo.Size = new System.Drawing.Size(795, 425);
            this.tabNuevo.TabIndex = 1;
            this.tabNuevo.Text = "Nuevo Usuario";
            // 
            // cborol1
            // 
            this.cborol1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cborol1.FormattingEnabled = true;
            this.cborol1.Location = new System.Drawing.Point(134, 152);
            this.cborol1.Name = "cborol1";
            this.cborol1.Size = new System.Drawing.Size(164, 21);
            this.cborol1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(82, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 219;
            this.label6.Text = "Rol:";
            // 
            // txtconfirmclave1
            // 
            this.txtconfirmclave1.Location = new System.Drawing.Point(134, 217);
            this.txtconfirmclave1.Name = "txtconfirmclave1";
            this.txtconfirmclave1.PasswordChar = '*';
            this.txtconfirmclave1.Size = new System.Drawing.Size(164, 20);
            this.txtconfirmclave1.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 220);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 13);
            this.label13.TabIndex = 209;
            this.label13.Text = "Confirmar Contraseña:";
            // 
            // txtclave1
            // 
            this.txtclave1.Location = new System.Drawing.Point(134, 186);
            this.txtclave1.Name = "txtclave1";
            this.txtclave1.PasswordChar = '*';
            this.txtclave1.Size = new System.Drawing.Size(164, 20);
            this.txtclave1.TabIndex = 5;
            // 
            // txtnombrecompleto1
            // 
            this.txtnombrecompleto1.Location = new System.Drawing.Point(134, 121);
            this.txtnombrecompleto1.Name = "txtnombrecompleto1";
            this.txtnombrecompleto1.Size = new System.Drawing.Size(164, 20);
            this.txtnombrecompleto1.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 206;
            this.label11.Text = "Nombre Completo:";
            // 
            // txtnrodocumento1
            // 
            this.txtnrodocumento1.Location = new System.Drawing.Point(134, 89);
            this.txtnrodocumento1.Name = "txtnrodocumento1";
            this.txtnrodocumento1.Size = new System.Drawing.Size(164, 20);
            this.txtnrodocumento1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nuevo Usuario";
            // 
            // txtusuario1
            // 
            this.txtusuario1.Location = new System.Drawing.Point(134, 57);
            this.txtusuario1.Name = "txtusuario1";
            this.txtusuario1.Size = new System.Drawing.Size(164, 20);
            this.txtusuario1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nro. Documento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // btnguardarnuevo
            // 
            this.btnguardarnuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(101)))), ((int)(((byte)(168)))));
            this.btnguardarnuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardarnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnguardarnuevo.ForeColor = System.Drawing.Color.White;
            this.btnguardarnuevo.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnguardarnuevo.IconColor = System.Drawing.Color.White;
            this.btnguardarnuevo.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnguardarnuevo.IconSize = 18;
            this.btnguardarnuevo.Location = new System.Drawing.Point(134, 262);
            this.btnguardarnuevo.Name = "btnguardarnuevo";
            this.btnguardarnuevo.Size = new System.Drawing.Size(164, 23);
            this.btnguardarnuevo.TabIndex = 7;
            this.btnguardarnuevo.Text = "Guardar";
            this.btnguardarnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardarnuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardarnuevo.UseVisualStyleBackColor = false;
            this.btnguardarnuevo.Click += new System.EventHandler(this.btnguardarnuevo_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(324, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 15);
            this.label12.TabIndex = 113;
            this.label12.Text = "Buscar por:";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(820, 48);
            this.label10.TabIndex = 13;
            this.label10.Text = "Menu Usuarios";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCatalogo);
            this.tabControl1.Controls.Add(this.tabNuevo);
            this.tabControl1.Controls.Add(this.tabModificar);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.HotTrack = true;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(9, 59);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(803, 451);
            this.tabControl1.TabIndex = 12;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabCatalogo
            // 
            this.tabCatalogo.BackColor = System.Drawing.Color.White;
            this.tabCatalogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabCatalogo.Controls.Add(this.dgvdata);
            this.tabCatalogo.Controls.Add(this.label9);
            this.tabCatalogo.Controls.Add(this.btnborrar);
            this.tabCatalogo.Controls.Add(this.btnbuscar);
            this.tabCatalogo.Controls.Add(this.cbobuscar);
            this.tabCatalogo.Controls.Add(this.txtbuscar);
            this.tabCatalogo.Controls.Add(this.label12);
            this.tabCatalogo.ImageKey = "(ninguno)";
            this.tabCatalogo.Location = new System.Drawing.Point(4, 22);
            this.tabCatalogo.Name = "tabCatalogo";
            this.tabCatalogo.Padding = new System.Windows.Forms.Padding(3);
            this.tabCatalogo.Size = new System.Drawing.Size(795, 425);
            this.tabCatalogo.TabIndex = 0;
            this.tabCatalogo.Text = "Lista Usuarios";
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NombreUsuario,
            this.NumeroDocumento,
            this.NombreCompleto,
            this.Rol,
            this.FechaRegistro,
            this.Clave,
            this.btneditar,
            this.btneliminar});
            this.dgvdata.EnableHeadersVisualStyles = false;
            this.dgvdata.Location = new System.Drawing.Point(24, 85);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.RowHeadersVisible = false;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Transparent;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvdata.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvdata.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvdata.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowTemplate.Height = 24;
            this.dgvdata.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdata.Size = new System.Drawing.Size(745, 323);
            this.dgvdata.TabIndex = 135;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            this.dgvdata.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvdata_CellPainting);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id.Visible = false;
            this.Id.Width = 80;
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.HeaderText = "Usuario";
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.ReadOnly = true;
            this.NombreUsuario.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NombreUsuario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NombreUsuario.Width = 170;
            // 
            // NumeroDocumento
            // 
            this.NumeroDocumento.HeaderText = "Numero Documento";
            this.NumeroDocumento.Name = "NumeroDocumento";
            this.NumeroDocumento.ReadOnly = true;
            this.NumeroDocumento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NumeroDocumento.Width = 115;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.HeaderText = "Nombre Completo";
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            this.NombreCompleto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NombreCompleto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NombreCompleto.Width = 180;
            // 
            // Rol
            // 
            this.Rol.HeaderText = "Rol";
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha Registro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            this.FechaRegistro.Width = 95;
            // 
            // Clave
            // 
            this.Clave.HeaderText = "Clave";
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            this.Clave.Visible = false;
            // 
            // btneditar
            // 
            this.btneditar.HeaderText = "";
            this.btneditar.MinimumWidth = 35;
            this.btneditar.Name = "btneditar";
            this.btneditar.ReadOnly = true;
            this.btneditar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btneditar.Width = 35;
            // 
            // btneliminar
            // 
            this.btneliminar.HeaderText = "";
            this.btneliminar.MinimumWidth = 35;
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.ReadOnly = true;
            this.btneliminar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btneliminar.Width = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 17);
            this.label9.TabIndex = 134;
            this.label9.Text = "Lista de Usuarios";
            // 
            // btnborrar
            // 
            this.btnborrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnborrar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnborrar.IconColor = System.Drawing.Color.Black;
            this.btnborrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnborrar.IconSize = 20;
            this.btnborrar.Location = new System.Drawing.Point(732, 46);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnborrar.Size = new System.Drawing.Size(37, 21);
            this.btnborrar.TabIndex = 111;
            this.btnborrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnborrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnbuscar.IconColor = System.Drawing.Color.Black;
            this.btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscar.IconSize = 18;
            this.btnbuscar.Location = new System.Drawing.Point(691, 46);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnbuscar.Size = new System.Drawing.Size(37, 21);
            this.btnbuscar.TabIndex = 110;
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // cbobuscar
            // 
            this.cbobuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbobuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbobuscar.FormattingEnabled = true;
            this.cbobuscar.Location = new System.Drawing.Point(399, 46);
            this.cbobuscar.Name = "cbobuscar";
            this.cbobuscar.Size = new System.Drawing.Size(145, 21);
            this.cbobuscar.TabIndex = 108;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.Location = new System.Drawing.Point(550, 46);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(135, 21);
            this.txtbuscar.TabIndex = 109;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 525);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(836, 564);
            this.MinimumSize = new System.Drawing.Size(836, 564);
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUsuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.tabModificar.ResumeLayout(false);
            this.tabModificar.PerformLayout();
            this.tabNuevo.ResumeLayout(false);
            this.tabNuevo.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabCatalogo.ResumeLayout(false);
            this.tabCatalogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label lblresultado2;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnbuscarusuario;
        private System.Windows.Forms.TabPage tabModificar;
        private FontAwesome.Sharp.IconButton btnguardarmodificar;
        private System.Windows.Forms.Label lblresultado1;
        private System.Windows.Forms.TabPage tabNuevo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtusuario1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnguardarnuevo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCatalogo;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton btnborrar;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.ComboBox cbobuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.TextBox txtnombrecompleto1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtnrodocumento1;
        private System.Windows.Forms.TextBox txtconfirmclave1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtclave1;
        private System.Windows.Forms.TextBox txtconfirmclave2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtclave2;
        private System.Windows.Forms.TextBox txtnombrecompleto2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtnrodocumento2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtusuario2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.ComboBox cborol1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cborol2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewButtonColumn btneditar;
        private System.Windows.Forms.DataGridViewButtonColumn btneliminar;
    }
}