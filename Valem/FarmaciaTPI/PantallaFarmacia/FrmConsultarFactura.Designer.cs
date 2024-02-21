namespace PantallaFarmacia
{
    partial class FrmConsultarFactura
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarFactura));
            dgv_facturas = new DataGridView();
            Numero = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            Sucursal = new DataGridViewTextBoxColumn();
            Empleado = new DataGridViewTextBoxColumn();
            Detalles = new DataGridViewButtonColumn();
            btn_consultar = new Button();
            dtp_desde = new DateTimePicker();
            dtp_hasta = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_facturas).BeginInit();
            SuspendLayout();
            // 
            // dgv_facturas
            // 
            dgv_facturas.AllowUserToAddRows = false;
            dgv_facturas.AllowUserToDeleteRows = false;
            dgv_facturas.BackgroundColor = Color.FromArgb(0, 0, 64);
            dgv_facturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_facturas.Columns.AddRange(new DataGridViewColumn[] { Numero, Fecha, Cliente, Sucursal, Empleado, Detalles });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LightYellow;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(0, 0, 64);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.LightYellow;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgv_facturas.DefaultCellStyle = dataGridViewCellStyle1;
            dgv_facturas.GridColor = Color.LightYellow;
            dgv_facturas.Location = new Point(12, 115);
            dgv_facturas.Name = "dgv_facturas";
            dgv_facturas.ReadOnly = true;
            dgv_facturas.RowTemplate.Height = 25;
            dgv_facturas.Size = new Size(663, 292);
            dgv_facturas.TabIndex = 3;
            dgv_facturas.CellContentClick += dgv_facturas_CellContentClick;
            // 
            // Numero
            // 
            Numero.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Numero.HeaderText = "Numero";
            Numero.Name = "Numero";
            Numero.ReadOnly = true;
            // 
            // Fecha
            // 
            Fecha.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // Cliente
            // 
            Cliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Cliente.HeaderText = "Cliente";
            Cliente.Name = "Cliente";
            Cliente.ReadOnly = true;
            // 
            // Sucursal
            // 
            Sucursal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Sucursal.HeaderText = "Sucursal";
            Sucursal.Name = "Sucursal";
            Sucursal.ReadOnly = true;
            // 
            // Empleado
            // 
            Empleado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Empleado.HeaderText = "Vendedor";
            Empleado.Name = "Empleado";
            Empleado.ReadOnly = true;
            // 
            // Detalles
            // 
            Detalles.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Detalles.HeaderText = "Detalles";
            Detalles.Name = "Detalles";
            Detalles.ReadOnly = true;
            Detalles.Text = "Examinar";
            Detalles.ToolTipText = "Examinar";
            Detalles.UseColumnTextForButtonValue = true;
            // 
            // btn_consultar
            // 
            btn_consultar.BackColor = Color.LightYellow;
            btn_consultar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_consultar.ForeColor = Color.FromArgb(0, 0, 64);
            btn_consultar.Location = new Point(600, 54);
            btn_consultar.Name = "btn_consultar";
            btn_consultar.Size = new Size(75, 23);
            btn_consultar.TabIndex = 2;
            btn_consultar.Text = "Consultar";
            btn_consultar.UseVisualStyleBackColor = false;
            btn_consultar.Click += btn_consultar_Click;
            // 
            // dtp_desde
            // 
            dtp_desde.Location = new Point(12, 54);
            dtp_desde.Name = "dtp_desde";
            dtp_desde.Size = new Size(200, 23);
            dtp_desde.TabIndex = 0;
            dtp_desde.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // dtp_hasta
            // 
            dtp_hasta.Location = new Point(241, 54);
            dtp_hasta.Name = "dtp_hasta";
            dtp_hasta.Size = new Size(200, 23);
            dtp_hasta.TabIndex = 1;
            dtp_hasta.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 4;
            label1.Text = "Desde";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(241, 36);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 5;
            label2.Text = "Hasta";
            // 
            // FrmConsultarFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(687, 419);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtp_hasta);
            Controls.Add(dtp_desde);
            Controls.Add(btn_consultar);
            Controls.Add(dgv_facturas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmConsultarFactura";
            Text = "Consultar Factura";
            Load += FrmConsultarFactura_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_facturas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_facturas;
        private Button btn_consultar;
        private DateTimePicker dtp_desde;
        private DateTimePicker dtp_hasta;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn Numero;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Sucursal;
        private DataGridViewTextBoxColumn Empleado;
        private DataGridViewButtonColumn Detalles;
    }
}