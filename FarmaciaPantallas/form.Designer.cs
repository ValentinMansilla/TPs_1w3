namespace RayApp
{
    partial class form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label1 = new Label();
            cboTipo = new ComboBox();
            btnVolver = new Button();
            btnConsultar = new Button();
            dgvTipo = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTipo).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 23);
            label2.Name = "label2";
            label2.Size = new Size(181, 25);
            label2.TabIndex = 6;
            label2.Text = "Total Facturacion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 65);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 7;
            label1.Text = "Tipo de suministro";
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(129, 63);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(306, 23);
            cboTipo.TabIndex = 11;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(441, 337);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(117, 42);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(441, 52);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(117, 42);
            btnConsultar.TabIndex = 9;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // dgvTipo
            // 
            dgvTipo.AllowUserToAddRows = false;
            dgvTipo.AllowUserToDeleteRows = false;
            dgvTipo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTipo.Location = new Point(12, 106);
            dgvTipo.Name = "dgvTipo";
            dgvTipo.ReadOnly = true;
            dgvTipo.RowTemplate.Height = 25;
            dgvTipo.Size = new Size(544, 225);
            dgvTipo.TabIndex = 8;
            // 
            // form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 411);
            Controls.Add(cboTipo);
            Controls.Add(btnVolver);
            Controls.Add(btnConsultar);
            Controls.Add(dgvTipo);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "form";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTipo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private ComboBox cboTipo;
        private Button btnVolver;
        private Button btnConsultar;
        private DataGridView dgvTipo;
    }
}