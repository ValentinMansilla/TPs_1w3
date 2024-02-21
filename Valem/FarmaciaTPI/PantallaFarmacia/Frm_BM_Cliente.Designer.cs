namespace PantallaFarmacia
{
    partial class Frm_BM_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BM_Cliente));
            cboTipos = new ComboBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtDni = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSalir = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            label5 = new Label();
            txtID = new TextBox();
            SuspendLayout();
            // 
            // cboTipos
            // 
            cboTipos.BackColor = Color.LightYellow;
            cboTipos.ForeColor = Color.FromArgb(0, 0, 64);
            cboTipos.FormattingEnabled = true;
            cboTipos.Location = new Point(109, 118);
            cboTipos.Name = "cboTipos";
            cboTipos.Size = new Size(198, 23);
            cboTipos.TabIndex = 14;
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.LightYellow;
            txtApellido.ForeColor = Color.FromArgb(0, 0, 64);
            txtApellido.Location = new Point(109, 212);
            txtApellido.MaxLength = 20;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(198, 23);
            txtApellido.TabIndex = 13;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.LightYellow;
            txtNombre.ForeColor = Color.FromArgb(0, 0, 64);
            txtNombre.Location = new Point(109, 165);
            txtNombre.MaxLength = 20;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(198, 23);
            txtNombre.TabIndex = 12;
            // 
            // txtDni
            // 
            txtDni.BackColor = Color.LightYellow;
            txtDni.ForeColor = Color.FromArgb(0, 0, 64);
            txtDni.Location = new Point(109, 71);
            txtDni.MaxLength = 15;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(198, 23);
            txtDni.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.LightYellow;
            label4.Location = new Point(12, 215);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 18;
            label4.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.LightYellow;
            label3.Location = new Point(12, 168);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 17;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.LightYellow;
            label2.Location = new Point(12, 121);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 16;
            label2.Text = "Tipo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.LightYellow;
            label1.Location = new Point(12, 74);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 15;
            label1.Text = "DNI";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(0, 0, 64);
            btnSalir.ForeColor = Color.LightYellow;
            btnSalir.Location = new Point(234, 317);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 19;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(0, 0, 64);
            btnEliminar.ForeColor = Color.LightYellow;
            btnEliminar.Location = new Point(12, 317);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(0, 0, 64);
            btnModificar.ForeColor = Color.LightYellow;
            btnModificar.Location = new Point(123, 317);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 21;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.LightYellow;
            label5.Location = new Point(12, 27);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 23;
            label5.Text = "ID";
            // 
            // txtID
            // 
            txtID.BackColor = Color.LightYellow;
            txtID.Enabled = false;
            txtID.ForeColor = Color.FromArgb(0, 0, 64);
            txtID.Location = new Point(109, 24);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(198, 23);
            txtID.TabIndex = 22;
            // 
            // Frm_BM_Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(322, 352);
            Controls.Add(label5);
            Controls.Add(txtID);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnSalir);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboTipos);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtDni);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_BM_Cliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cliente";
            Load += Frm_Ver_Cliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboTipos;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtDni;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSalir;
        private Button btnEliminar;
        private Button btnModificar;
        private Label label5;
        private TextBox txtID;
    }
}