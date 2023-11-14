namespace FarmaciaPantallas
{
    partial class Frm_Nuevo_Descuento
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
            lblObra = new Label();
            lblLocalidad = new Label();
            lblSuministro = new Label();
            lblNDescuento = new Label();
            txtNPrecio = new TextBox();
            lblNPrecio = new Label();
            cboObra = new ComboBox();
            cboSuministro = new ComboBox();
            cboLocalidad = new ComboBox();
            btnAceptar = new Button();
            btnVolver = new Button();
            txtNDescuento = new TextBox();
            SuspendLayout();
            // 
            // lblObra
            // 
            lblObra.AutoSize = true;
            lblObra.Location = new Point(42, 39);
            lblObra.Name = "lblObra";
            lblObra.Size = new Size(33, 15);
            lblObra.TabIndex = 0;
            lblObra.Text = "Obra";
            lblObra.Click += label1_Click;
            // 
            // lblLocalidad
            // 
            lblLocalidad.AutoSize = true;
            lblLocalidad.Location = new Point(42, 81);
            lblLocalidad.Name = "lblLocalidad";
            lblLocalidad.Size = new Size(58, 15);
            lblLocalidad.TabIndex = 2;
            lblLocalidad.Text = "Localidad";
            // 
            // lblSuministro
            // 
            lblSuministro.AutoSize = true;
            lblSuministro.Location = new Point(42, 123);
            lblSuministro.Name = "lblSuministro";
            lblSuministro.Size = new Size(64, 15);
            lblSuministro.TabIndex = 4;
            lblSuministro.Text = "Suministro";
            // 
            // lblNDescuento
            // 
            lblNDescuento.AutoSize = true;
            lblNDescuento.Location = new Point(42, 165);
            lblNDescuento.Name = "lblNDescuento";
            lblNDescuento.Size = new Size(100, 15);
            lblNDescuento.TabIndex = 6;
            lblNDescuento.Text = "Nuevo descuento";
            // 
            // txtNPrecio
            // 
            txtNPrecio.Enabled = false;
            txtNPrecio.Location = new Point(374, 376);
            txtNPrecio.Name = "txtNPrecio";
            txtNPrecio.Size = new Size(100, 23);
            txtNPrecio.TabIndex = 9;
            txtNPrecio.TextChanged += txtNPrecio_TextChanged;
            // 
            // lblNPrecio
            // 
            lblNPrecio.AutoSize = true;
            lblNPrecio.Location = new Point(272, 379);
            lblNPrecio.Name = "lblNPrecio";
            lblNPrecio.Size = new Size(78, 15);
            lblNPrecio.TabIndex = 8;
            lblNPrecio.Text = "Precio Nuevo";
            // 
            // cboObra
            // 
            cboObra.FormattingEnabled = true;
            cboObra.Location = new Point(186, 39);
            cboObra.Name = "cboObra";
            cboObra.Size = new Size(121, 23);
            cboObra.TabIndex = 10;
            cboObra.SelectedIndexChanged += cboObra_SelectedIndexChanged;
            // 
            // cboSuministro
            // 
            cboSuministro.FormattingEnabled = true;
            cboSuministro.Location = new Point(186, 123);
            cboSuministro.Name = "cboSuministro";
            cboSuministro.Size = new Size(121, 23);
            cboSuministro.TabIndex = 11;
            // 
            // cboLocalidad
            // 
            cboLocalidad.FormattingEnabled = true;
            cboLocalidad.Location = new Point(186, 81);
            cboLocalidad.Name = "cboLocalidad";
            cboLocalidad.Size = new Size(121, 23);
            cboLocalidad.TabIndex = 13;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(31, 376);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 14;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(128, 376);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 15;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // txtNDescuento
            // 
            txtNDescuento.Location = new Point(186, 162);
            txtNDescuento.Name = "txtNDescuento";
            txtNDescuento.Size = new Size(121, 23);
            txtNDescuento.TabIndex = 16;
            // 
            // Frm_Nuevo_Descuento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 450);
            Controls.Add(txtNDescuento);
            Controls.Add(btnVolver);
            Controls.Add(btnAceptar);
            Controls.Add(cboLocalidad);
            Controls.Add(cboSuministro);
            Controls.Add(cboObra);
            Controls.Add(txtNPrecio);
            Controls.Add(lblNPrecio);
            Controls.Add(lblNDescuento);
            Controls.Add(lblSuministro);
            Controls.Add(lblLocalidad);
            Controls.Add(lblObra);
            Name = "Frm_Nuevo_Descuento";
            Text = "Nuevo Descuento";
            Load += Frm_Nuevo_Descuento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblObra;
        private Label lblLocalidad;
        private Label lblSuministro;
        private Label lblNDescuento;
        private TextBox txtNPrecio;
        private Label lblNPrecio;
        private ComboBox cboObra;
        private ComboBox cboSuministro;
        private ComboBox cboLocalidad;
        private Button btnAceptar;
        private Button btnVolver;
        private TextBox txtNDescuento;
    }
}