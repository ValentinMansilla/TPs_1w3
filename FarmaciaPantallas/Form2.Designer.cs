namespace FarmaciaPantallas
{
    partial class SP_CANTIDAD_DESCUENTOS
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
            pictureBox1 = new PictureBox();
            dateTimePickerDesde = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dateTimePickerHasta = new DateTimePicker();
            button1 = new Button();
            textBoxDescuento1 = new TextBox();
            textBoxDescuento2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icono_2;
            pictureBox1.Location = new Point(25, 34);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dateTimePickerDesde
            // 
            dateTimePickerDesde.Location = new Point(182, 34);
            dateTimePickerDesde.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerDesde.Name = "dateTimePickerDesde";
            dateTimePickerDesde.Size = new Size(260, 23);
            dateTimePickerDesde.TabIndex = 1;
            dateTimePickerDesde.Value = new DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(335, 18);
            label1.TabIndex = 2;
            label1.Text = "VERIFICAR CANTIDAD DE DESCUENTOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(118, 40);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Desde";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(0, 0, 64);
            label3.Location = new Point(120, 75);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 4;
            label3.Text = "Hasta";
            // 
            // dateTimePickerHasta
            // 
            dateTimePickerHasta.Location = new Point(182, 69);
            dateTimePickerHasta.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerHasta.Name = "dateTimePickerHasta";
            dateTimePickerHasta.Size = new Size(260, 23);
            dateTimePickerHasta.TabIndex = 5;
            dateTimePickerHasta.Value = new DateTime(2023, 11, 14, 0, 0, 0, 0);
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 0, 64);
            button1.Location = new Point(25, 147);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 6;
            button1.Text = "Verificar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBoxDescuento1
            // 
            textBoxDescuento1.Location = new Point(280, 103);
            textBoxDescuento1.Margin = new Padding(3, 2, 3, 2);
            textBoxDescuento1.Name = "textBoxDescuento1";
            textBoxDescuento1.Size = new Size(33, 23);
            textBoxDescuento1.TabIndex = 7;
            textBoxDescuento1.Text = "10";
            // 
            // textBoxDescuento2
            // 
            textBoxDescuento2.Location = new Point(363, 103);
            textBoxDescuento2.Margin = new Padding(3, 2, 3, 2);
            textBoxDescuento2.Name = "textBoxDescuento2";
            textBoxDescuento2.Size = new Size(33, 23);
            textBoxDescuento2.TabIndex = 8;
            textBoxDescuento2.Text = "30";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(0, 0, 64);
            label4.Location = new Point(181, 106);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 9;
            label4.Text = "Descuento entre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(0, 0, 64);
            label5.Location = new Point(319, 106);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 10;
            label5.Text = "%   Y";
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(0, 0, 64);
            button2.Location = new Point(120, 147);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 11;
            button2.Text = "Volver";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(0, 0, 64);
            label6.Location = new Point(402, 106);
            label6.Name = "label6";
            label6.Size = new Size(17, 15);
            label6.TabIndex = 12;
            label6.Text = "%";
            // 
            // SP_CANTIDAD_DESCUENTOS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(459, 188);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxDescuento2);
            Controls.Add(textBoxDescuento1);
            Controls.Add(button1);
            Controls.Add(dateTimePickerHasta);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePickerDesde);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SP_CANTIDAD_DESCUENTOS";
            Text = "Cantidad de Descuentos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private DateTimePicker dateTimePickerDesde;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePickerHasta;
        private Button button1;
        private TextBox textBoxDescuento1;
        private TextBox textBoxDescuento2;
        private Label label4;
        private Label label5;
        private Button button2;
        private Label label6;
    }
}