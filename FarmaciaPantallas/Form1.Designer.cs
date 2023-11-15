namespace FarmaciaPantallas
{
    partial class Form1
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
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            soporteToolStripMenuItem = new ToolStripMenuItem();
            transacciónToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            cantidadDeDescuentosToolStripMenuItem = new ToolStripMenuItem();
            actualizarDescuentosToolStripMenuItem = new ToolStripMenuItem();
            clientesÚltimoAñoToolStripMenuItem = new ToolStripMenuItem();
            mejoresVendedoreToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(0, 0, 64);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, soporteToolStripMenuItem, transacciónToolStripMenuItem, reportesToolStripMenuItem, acercaDeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(348, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.ForeColor = Color.LightYellow;
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(96, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // soporteToolStripMenuItem
            // 
            soporteToolStripMenuItem.ForeColor = Color.LightYellow;
            soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
            soporteToolStripMenuItem.Size = new Size(60, 20);
            soporteToolStripMenuItem.Text = "Soporte";
            // 
            // transacciónToolStripMenuItem
            // 
            transacciónToolStripMenuItem.ForeColor = Color.LightYellow;
            transacciónToolStripMenuItem.Name = "transacciónToolStripMenuItem";
            transacciónToolStripMenuItem.Size = new Size(81, 20);
            transacciónToolStripMenuItem.Text = "Transacción";
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cantidadDeDescuentosToolStripMenuItem, actualizarDescuentosToolStripMenuItem, clientesÚltimoAñoToolStripMenuItem, mejoresVendedoreToolStripMenuItem });
            reportesToolStripMenuItem.ForeColor = Color.LightYellow;
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(65, 20);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // cantidadDeDescuentosToolStripMenuItem
            // 
            cantidadDeDescuentosToolStripMenuItem.BackColor = Color.FromArgb(0, 0, 64);
            cantidadDeDescuentosToolStripMenuItem.ForeColor = Color.LightYellow;
            cantidadDeDescuentosToolStripMenuItem.Image = Properties.Resources.icono_2;
            cantidadDeDescuentosToolStripMenuItem.Name = "cantidadDeDescuentosToolStripMenuItem";
            cantidadDeDescuentosToolStripMenuItem.Size = new Size(201, 22);
            cantidadDeDescuentosToolStripMenuItem.Text = "Cantidad de descuentos";
            cantidadDeDescuentosToolStripMenuItem.Click += cantidadDeDescuentosToolStripMenuItem_Click;
            // 
            // actualizarDescuentosToolStripMenuItem
            // 
            actualizarDescuentosToolStripMenuItem.BackColor = Color.FromArgb(0, 0, 64);
            actualizarDescuentosToolStripMenuItem.ForeColor = Color.LightYellow;
            actualizarDescuentosToolStripMenuItem.Image = Properties.Resources.icono_1;
            actualizarDescuentosToolStripMenuItem.Name = "actualizarDescuentosToolStripMenuItem";
            actualizarDescuentosToolStripMenuItem.Size = new Size(201, 22);
            actualizarDescuentosToolStripMenuItem.Text = "Actualizar descuentos";
            // 
            // clientesÚltimoAñoToolStripMenuItem
            // 
            clientesÚltimoAñoToolStripMenuItem.BackColor = Color.FromArgb(0, 0, 64);
            clientesÚltimoAñoToolStripMenuItem.ForeColor = Color.LightYellow;
            clientesÚltimoAñoToolStripMenuItem.Image = Properties.Resources.icono_3;
            clientesÚltimoAñoToolStripMenuItem.Name = "clientesÚltimoAñoToolStripMenuItem";
            clientesÚltimoAñoToolStripMenuItem.Size = new Size(201, 22);
            clientesÚltimoAñoToolStripMenuItem.Text = "Clientes último año";
            // 
            // mejoresVendedoreToolStripMenuItem
            // 
            mejoresVendedoreToolStripMenuItem.BackColor = Color.FromArgb(0, 0, 64);
            mejoresVendedoreToolStripMenuItem.ForeColor = Color.LightYellow;
            mejoresVendedoreToolStripMenuItem.Image = Properties.Resources.icono_4;
            mejoresVendedoreToolStripMenuItem.Name = "mejoresVendedoreToolStripMenuItem";
            mejoresVendedoreToolStripMenuItem.Size = new Size(201, 22);
            mejoresVendedoreToolStripMenuItem.Text = "Mejores vendedores";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.ForeColor = Color.LightYellow;
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(71, 20);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icono;
            pictureBox1.InitialImage = Properties.Resources.icono;
            pictureBox1.Location = new Point(92, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 181);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(348, 338);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Principal";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem soporteToolStripMenuItem;
        private ToolStripMenuItem transacciónToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem cantidadDeDescuentosToolStripMenuItem;
        private ToolStripMenuItem actualizarDescuentosToolStripMenuItem;
        private ToolStripMenuItem clientesÚltimoAñoToolStripMenuItem;
        private ToolStripMenuItem mejoresVendedoreToolStripMenuItem;
    }
}