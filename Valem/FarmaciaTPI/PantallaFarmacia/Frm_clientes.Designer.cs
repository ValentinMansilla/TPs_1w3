using FarmaciaPantallas.Properties;

namespace FarmaciaPantallas
{
    partial class Frm_clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_clientes));
            dgvCliente = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            DNI = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Ver = new DataGridViewButtonColumn();
            btnBuscar = new Button();
            btnNuevo = new Button();
            txtDNI = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cboTipo = new ComboBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label5 = new Label();
            txtApellido = new TextBox();
            btbBorrar = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            SuspendLayout();
            // 
            // dgvCliente
            // 
            dgvCliente.AllowUserToAddRows = false;
            dgvCliente.AllowUserToDeleteRows = false;
            dgvCliente.BackgroundColor = Color.FromArgb(0, 0, 64);
            dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCliente.Columns.AddRange(new DataGridViewColumn[] { ID, colTipo, DNI, Nombre, Apellido, Ver });
            dgvCliente.GridColor = Color.LightYellow;
            dgvCliente.Location = new Point(11, 104);
            dgvCliente.Name = "dgvCliente";
            dgvCliente.ReadOnly = true;
            dgvCliente.RowHeadersWidth = 62;
            dgvCliente.RowTemplate.Height = 25;
            dgvCliente.Size = new Size(739, 297);
            dgvCliente.TabIndex = 8;
            dgvCliente.CellContentClick += dgvCliente_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "Id";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            ID.Width = 150;
            // 
            // colTipo
            // 
            colTipo.HeaderText = "Tipo";
            colTipo.MinimumWidth = 8;
            colTipo.Name = "colTipo";
            colTipo.ReadOnly = true;
            colTipo.Width = 75;
            // 
            // DNI
            // 
            DNI.HeaderText = "Numero";
            DNI.MinimumWidth = 8;
            DNI.Name = "DNI";
            DNI.ReadOnly = true;
            DNI.Width = 150;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 150;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 8;
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            Apellido.Width = 150;
            // 
            // Ver
            // 
            Ver.HeaderText = "Acciones";
            Ver.MinimumWidth = 8;
            Ver.Name = "Ver";
            Ver.ReadOnly = true;
            Ver.Resizable = DataGridViewTriState.True;
            Ver.SortMode = DataGridViewColumnSortMode.Automatic;
            Ver.Text = "<-----";
            Ver.UseColumnTextForButtonValue = true;
            Ver.Width = 150;
            // 
            // btnBuscar
            // 
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.FromArgb(0, 0, 64);
            btnBuscar.Location = new Point(12, 415);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.LightYellow;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.ForeColor = Color.FromArgb(0, 0, 64);
            btnNuevo.Location = new Point(453, 415);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 7;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(78, 69);
            txtDNI.MaxLength = 20;
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(170, 23);
            txtDNI.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(12, 73);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 4;
            label1.Text = "NUMERO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(90, 19);
            label2.TabIndex = 5;
            label2.Text = "CLIENTES";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(0, 0, 64);
            label3.Location = new Point(12, 38);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 7;
            label3.Text = "TIPO";
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(78, 35);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(170, 23);
            cboTipo.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(0, 0, 64);
            label4.Location = new Point(416, 39);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 10;
            label4.Text = "NOMBRE";
            label4.Click += label4_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(485, 35);
            txtNombre.MaxLength = 20;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(170, 23);
            txtNombre.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(0, 0, 64);
            label5.Location = new Point(416, 73);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 12;
            label5.Text = "APELLIDO";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(485, 69);
            txtApellido.MaxLength = 20;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(170, 23);
            txtApellido.TabIndex = 3;
            // 
            // btbBorrar
            // 
            btbBorrar.FlatStyle = FlatStyle.Flat;
            btbBorrar.ForeColor = Color.FromArgb(0, 0, 64);
            btbBorrar.Location = new Point(232, 415);
            btbBorrar.Name = "btbBorrar";
            btbBorrar.Size = new Size(76, 23);
            btbBorrar.TabIndex = 5;
            btbBorrar.Text = "Limpiar";
            btbBorrar.UseVisualStyleBackColor = true;
            btbBorrar.Click += button1_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.LightYellow;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = Color.FromArgb(0, 0, 64);
            btnSalir.Location = new Point(673, 415);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(76, 23);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // Frm_clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(762, 450);
            Controls.Add(btnSalir);
            Controls.Add(btbBorrar);
            Controls.Add(label5);
            Controls.Add(txtApellido);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(cboTipo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDNI);
            Controls.Add(btnNuevo);
            Controls.Add(btnBuscar);
            Controls.Add(dgvCliente);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Frm_clientes";
            Text = "Consulta de Clientes";
            Load += Frm_clientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCliente;
        private Button btnBuscar;
        private Button btnNuevo;
        private TextBox txtDNI;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cboTipo;
        private Label label4;
        private TextBox txtNombre;
        private Label label5;
        private TextBox txtApellido;
        private Button btbBorrar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn colTipo;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewButtonColumn Ver;
        private Button btnSalir;
    }
}