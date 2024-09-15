namespace SistemaVentasUI.Formularios
{
    partial class frmCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategoria));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCatalogo = new System.Windows.Forms.TabPage();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btneditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btneliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.btndescargar = new FontAwesome.Sharp.IconButton();
            this.btnborrar = new FontAwesome.Sharp.IconButton();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.cbobuscar = new System.Windows.Forms.ComboBox();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabNuevo = new System.Windows.Forms.TabPage();
            this.lblresultado1 = new System.Windows.Forms.Label();
            this.cbomedida1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdescripcion1 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnguardarnuevo = new FontAwesome.Sharp.IconButton();
            this.tabModificar = new System.Windows.Forms.TabPage();
            this.lblresultado2 = new System.Windows.Forms.Label();
            this.cbomedida2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdescripcion2 = new System.Windows.Forms.TextBox();
            this.txtidcategoria = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnbuscarcategoria = new FontAwesome.Sharp.IconButton();
            this.btnguardarmodificar = new FontAwesome.Sharp.IconButton();
            this.label10 = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.tabControl1.SuspendLayout();
            this.tabCatalogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.tabNuevo.SuspendLayout();
            this.tabModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCatalogo);
            this.tabControl1.Controls.Add(this.tabNuevo);
            this.tabControl1.Controls.Add(this.tabModificar);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.HotTrack = true;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(9, 63);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(803, 451);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabCatalogo
            // 
            this.tabCatalogo.BackColor = System.Drawing.Color.White;
            this.tabCatalogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabCatalogo.Controls.Add(this.dgvdata);
            this.tabCatalogo.Controls.Add(this.label9);
            this.tabCatalogo.Controls.Add(this.btndescargar);
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
            this.tabCatalogo.Text = "Catalogo Categorias";
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
            this.Descripcion,
            this.Medida,
            this.FechaRegistro,
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
            this.Id.HeaderText = "Id Categoria";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id.Width = 80;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Descripcion.Width = 200;
            // 
            // Medida
            // 
            this.Medida.HeaderText = "Medida";
            this.Medida.Name = "Medida";
            this.Medida.ReadOnly = true;
            this.Medida.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha Registro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            this.FechaRegistro.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FechaRegistro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.label9.Size = new System.Drawing.Size(155, 17);
            this.label9.TabIndex = 134;
            this.label9.Text = "Catalogo Categorias";
            // 
            // btndescargar
            // 
            this.btndescargar.BackColor = System.Drawing.Color.ForestGreen;
            this.btndescargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndescargar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndescargar.ForeColor = System.Drawing.Color.White;
            this.btndescargar.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btndescargar.IconColor = System.Drawing.Color.White;
            this.btndescargar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btndescargar.IconSize = 17;
            this.btndescargar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btndescargar.Location = new System.Drawing.Point(24, 45);
            this.btndescargar.Name = "btndescargar";
            this.btndescargar.Size = new System.Drawing.Size(128, 21);
            this.btndescargar.TabIndex = 133;
            this.btndescargar.Text = "Descargar Reporte";
            this.btndescargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndescargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndescargar.UseVisualStyleBackColor = false;
            this.btndescargar.Click += new System.EventHandler(this.btndescargar_Click);
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
            // tabNuevo
            // 
            this.tabNuevo.BackColor = System.Drawing.Color.White;
            this.tabNuevo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabNuevo.Controls.Add(this.lblresultado1);
            this.tabNuevo.Controls.Add(this.cbomedida1);
            this.tabNuevo.Controls.Add(this.label7);
            this.tabNuevo.Controls.Add(this.label3);
            this.tabNuevo.Controls.Add(this.txtdescripcion1);
            this.tabNuevo.Controls.Add(this.textBox1);
            this.tabNuevo.Controls.Add(this.label2);
            this.tabNuevo.Controls.Add(this.label1);
            this.tabNuevo.Controls.Add(this.btnguardarnuevo);
            this.tabNuevo.Location = new System.Drawing.Point(4, 22);
            this.tabNuevo.Name = "tabNuevo";
            this.tabNuevo.Padding = new System.Windows.Forms.Padding(3);
            this.tabNuevo.Size = new System.Drawing.Size(795, 425);
            this.tabNuevo.TabIndex = 1;
            this.tabNuevo.Text = "Nueva Categoria";
            // 
            // lblresultado1
            // 
            this.lblresultado1.AutoSize = true;
            this.lblresultado1.BackColor = System.Drawing.Color.White;
            this.lblresultado1.ForeColor = System.Drawing.Color.Black;
            this.lblresultado1.Location = new System.Drawing.Point(28, 203);
            this.lblresultado1.Name = "lblresultado1";
            this.lblresultado1.Size = new System.Drawing.Size(66, 13);
            this.lblresultado1.TabIndex = 204;
            this.lblresultado1.Text = "lblresultado1";
            this.lblresultado1.Visible = false;
            // 
            // cbomedida1
            // 
            this.cbomedida1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbomedida1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomedida1.FormattingEnabled = true;
            this.cbomedida1.Location = new System.Drawing.Point(104, 128);
            this.cbomedida1.Name = "cbomedida1";
            this.cbomedida1.Size = new System.Drawing.Size(164, 21);
            this.cbomedida1.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Medida:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nueva Categoria";
            // 
            // txtdescripcion1
            // 
            this.txtdescripcion1.Location = new System.Drawing.Point(104, 93);
            this.txtdescripcion1.Name = "txtdescripcion1";
            this.txtdescripcion1.Size = new System.Drawing.Size(164, 20);
            this.txtdescripcion1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(164, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Autogenerado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Categoria:";
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
            this.btnguardarnuevo.Location = new System.Drawing.Point(31, 173);
            this.btnguardarnuevo.Name = "btnguardarnuevo";
            this.btnguardarnuevo.Size = new System.Drawing.Size(237, 23);
            this.btnguardarnuevo.TabIndex = 4;
            this.btnguardarnuevo.Text = "Guardar";
            this.btnguardarnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardarnuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardarnuevo.UseVisualStyleBackColor = false;
            this.btnguardarnuevo.Click += new System.EventHandler(this.btnguardarnuevo_Click);
            // 
            // tabModificar
            // 
            this.tabModificar.BackColor = System.Drawing.Color.White;
            this.tabModificar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabModificar.Controls.Add(this.lblresultado2);
            this.tabModificar.Controls.Add(this.cbomedida2);
            this.tabModificar.Controls.Add(this.label8);
            this.tabModificar.Controls.Add(this.label4);
            this.tabModificar.Controls.Add(this.txtdescripcion2);
            this.tabModificar.Controls.Add(this.txtidcategoria);
            this.tabModificar.Controls.Add(this.label5);
            this.tabModificar.Controls.Add(this.label6);
            this.tabModificar.Controls.Add(this.btnbuscarcategoria);
            this.tabModificar.Controls.Add(this.btnguardarmodificar);
            this.tabModificar.Location = new System.Drawing.Point(4, 22);
            this.tabModificar.Name = "tabModificar";
            this.tabModificar.Size = new System.Drawing.Size(795, 425);
            this.tabModificar.TabIndex = 2;
            this.tabModificar.Text = "Modificar Categoria";
            // 
            // lblresultado2
            // 
            this.lblresultado2.AutoSize = true;
            this.lblresultado2.BackColor = System.Drawing.Color.White;
            this.lblresultado2.ForeColor = System.Drawing.Color.Black;
            this.lblresultado2.Location = new System.Drawing.Point(26, 197);
            this.lblresultado2.Name = "lblresultado2";
            this.lblresultado2.Size = new System.Drawing.Size(66, 13);
            this.lblresultado2.TabIndex = 205;
            this.lblresultado2.Text = "lblresultado2";
            this.lblresultado2.Visible = false;
            // 
            // cbomedida2
            // 
            this.cbomedida2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbomedida2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomedida2.FormattingEnabled = true;
            this.cbomedida2.Location = new System.Drawing.Point(102, 130);
            this.cbomedida2.Name = "cbomedida2";
            this.cbomedida2.Size = new System.Drawing.Size(164, 21);
            this.cbomedida2.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Medida:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Modificar Categoria";
            // 
            // txtdescripcion2
            // 
            this.txtdescripcion2.Location = new System.Drawing.Point(102, 95);
            this.txtdescripcion2.Name = "txtdescripcion2";
            this.txtdescripcion2.Size = new System.Drawing.Size(164, 20);
            this.txtdescripcion2.TabIndex = 9;
            // 
            // txtidcategoria
            // 
            this.txtidcategoria.Location = new System.Drawing.Point(102, 59);
            this.txtidcategoria.Name = "txtidcategoria";
            this.txtidcategoria.Size = new System.Drawing.Size(122, 20);
            this.txtidcategoria.TabIndex = 8;
            this.txtidcategoria.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtidcategoria_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Descripción:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "ID Categoria:";
            // 
            // btnbuscarcategoria
            // 
            this.btnbuscarcategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(124)))));
            this.btnbuscarcategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarcategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbuscarcategoria.ForeColor = System.Drawing.Color.White;
            this.btnbuscarcategoria.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnbuscarcategoria.IconColor = System.Drawing.Color.White;
            this.btnbuscarcategoria.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnbuscarcategoria.IconSize = 18;
            this.btnbuscarcategoria.Location = new System.Drawing.Point(230, 57);
            this.btnbuscarcategoria.Name = "btnbuscarcategoria";
            this.btnbuscarcategoria.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnbuscarcategoria.Size = new System.Drawing.Size(36, 23);
            this.btnbuscarcategoria.TabIndex = 12;
            this.btnbuscarcategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscarcategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscarcategoria.UseVisualStyleBackColor = false;
            this.btnbuscarcategoria.Click += new System.EventHandler(this.btnbuscarcategoria_Click);
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
            this.btnguardarmodificar.Location = new System.Drawing.Point(29, 166);
            this.btnguardarmodificar.Name = "btnguardarmodificar";
            this.btnguardarmodificar.Size = new System.Drawing.Size(237, 23);
            this.btnguardarmodificar.TabIndex = 10;
            this.btnguardarmodificar.Text = "Guardar";
            this.btnguardarmodificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardarmodificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardarmodificar.UseVisualStyleBackColor = false;
            this.btnguardarmodificar.Click += new System.EventHandler(this.btnguardarmodificar_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(58)))), ((int)(((byte)(0)))));
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(815, 48);
            this.label10.TabIndex = 2;
            this.label10.Text = "Menu Categorias";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(58)))), ((int)(((byte)(0)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.iconPictureBox2.IconColor = System.Drawing.Color.White;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconPictureBox2.IconSize = 39;
            this.iconPictureBox2.Location = new System.Drawing.Point(9, 9);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(43, 39);
            this.iconPictureBox2.TabIndex = 11;
            this.iconPictureBox2.TabStop = false;
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(815, 522);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(831, 561);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(831, 561);
            this.Name = "frmCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmCategoria_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabCatalogo.ResumeLayout(false);
            this.tabCatalogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.tabNuevo.ResumeLayout(false);
            this.tabNuevo.PerformLayout();
            this.tabModificar.ResumeLayout(false);
            this.tabModificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCatalogo;
        private System.Windows.Forms.TabPage tabNuevo;
        private System.Windows.Forms.TabPage tabModificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdescripcion1;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton btnguardarnuevo;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnbuscarcategoria;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnguardarmodificar;
        private System.Windows.Forms.TextBox txtdescripcion2;
        private System.Windows.Forms.TextBox txtidcategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton btndescargar;
        private FontAwesome.Sharp.IconButton btnborrar;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.ComboBox cbobuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbomedida1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbomedida2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.Label lblresultado1;
        private System.Windows.Forms.Label lblresultado2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewButtonColumn btneditar;
        private System.Windows.Forms.DataGridViewButtonColumn btneliminar;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
    }
}