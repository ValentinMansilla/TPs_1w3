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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            soporteToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            transacciónToolStripMenuItem = new ToolStripMenuItem();
            facturaToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem1 = new ToolStripMenuItem();
            reporteDeFacturasToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            cantidadDeDescuentosToolStripMenuItem = new ToolStripMenuItem();
            actualizarDescuentosToolStripMenuItem = new ToolStripMenuItem();
            clientesÚltimoAñoToolStripMenuItem = new ToolStripMenuItem();
            mejoresVendedoreToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            nosotrosToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(0, 0, 64);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, soporteToolStripMenuItem, transacciónToolStripMenuItem, reportesToolStripMenuItem1, reportesToolStripMenuItem, acercaDeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(530, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
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
            salirToolStripMenuItem.BackColor = Color.FromArgb(0, 0, 64);
            salirToolStripMenuItem.ForeColor = Color.LightYellow;
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(96, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // soporteToolStripMenuItem
            // 
            soporteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem });
            soporteToolStripMenuItem.ForeColor = Color.LightYellow;
            soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
            soporteToolStripMenuItem.Size = new Size(60, 20);
            soporteToolStripMenuItem.Text = "Soporte";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.BackColor = Color.FromArgb(0, 0, 64);
            clientesToolStripMenuItem.ForeColor = Color.LightYellow;
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(116, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // transacciónToolStripMenuItem
            // 
            transacciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { facturaToolStripMenuItem });
            transacciónToolStripMenuItem.ForeColor = Color.LightYellow;
            transacciónToolStripMenuItem.Name = "transacciónToolStripMenuItem";
            transacciónToolStripMenuItem.Size = new Size(81, 20);
            transacciónToolStripMenuItem.Text = "Transacción";
            // 
            // facturaToolStripMenuItem
            // 
            facturaToolStripMenuItem.BackColor = Color.FromArgb(0, 0, 64);
            facturaToolStripMenuItem.ForeColor = Color.LightYellow;
            facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            facturaToolStripMenuItem.Size = new Size(113, 22);
            facturaToolStripMenuItem.Text = "Factura";
            facturaToolStripMenuItem.Click += facturaToolStripMenuItem_Click;
            // 
            // reportesToolStripMenuItem1
            // 
            reportesToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { reporteDeFacturasToolStripMenuItem });
            reportesToolStripMenuItem1.ForeColor = Color.LightYellow;
            reportesToolStripMenuItem1.Name = "reportesToolStripMenuItem1";
            reportesToolStripMenuItem1.Size = new Size(65, 20);
            reportesToolStripMenuItem1.Text = "Reportes";
            // 
            // reporteDeFacturasToolStripMenuItem
            // 
            reporteDeFacturasToolStripMenuItem.BackColor = Color.FromArgb(0, 0, 64);
            reporteDeFacturasToolStripMenuItem.ForeColor = Color.LightYellow;
            reporteDeFacturasToolStripMenuItem.Name = "reporteDeFacturasToolStripMenuItem";
            reporteDeFacturasToolStripMenuItem.Size = new Size(178, 22);
            reporteDeFacturasToolStripMenuItem.Text = "Reporte de Facturas";
            reporteDeFacturasToolStripMenuItem.Click += reporteDeFacturasToolStripMenuItem_Click;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cantidadDeDescuentosToolStripMenuItem, actualizarDescuentosToolStripMenuItem, clientesÚltimoAñoToolStripMenuItem, mejoresVendedoreToolStripMenuItem });
            reportesToolStripMenuItem.ForeColor = Color.LightYellow;
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(80, 20);
            reportesToolStripMenuItem.Text = "Laboratorio";
            // 
            // cantidadDeDescuentosToolStripMenuItem
            // 
            cantidadDeDescuentosToolStripMenuItem.BackColor = Color.FromArgb(0, 0, 64);
            cantidadDeDescuentosToolStripMenuItem.ForeColor = Color.LightYellow;
            cantidadDeDescuentosToolStripMenuItem.Name = "cantidadDeDescuentosToolStripMenuItem";
            cantidadDeDescuentosToolStripMenuItem.Size = new Size(201, 22);
            cantidadDeDescuentosToolStripMenuItem.Text = "Cantidad de descuentos";
            // 
            // actualizarDescuentosToolStripMenuItem
            // 
            actualizarDescuentosToolStripMenuItem.BackColor = Color.FromArgb(0, 0, 64);
            actualizarDescuentosToolStripMenuItem.ForeColor = Color.LightYellow;
            actualizarDescuentosToolStripMenuItem.Name = "actualizarDescuentosToolStripMenuItem";
            actualizarDescuentosToolStripMenuItem.Size = new Size(201, 22);
            actualizarDescuentosToolStripMenuItem.Text = "Nuevo descuento";
            // 
            // clientesÚltimoAñoToolStripMenuItem
            // 
            clientesÚltimoAñoToolStripMenuItem.BackColor = Color.FromArgb(0, 0, 64);
            clientesÚltimoAñoToolStripMenuItem.ForeColor = Color.LightYellow;
            clientesÚltimoAñoToolStripMenuItem.Name = "clientesÚltimoAñoToolStripMenuItem";
            clientesÚltimoAñoToolStripMenuItem.Size = new Size(201, 22);
            clientesÚltimoAñoToolStripMenuItem.Text = "Clientes último año";
            clientesÚltimoAñoToolStripMenuItem.Click += clientesÚltimoAñoToolStripMenuItem_Click;
            // 
            // mejoresVendedoreToolStripMenuItem
            // 
            mejoresVendedoreToolStripMenuItem.BackColor = Color.FromArgb(0, 0, 64);
            mejoresVendedoreToolStripMenuItem.ForeColor = Color.LightYellow;
            mejoresVendedoreToolStripMenuItem.Name = "mejoresVendedoreToolStripMenuItem";
            mejoresVendedoreToolStripMenuItem.Size = new Size(201, 22);
            mejoresVendedoreToolStripMenuItem.Text = "Total facturación";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nosotrosToolStripMenuItem });
            acercaDeToolStripMenuItem.ForeColor = Color.LightYellow;
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(71, 20);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // nosotrosToolStripMenuItem
            // 
            nosotrosToolStripMenuItem.BackColor = Color.FromArgb(0, 0, 64);
            nosotrosToolStripMenuItem.ForeColor = Color.LightYellow;
            nosotrosToolStripMenuItem.Name = "nosotrosToolStripMenuItem";
            nosotrosToolStripMenuItem.Size = new Size(180, 22);
            nosotrosToolStripMenuItem.Text = "Nosotros";
            nosotrosToolStripMenuItem.Click += nosotrosToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(139, 73);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 191);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(530, 338);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
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
        private ToolStripMenuItem cantidadDeDescuentosToolStripMenuItem;
        private ToolStripMenuItem actualizarDescuentosToolStripMenuItem;
        private ToolStripMenuItem clientesÚltimoAñoToolStripMenuItem;
        private ToolStripMenuItem mejoresVendedoreToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem suministrosToolStripMenuItem;
        private ToolStripMenuItem facturaToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem1;
        private ToolStripMenuItem reporteDeFacturasToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem nosotrosToolStripMenuItem;
    }
}