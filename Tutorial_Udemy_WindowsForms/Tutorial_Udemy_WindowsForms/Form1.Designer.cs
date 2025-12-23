namespace Tutorial_Udemy_WindowsForms
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblPaginas = new System.Windows.Forms.Label();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, -10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1518, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monospac821 BT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(422, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(663, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de estudiantes";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.btnQuitar);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.lblEmail);
            this.groupBox2.Controls.Add(this.txtApellido);
            this.groupBox2.Controls.Add(this.lblApellido);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.lblNombre);
            this.groupBox2.Controls.Add(this.lblID);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(555, 789);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = global::Tutorial_Udemy_WindowsForms.Properties.Resources.delete;
            this.btnEliminar.Location = new System.Drawing.Point(205, 678);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(156, 73);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Image = global::Tutorial_Udemy_WindowsForms.Properties.Resources.add;
            this.btnAgregar.Location = new System.Drawing.Point(28, 678);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(156, 73);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnQuitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnQuitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Image = global::Tutorial_Udemy_WindowsForms.Properties.Resources.cancel;
            this.btnQuitar.Location = new System.Drawing.Point(381, 678);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(156, 73);
            this.btnQuitar.TabIndex = 7;
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(288, 595);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(249, 53);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblEmail.Location = new System.Drawing.Point(281, 557);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(89, 38);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(26, 595);
            this.txtApellido.Multiline = true;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(249, 53);
            this.txtApellido.TabIndex = 3;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblApellido.Location = new System.Drawing.Point(21, 553);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(127, 38);
            this.lblApellido.TabIndex = 7;
            this.lblApellido.Text = "Apellido";
            this.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(26, 497);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(249, 53);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblNombre.Location = new System.Drawing.Point(21, 456);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(125, 38);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblID.Location = new System.Drawing.Point(281, 456);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(196, 38);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "Identificacion";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(288, 497);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(249, 53);
            this.txtID.TabIndex = 2;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pictureBox1);
            this.groupBox5.Location = new System.Drawing.Point(65, 92);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(405, 337);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tutorial_Udemy_WindowsForms.Properties.Resources.person_24dp_1F1F1F;
            this.pictureBox1.Location = new System.Drawing.Point(16, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(383, 308);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(73, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(413, 48);
            this.label3.TabIndex = 0;
            this.label3.Text = "Informacion estudiante";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.lblPaginas);
            this.groupBox3.Controls.Add(this.btnUltimo);
            this.groupBox3.Controls.Add(this.btnSiguiente);
            this.groupBox3.Controls.Add(this.btnAnterior);
            this.groupBox3.Controls.Add(this.btnPrimero);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(573, 219);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(937, 789);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(33, 720);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(79, 26);
            this.numericUpDown1.TabIndex = 15;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lblPaginas
            // 
            this.lblPaginas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPaginas.AutoSize = true;
            this.lblPaginas.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaginas.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblPaginas.Location = new System.Drawing.Point(393, 652);
            this.lblPaginas.Name = "lblPaginas";
            this.lblPaginas.Size = new System.Drawing.Size(149, 48);
            this.lblPaginas.TabIndex = 14;
            this.lblPaginas.Text = "Paginas";
            this.lblPaginas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUltimo
            // 
            this.btnUltimo.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUltimo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUltimo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUltimo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUltimo.Image = global::Tutorial_Udemy_WindowsForms.Properties.Resources.add;
            this.btnUltimo.Location = new System.Drawing.Point(574, 703);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(102, 58);
            this.btnUltimo.TabIndex = 13;
            this.btnUltimo.UseVisualStyleBackColor = false;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Image = global::Tutorial_Udemy_WindowsForms.Properties.Resources.add;
            this.btnSiguiente.Location = new System.Drawing.Point(466, 703);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(102, 58);
            this.btnSiguiente.TabIndex = 12;
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAnterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnterior.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAnterior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Image = global::Tutorial_Udemy_WindowsForms.Properties.Resources.add;
            this.btnAnterior.Location = new System.Drawing.Point(358, 703);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(102, 58);
            this.btnAnterior.TabIndex = 11;
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnPrimero
            // 
            this.btnPrimero.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPrimero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrimero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPrimero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimero.Image = global::Tutorial_Udemy_WindowsForms.Properties.Resources.add;
            this.btnPrimero.Location = new System.Drawing.Point(250, 703);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(102, 58);
            this.btnPrimero.TabIndex = 10;
            this.btnPrimero.UseVisualStyleBackColor = false;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(898, 566);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyUp);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(331, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 48);
            this.label4.TabIndex = 2;
            this.label4.Text = "Lista estudiantes";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtBuscar);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(12, 113);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1498, 100);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(170, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 50);
            this.label5.TabIndex = 9;
            this.label5.Text = "Estudiantes";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(886, 25);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(430, 50);
            this.txtBuscar.TabIndex = 8;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(731, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 50);
            this.label2.TabIndex = 0;
            this.label2.Text = "Buscar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1522, 1030);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de estudiantes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblPaginas;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimero;
    }
}

