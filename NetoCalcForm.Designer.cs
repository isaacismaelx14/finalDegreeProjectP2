namespace finalDegreeProjectP2
{
    partial class NetoCalcForm
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
            lblSueldoBruto = new Label();
            tbSueldoBruto = new TextBox();
            lbAfpTitle = new Label();
            lbArsTitle = new Label();
            lbCoopertivaTitle = new Label();
            panelData = new Panel();
            lbSueldoNeto = new Label();
            lbTotalDescuento = new Label();
            lbIrs = new Label();
            lbCooperativa = new Label();
            lbArs = new Label();
            lbAfp = new Label();
            lbSueldoNetoTitle = new Label();
            lbDescuentoTitle = new Label();
            lbIrsTitle = new Label();
            btnCalcular = new Button();
            panelData.SuspendLayout();
            SuspendLayout();
            // 
            // lblSueldoBruto
            // 
            lblSueldoBruto.AutoSize = true;
            lblSueldoBruto.Location = new Point(12, 18);
            lblSueldoBruto.Name = "lblSueldoBruto";
            lblSueldoBruto.Size = new Size(75, 15);
            lblSueldoBruto.TabIndex = 0;
            lblSueldoBruto.Text = "Sueldo Bruto";
            // 
            // tbSueldoBruto
            // 
            tbSueldoBruto.Location = new Point(12, 36);
            tbSueldoBruto.Name = "tbSueldoBruto";
            tbSueldoBruto.Size = new Size(187, 23);
            tbSueldoBruto.TabIndex = 1;
            // 
            // lbAfpTitle
            // 
            lbAfpTitle.AutoSize = true;
            lbAfpTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbAfpTitle.Location = new Point(3, 6);
            lbAfpTitle.Name = "lbAfpTitle";
            lbAfpTitle.Size = new Size(43, 21);
            lbAfpTitle.TabIndex = 2;
            lbAfpTitle.Text = "AFP:";
            // 
            // lbArsTitle
            // 
            lbArsTitle.AutoSize = true;
            lbArsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbArsTitle.Location = new Point(3, 27);
            lbArsTitle.Name = "lbArsTitle";
            lbArsTitle.Size = new Size(44, 21);
            lbArsTitle.TabIndex = 3;
            lbArsTitle.Text = "ARS:";
            // 
            // lbCoopertivaTitle
            // 
            lbCoopertivaTitle.AutoSize = true;
            lbCoopertivaTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbCoopertivaTitle.Location = new Point(3, 48);
            lbCoopertivaTitle.Name = "lbCoopertivaTitle";
            lbCoopertivaTitle.Size = new Size(107, 21);
            lbCoopertivaTitle.TabIndex = 4;
            lbCoopertivaTitle.Text = "Cooperativa:";
            // 
            // panelData
            // 
            panelData.Controls.Add(lbSueldoNeto);
            panelData.Controls.Add(lbTotalDescuento);
            panelData.Controls.Add(lbIrs);
            panelData.Controls.Add(lbCooperativa);
            panelData.Controls.Add(lbArs);
            panelData.Controls.Add(lbAfp);
            panelData.Controls.Add(lbSueldoNetoTitle);
            panelData.Controls.Add(lbDescuentoTitle);
            panelData.Controls.Add(lbIrsTitle);
            panelData.Controls.Add(lbCoopertivaTitle);
            panelData.Controls.Add(lbAfpTitle);
            panelData.Controls.Add(lbArsTitle);
            panelData.Location = new Point(12, 84);
            panelData.Name = "panelData";
            panelData.Size = new Size(511, 188);
            panelData.TabIndex = 5;
            panelData.Visible = false;
            // 
            // lbSueldoNeto
            // 
            lbSueldoNeto.AutoSize = true;
            lbSueldoNeto.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbSueldoNeto.Location = new Point(335, 160);
            lbSueldoNeto.Name = "lbSueldoNeto";
            lbSueldoNeto.Size = new Size(17, 19);
            lbSueldoNeto.TabIndex = 13;
            lbSueldoNeto.Text = "0";
            lbSueldoNeto.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbTotalDescuento
            // 
            lbTotalDescuento.AutoSize = true;
            lbTotalDescuento.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbTotalDescuento.Location = new Point(137, 161);
            lbTotalDescuento.Name = "lbTotalDescuento";
            lbTotalDescuento.Size = new Size(17, 19);
            lbTotalDescuento.TabIndex = 12;
            lbTotalDescuento.Text = "0";
            lbTotalDescuento.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbIrs
            // 
            lbIrs.AutoSize = true;
            lbIrs.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbIrs.Location = new Point(47, 72);
            lbIrs.Name = "lbIrs";
            lbIrs.Size = new Size(17, 19);
            lbIrs.TabIndex = 11;
            lbIrs.Text = "0";
            // 
            // lbCooperativa
            // 
            lbCooperativa.AutoSize = true;
            lbCooperativa.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbCooperativa.Location = new Point(116, 51);
            lbCooperativa.Name = "lbCooperativa";
            lbCooperativa.Size = new Size(17, 19);
            lbCooperativa.TabIndex = 10;
            lbCooperativa.Text = "0";
            // 
            // lbArs
            // 
            lbArs.AutoSize = true;
            lbArs.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbArs.Location = new Point(52, 27);
            lbArs.Name = "lbArs";
            lbArs.Size = new Size(17, 19);
            lbArs.TabIndex = 9;
            lbArs.Text = "0";
            // 
            // lbAfp
            // 
            lbAfp.AutoSize = true;
            lbAfp.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbAfp.Location = new Point(52, 8);
            lbAfp.Name = "lbAfp";
            lbAfp.Size = new Size(17, 19);
            lbAfp.TabIndex = 8;
            lbAfp.Text = "0";
            // 
            // lbSueldoNetoTitle
            // 
            lbSueldoNetoTitle.AutoSize = true;
            lbSueldoNetoTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbSueldoNetoTitle.Location = new Point(230, 158);
            lbSueldoNetoTitle.Name = "lbSueldoNetoTitle";
            lbSueldoNetoTitle.Size = new Size(109, 21);
            lbSueldoNetoTitle.TabIndex = 7;
            lbSueldoNetoTitle.Text = "Sueldo Neto:";
            // 
            // lbDescuentoTitle
            // 
            lbDescuentoTitle.AutoSize = true;
            lbDescuentoTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbDescuentoTitle.Location = new Point(3, 158);
            lbDescuentoTitle.Name = "lbDescuentoTitle";
            lbDescuentoTitle.Size = new Size(137, 21);
            lbDescuentoTitle.TabIndex = 6;
            lbDescuentoTitle.Text = "Total Descuento:";
            // 
            // lbIrsTitle
            // 
            lbIrsTitle.AutoSize = true;
            lbIrsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbIrsTitle.Location = new Point(3, 69);
            lbIrsTitle.Name = "lbIrsTitle";
            lbIrsTitle.Size = new Size(38, 21);
            lbIrsTitle.TabIndex = 5;
            lbIrsTitle.Text = "IRS:";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(208, 36);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // NetoCalcForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 296);
            Controls.Add(btnCalcular);
            Controls.Add(panelData);
            Controls.Add(tbSueldoBruto);
            Controls.Add(lblSueldoBruto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NetoCalcForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "NetoCalc";
            panelData.ResumeLayout(false);
            panelData.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSueldoBruto;
        private TextBox tbSueldoBruto;
        private Label lbAfpTitle;
        private Label lbArsTitle;
        private Label lbCoopertivaTitle;
        private Panel panelData;
        private Label lbDescuentoTitle;
        private Label lbIrsTitle;
        private Label lbSueldoNetoTitle;
        private Label lbArs;
        private Label lbAfp;
        private Button btnCalcular;
        private Label lbSueldoNeto;
        private Label lbTotalDescuento;
        private Label lbIrs;
        private Label lbCooperativa;
    }
}