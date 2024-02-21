namespace PantallaFarmacia
{
    partial class FrmFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFactura));
            nudCantidad = new NumericUpDown();
            btn_cancelar = new Button();
            btn_aceptar = new Button();
            txtTotal = new TextBox();
            label7 = new Label();
            cbo_suministros = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            cbo_sucursal = new ComboBox();
            cbo_vendedor = new ComboBox();
            label4 = new Label();
            cbo_cliente = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            dtp_fecha = new DateTimePicker();
            label2 = new Label();
            lbl_facturanumero = new Label();
            dgvDetalles = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colDesc = new DataGridViewTextBoxColumn();
            col_codigo = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colCantiddad = new DataGridViewTextBoxColumn();
            colSubtotal = new DataGridViewTextBoxColumn();
            colQuitar = new DataGridViewButtonColumn();
            btn_agregar = new Button();
            gpFactura = new GroupBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
            gpFactura.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(407, 24);
            nudCantidad.Margin = new Padding(2);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(114, 23);
            nudCantidad.TabIndex = 1;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_cancelar.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 64);
            btn_cancelar.FlatStyle = FlatStyle.Popup;
            btn_cancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cancelar.ForeColor = Color.FromArgb(0, 0, 64);
            btn_cancelar.Location = new Point(597, 491);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 3;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_aceptar
            // 
            btn_aceptar.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 64);
            btn_aceptar.FlatStyle = FlatStyle.Popup;
            btn_aceptar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_aceptar.ForeColor = Color.FromArgb(0, 0, 64);
            btn_aceptar.Location = new Point(12, 491);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.Size = new Size(75, 23);
            btn_aceptar.TabIndex = 2;
            btn_aceptar.Text = "Aceptar";
            btn_aceptar.UseVisualStyleBackColor = true;
            btn_aceptar.Click += btn_aceptar_Click;
            // 
            // txtTotal
            // 
            txtTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTotal.Location = new Point(507, 265);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 4;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 0, 64);
            label7.Location = new Point(467, 268);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 34;
            label7.Text = "Total";
            // 
            // cbo_suministros
            // 
            cbo_suministros.FormattingEnabled = true;
            cbo_suministros.Location = new Point(92, 23);
            cbo_suministros.Name = "cbo_suministros";
            cbo_suministros.Size = new Size(207, 23);
            cbo_suministros.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 0, 64);
            label6.Location = new Point(14, 31);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 1;
            label6.Text = "Suministros";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 0, 64);
            label5.Location = new Point(14, 58);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 31;
            label5.Text = "Sucursal";
            // 
            // cbo_sucursal
            // 
            cbo_sucursal.FormattingEnabled = true;
            cbo_sucursal.Location = new Point(82, 50);
            cbo_sucursal.Name = "cbo_sucursal";
            cbo_sucursal.Size = new Size(217, 23);
            cbo_sucursal.TabIndex = 1;
            // 
            // cbo_vendedor
            // 
            cbo_vendedor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbo_vendedor.FormattingEnabled = true;
            cbo_vendedor.Location = new Point(411, 50);
            cbo_vendedor.Name = "cbo_vendedor";
            cbo_vendedor.Size = new Size(227, 23);
            cbo_vendedor.TabIndex = 3;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 0, 64);
            label4.Location = new Point(337, 58);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 28;
            label4.Text = "Vendedor";
            // 
            // cbo_cliente
            // 
            cbo_cliente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbo_cliente.FormattingEnabled = true;
            cbo_cliente.Location = new Point(411, 20);
            cbo_cliente.Name = "cbo_cliente";
            cbo_cliente.Size = new Size(227, 23);
            cbo_cliente.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(333, 31);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 26;
            label1.Text = "Cantidad";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 0, 64);
            label3.Location = new Point(337, 28);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 25;
            label3.Text = "Cliente";
            // 
            // dtp_fecha
            // 
            dtp_fecha.Cursor = Cursors.No;
            dtp_fecha.CustomFormat = "";
            dtp_fecha.Enabled = false;
            dtp_fecha.Location = new Point(82, 20);
            dtp_fecha.Name = "dtp_fecha";
            dtp_fecha.Size = new Size(217, 23);
            dtp_fecha.TabIndex = 0;
            dtp_fecha.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(14, 28);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 23;
            label2.Text = "Fecha";
            // 
            // lbl_facturanumero
            // 
            lbl_facturanumero.AutoSize = true;
            lbl_facturanumero.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_facturanumero.ForeColor = Color.FromArgb(0, 0, 64);
            lbl_facturanumero.Location = new Point(12, 9);
            lbl_facturanumero.Name = "lbl_facturanumero";
            lbl_facturanumero.Size = new Size(89, 21);
            lbl_facturanumero.TabIndex = 22;
            lbl_facturanumero.Text = "Factura N°";
            // 
            // dgvDetalles
            // 
            dgvDetalles.AllowUserToAddRows = false;
            dgvDetalles.AllowUserToDeleteRows = false;
            dgvDetalles.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvDetalles.BackgroundColor = Color.FromArgb(0, 0, 64);
            dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalles.Columns.AddRange(new DataGridViewColumn[] { colId, colDesc, col_codigo, colPrecio, colCantiddad, colSubtotal, colQuitar });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LightYellow;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.LightYellow;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvDetalles.DefaultCellStyle = dataGridViewCellStyle1;
            dgvDetalles.Location = new Point(14, 96);
            dgvDetalles.Name = "dgvDetalles";
            dgvDetalles.ReadOnly = true;
            dgvDetalles.RowHeadersWidth = 62;
            dgvDetalles.RowTemplate.Height = 25;
            dgvDetalles.Size = new Size(624, 150);
            dgvDetalles.TabIndex = 3;
            dgvDetalles.CellContentClick += dgvDetalles_CellContentClick;
            // 
            // colId
            // 
            colId.Frozen = true;
            colId.HeaderText = "Id";
            colId.MinimumWidth = 8;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 42;
            // 
            // colDesc
            // 
            colDesc.Frozen = true;
            colDesc.HeaderText = "Descripción";
            colDesc.MinimumWidth = 8;
            colDesc.Name = "colDesc";
            colDesc.ReadOnly = true;
            colDesc.Width = 94;
            // 
            // col_codigo
            // 
            col_codigo.HeaderText = "Codigo de barra";
            col_codigo.MinimumWidth = 8;
            col_codigo.Name = "col_codigo";
            col_codigo.ReadOnly = true;
            col_codigo.Width = 83;
            // 
            // colPrecio
            // 
            colPrecio.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colPrecio.HeaderText = "Precio";
            colPrecio.MinimumWidth = 8;
            colPrecio.Name = "colPrecio";
            colPrecio.ReadOnly = true;
            colPrecio.Width = 65;
            // 
            // colCantiddad
            // 
            colCantiddad.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colCantiddad.HeaderText = "Cantidad";
            colCantiddad.MinimumWidth = 8;
            colCantiddad.Name = "colCantiddad";
            colCantiddad.ReadOnly = true;
            colCantiddad.Width = 80;
            // 
            // colSubtotal
            // 
            colSubtotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colSubtotal.HeaderText = "Subtotal";
            colSubtotal.MinimumWidth = 8;
            colSubtotal.Name = "colSubtotal";
            colSubtotal.ReadOnly = true;
            colSubtotal.Width = 76;
            // 
            // colQuitar
            // 
            colQuitar.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colQuitar.HeaderText = "Quitar";
            colQuitar.Name = "colQuitar";
            colQuitar.ReadOnly = true;
            colQuitar.Text = "X";
            colQuitar.UseColumnTextForButtonValue = true;
            // 
            // btn_agregar
            // 
            btn_agregar.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 64);
            btn_agregar.FlatStyle = FlatStyle.Popup;
            btn_agregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_agregar.ForeColor = Color.FromArgb(0, 0, 64);
            btn_agregar.Location = new Point(14, 57);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(75, 23);
            btn_agregar.TabIndex = 2;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // gpFactura
            // 
            gpFactura.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gpFactura.Controls.Add(dtp_fecha);
            gpFactura.Controls.Add(label2);
            gpFactura.Controls.Add(label3);
            gpFactura.Controls.Add(cbo_cliente);
            gpFactura.Controls.Add(label4);
            gpFactura.Controls.Add(cbo_vendedor);
            gpFactura.Controls.Add(label5);
            gpFactura.Controls.Add(cbo_sucursal);
            gpFactura.Location = new Point(12, 33);
            gpFactura.Name = "gpFactura";
            gpFactura.Size = new Size(660, 102);
            gpFactura.TabIndex = 0;
            gpFactura.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(dgvDetalles);
            groupBox1.Controls.Add(cbo_suministros);
            groupBox1.Controls.Add(nudCantidad);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btn_agregar);
            groupBox1.Location = new Point(12, 150);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(660, 319);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // FrmFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(703, 567);
            Controls.Add(groupBox1);
            Controls.Add(gpFactura);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_aceptar);
            Controls.Add(lbl_facturanumero);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmFactura";
            Text = "Factura";
            Load += FrmFactura_Load;
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
            gpFactura.ResumeLayout(false);
            gpFactura.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudCantidad;
        private Button btn_cancelar;
        private Button btn_aceptar;
        private TextBox txtTotal;
        private Label label7;
        private ComboBox cbo_suministros;
        private Label label6;
        private Label label5;
        private ComboBox cbo_sucursal;
        private ComboBox cbo_vendedor;
        private Label label4;
        private ComboBox cbo_cliente;
        private Label label1;
        private Label label3;
        private DateTimePicker dtp_fecha;
        private Label label2;
        private Label lbl_facturanumero;
        private DataGridView dgvDetalles;
        private Button btn_agregar;
        private GroupBox gpFactura;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colDesc;
        private DataGridViewTextBoxColumn col_codigo;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colCantiddad;
        private DataGridViewTextBoxColumn colSubtotal;
        private DataGridViewButtonColumn colQuitar;
    }
}