namespace FarmaciaPantallas
{
    partial class frmClientes
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
            dgvClienteVista = new DataGridView();
            colNro = new DataGridViewTextBoxColumn();
            colCliente = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colDetalle = new DataGridViewButtonColumn();
            txtMes2 = new TextBox();
            txtMes1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnConsultar = new Button();
            btnVolver = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClienteVista).BeginInit();
            SuspendLayout();
            // 
            // dgvClienteVista
            // 
            dgvClienteVista.AllowUserToAddRows = false;
            dgvClienteVista.AllowUserToDeleteRows = false;
            dgvClienteVista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClienteVista.Columns.AddRange(new DataGridViewColumn[] { colNro, colCliente, colFecha, colDetalle });
            dgvClienteVista.Location = new Point(12, 105);
            dgvClienteVista.Name = "dgvClienteVista";
            dgvClienteVista.ReadOnly = true;
            dgvClienteVista.RowTemplate.Height = 25;
            dgvClienteVista.Size = new Size(730, 261);
            dgvClienteVista.TabIndex = 0;
            dgvClienteVista.CellContentClick += dgvClienteVista_CellContentClick;
            // 
            // colNro
            // 
            colNro.HeaderText = "";
            colNro.Name = "colNro";
            colNro.ReadOnly = true;
            colNro.Visible = false;
            // 
            // colCliente
            // 
            colCliente.HeaderText = "Cliente";
            colCliente.Name = "colCliente";
            colCliente.ReadOnly = true;
            colCliente.Width = 460;
            // 
            // colFecha
            // 
            colFecha.HeaderText = "Fecha";
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            colFecha.Width = 125;
            // 
            // colDetalle
            // 
            colDetalle.HeaderText = "Observaciones";
            colDetalle.Name = "colDetalle";
            colDetalle.ReadOnly = true;
            colDetalle.Text = "Detalles";
            // 
            // txtMes2
            // 
            txtMes2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtMes2.Location = new Point(73, 73);
            txtMes2.MaxLength = 12;
            txtMes2.Name = "txtMes2";
            txtMes2.Size = new Size(100, 23);
            txtMes2.TabIndex = 1;
            txtMes2.Text = "8";
            // 
            // txtMes1
            // 
            txtMes1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtMes1.Location = new Point(73, 42);
            txtMes1.MaxLength = 12;
            txtMes1.Name = "txtMes1";
            txtMes1.Size = new Size(100, 23);
            txtMes1.TabIndex = 1;
            txtMes1.Text = "3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 45);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 2;
            label1.Text = "Mes 1:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 76);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 2;
            label2.Text = "Mes 2:";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(194, 73);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 3;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(667, 379);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(234, 15);
            label3.TabIndex = 4;
            label3.Text = "Consulta clientes en 2 meses determinados";
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 414);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(btnVolver);
            Controls.Add(btnConsultar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMes1);
            Controls.Add(txtMes2);
            Controls.Add(dgvClienteVista);
            Name = "frmClientes";
            Text = "Vista de Clientes";
            Load += ClientesVista_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClienteVista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClienteVista;
        private TextBox txtMes2;
        private TextBox txtMes1;
        private Label label1;
        private Label label2;
        private Button btnConsultar;
        private Button btnVolver;
        private Label label3;
        private DataGridViewTextBoxColumn colNro;
        private DataGridViewTextBoxColumn colCliente;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewButtonColumn colDetalle;
    }
}