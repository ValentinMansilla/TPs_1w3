namespace PantallaFarmacia
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            txt_usuario = new TextBox();
            txt_xontraseña = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btn_Entrar = new Button();
            SuspendLayout();
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(78, 68);
            txt_usuario.Margin = new Padding(2);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(106, 23);
            txt_usuario.TabIndex = 0;
            // 
            // txt_xontraseña
            // 
            txt_xontraseña.Location = new Point(78, 123);
            txt_xontraseña.Margin = new Padding(2);
            txt_xontraseña.Name = "txt_xontraseña";
            txt_xontraseña.PasswordChar = '*';
            txt_xontraseña.Size = new Size(106, 23);
            txt_xontraseña.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightYellow;
            label1.Location = new Point(100, 46);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.LightYellow;
            label2.Location = new Point(91, 96);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // btn_Entrar
            // 
            btn_Entrar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Entrar.ForeColor = Color.FromArgb(0, 0, 64);
            btn_Entrar.Location = new Point(78, 179);
            btn_Entrar.Margin = new Padding(2);
            btn_Entrar.Name = "btn_Entrar";
            btn_Entrar.Size = new Size(105, 20);
            btn_Entrar.TabIndex = 2;
            btn_Entrar.Text = "Entrar";
            btn_Entrar.UseVisualStyleBackColor = true;
            btn_Entrar.Click += btn_Entrar_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(267, 266);
            Controls.Add(btn_Entrar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_xontraseña);
            Controls.Add(txt_usuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log In";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_usuario;
        private TextBox txt_xontraseña;
        private Label label1;
        private Label label2;
        private Button btn_Entrar;
    }
}