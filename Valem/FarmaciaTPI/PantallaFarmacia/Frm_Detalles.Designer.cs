namespace PantallaFarmacia
{
    partial class Frm_Detalles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Detalles));
            dgv_detalles = new DataGridView();
            descripcion = new DataGridViewTextBoxColumn();
            codigo_barra = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            txtTotal = new TextBox();
            label1 = new Label();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_detalles).BeginInit();
            SuspendLayout();
            // 
            // dgv_detalles
            // 
            dgv_detalles.AllowUserToAddRows = false;
            dgv_detalles.AllowUserToDeleteRows = false;
            dgv_detalles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_detalles.BackgroundColor = Color.LightYellow;
            dgv_detalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_detalles.Columns.AddRange(new DataGridViewColumn[] { descripcion, codigo_barra, cantidad, precio });
            dgv_detalles.GridColor = Color.FromArgb(0, 0, 64);
            dgv_detalles.Location = new Point(12, 12);
            dgv_detalles.Name = "dgv_detalles";
            dgv_detalles.ReadOnly = true;
            dgv_detalles.RowTemplate.Height = 25;
            dgv_detalles.Size = new Size(760, 495);
            dgv_detalles.TabIndex = 2;
            // 
            // descripcion
            // 
            descripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            descripcion.HeaderText = "Suministro";
            descripcion.Name = "descripcion";
            descripcion.ReadOnly = true;
            // 
            // codigo_barra
            // 
            codigo_barra.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            codigo_barra.HeaderText = "Codigo";
            codigo_barra.Name = "codigo_barra";
            codigo_barra.ReadOnly = true;
            // 
            // cantidad
            // 
            cantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cantidad.HeaderText = "Cantidad";
            cantidad.Name = "cantidad";
            cantidad.ReadOnly = true;
            // 
            // precio
            // 
            precio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            precio.HeaderText = "Precio";
            precio.Name = "precio";
            precio.ReadOnly = true;
            // 
            // txtTotal
            // 
            txtTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtTotal.BackColor = Color.LightYellow;
            txtTotal.Enabled = false;
            txtTotal.ForeColor = Color.FromArgb(0, 0, 64);
            txtTotal.Location = new Point(672, 526);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = Color.LightYellow;
            label1.Location = new Point(628, 534);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "Total: ";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.LightYellow;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = Color.FromArgb(0, 0, 64);
            btnSalir.Location = new Point(12, 526);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(76, 23);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // Frm_Detalles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(784, 561);
            Controls.Add(btnSalir);
            Controls.Add(label1);
            Controls.Add(txtTotal);
            Controls.Add(dgv_detalles);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_Detalles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Factura: ";
            Load += Frm_Detalles_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_detalles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_detalles;
        private TextBox txtTotal;
        private Label label1;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn codigo_barra;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn precio;
        private Button btnSalir;
    }
}