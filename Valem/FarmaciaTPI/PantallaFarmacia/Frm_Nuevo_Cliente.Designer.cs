namespace FarmaciaPantallas
{
    partial class Frm_Nuevo_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Nuevo_Cliente));
            label1 = new Label();
            txtDni = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtApellido = new TextBox();
            label4 = new Label();
            btnSalir = new Button();
            btnCrear = new Button();
            cboTipos = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.LightYellow;
            label1.Location = new Point(16, 33);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 0;
            label1.Text = "DNI";
            // 
            // txtDni
            // 
            txtDni.BackColor = Color.LightYellow;
            txtDni.ForeColor = Color.FromArgb(0, 0, 64);
            txtDni.Location = new Point(111, 33);
            txtDni.MaxLength = 20;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(198, 23);
            txtDni.TabIndex = 0;
            txtDni.TextChanged += txtDni_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.LightYellow;
            label2.Location = new Point(16, 80);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 2;
            label2.Text = "Tipo";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.LightYellow;
            txtNombre.ForeColor = Color.FromArgb(0, 0, 64);
            txtNombre.Location = new Point(111, 131);
            txtNombre.MaxLength = 20;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(198, 23);
            txtNombre.TabIndex = 2;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.LightYellow;
            label3.Location = new Point(16, 131);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Nombre";
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.LightYellow;
            txtApellido.ForeColor = Color.FromArgb(0, 0, 64);
            txtApellido.Location = new Point(111, 182);
            txtApellido.MaxLength = 20;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(198, 23);
            txtApellido.TabIndex = 3;
            txtApellido.TextChanged += textBox4_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.LightYellow;
            label4.Location = new Point(16, 182);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 6;
            label4.Text = "Apellido";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(0, 0, 64);
            btnSalir.ForeColor = Color.LightYellow;
            btnSalir.Location = new Point(29, 264);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.FromArgb(0, 0, 64);
            btnCrear.ForeColor = Color.LightYellow;
            btnCrear.Location = new Point(217, 264);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(75, 23);
            btnCrear.TabIndex = 4;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // cboTipos
            // 
            cboTipos.BackColor = Color.LightYellow;
            cboTipos.ForeColor = Color.FromArgb(0, 0, 64);
            cboTipos.FormattingEnabled = true;
            cboTipos.Location = new Point(111, 80);
            cboTipos.Name = "cboTipos";
            cboTipos.Size = new Size(198, 23);
            cboTipos.TabIndex = 1;
            // 
            // Frm_Nuevo_Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(321, 302);
            Controls.Add(cboTipos);
            Controls.Add(btnCrear);
            Controls.Add(btnSalir);
            Controls.Add(txtApellido);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtDni);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_Nuevo_Cliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Cliente";
            Load += Frm_Nuevo_Cliente_LoadAsync;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDni;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtApellido;
        private Label label4;
        private Button btnSalir;
        private Button btnCrear;
        private ComboBox cboTipos;
    }
}