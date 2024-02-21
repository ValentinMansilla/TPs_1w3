namespace FarmaciaPantallas
{
    partial class FrmReporteFactura
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
            rvFacturas = new Microsoft.Reporting.WinForms.ReportViewer();
            btnGenerar = new Button();
            dtpDesde = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            dtpHasta = new DateTimePicker();
            btnSalir = new Button();
            lbl_facturanumero = new Label();
            SuspendLayout();
            // 
            // rvFacturas
            // 
            rvFacturas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rvFacturas.BackColor = Color.FromArgb(0, 0, 64);
            rvFacturas.IsDocumentMapWidthFixed = true;
            rvFacturas.Location = new Point(62, 100);
            rvFacturas.Name = "ReportViewer";
            rvFacturas.ServerReport.BearerToken = null;
            rvFacturas.Size = new Size(650, 400);
            rvFacturas.TabIndex = 0;
            rvFacturas.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.FromArgb(0, 0, 64);
            btnGenerar.ForeColor = Color.LightYellow;
            btnGenerar.Location = new Point(637, 56);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(75, 23);
            btnGenerar.TabIndex = 1;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(113, 56);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(200, 23);
            dtpDesde.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(338, 62);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 3;
            label1.Text = "Hasta: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 62);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 3;
            label2.Text = "Desde: ";
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(397, 56);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(200, 23);
            dtpHasta.TabIndex = 2;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.BackColor = Color.FromArgb(0, 0, 64);
            btnSalir.ForeColor = Color.LightYellow;
            btnSalir.Location = new Point(697, 526);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lbl_facturanumero
            // 
            lbl_facturanumero.AutoSize = true;
            lbl_facturanumero.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_facturanumero.ForeColor = Color.FromArgb(0, 0, 64);
            lbl_facturanumero.Location = new Point(62, 19);
            lbl_facturanumero.Name = "lbl_facturanumero";
            lbl_facturanumero.Size = new Size(122, 21);
            lbl_facturanumero.TabIndex = 23;
            lbl_facturanumero.Text = "Elegir período:";
            lbl_facturanumero.Click += lbl_facturanumero_Click;
            // 
            // FrmReporteFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(784, 561);
            ControlBox = false;
            Controls.Add(lbl_facturanumero);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpHasta);
            Controls.Add(dtpDesde);
            Controls.Add(btnSalir);
            Controls.Add(btnGenerar);
            Controls.Add(rvFacturas);
            Name = "FrmReporteFactura";
            Text = "Reporte de Factura";
            WindowState = FormWindowState.Maximized;
            Load += FrmReporteFactura_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvFacturas;
        private Button btnGenerar;
        private DateTimePicker dtpDesde;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpHasta;
        private Button btnSalir;
        private Label lbl_facturanumero;
    }
}