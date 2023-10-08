namespace finalDegreeProjectP2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            label1 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            btnExecuteFactura = new Button();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 44);
            label1.Name = "label1";
            label1.Size = new Size(149, 37);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(30, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(357, 314);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Coral;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(-10, 264);
            button1.Name = "button1";
            button1.Size = new Size(377, 51);
            button1.TabIndex = 5;
            button1.Text = "Ejecutar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 51);
            label3.Name = "label3";
            label3.Size = new Size(339, 45);
            label3.TabIndex = 4;
            label3.Text = "Tu ruta directa al cálculo preciso del sueldo neto, desglosando\r\nlos descuentos de AFP, ARS, Cooperativa e ISR con solo un clic.\r\n¡Descubre tu ingreso real al instante!\"";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.OrangeRed;
            label2.Location = new Point(121, 13);
            label2.Name = "label2";
            label2.Size = new Size(98, 28);
            label2.TabIndex = 3;
            label2.Text = "NetoCalc";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnExecuteFactura);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(404, 96);
            panel2.Name = "panel2";
            panel2.Size = new Size(357, 314);
            panel2.TabIndex = 2;
            // 
            // btnExecuteFactura
            // 
            btnExecuteFactura.BackColor = Color.RoyalBlue;
            btnExecuteFactura.Cursor = Cursors.Hand;
            btnExecuteFactura.FlatStyle = FlatStyle.Flat;
            btnExecuteFactura.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnExecuteFactura.ForeColor = SystemColors.ButtonFace;
            btnExecuteFactura.Location = new Point(-12, 264);
            btnExecuteFactura.Name = "btnExecuteFactura";
            btnExecuteFactura.Size = new Size(378, 49);
            btnExecuteFactura.TabIndex = 6;
            btnExecuteFactura.Text = "Ejecutar";
            btnExecuteFactura.UseVisualStyleBackColor = false;
            btnExecuteFactura.Click += btnExecuteFactura_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 51);
            label4.Name = "label4";
            label4.Size = new Size(339, 67);
            label4.TabIndex = 6;
            label4.Text = resources.GetString("label4.Text");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DodgerBlue;
            label5.Location = new Point(84, 13);
            label5.Name = "label5";
            label5.Size = new Size(183, 28);
            label5.TabIndex = 5;
            label5.Text = "FacturaInteractiva";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 430);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            MaximizeBox = false;
            MaximumSize = new Size(799, 469);
            MinimumSize = new Size(799, 469);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UAPA Multi-Task";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Button button1;
        private Button btnExecuteFactura;
        private Label label4;
        private Label label5;
    }
}