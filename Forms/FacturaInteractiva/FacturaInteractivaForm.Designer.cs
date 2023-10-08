namespace finalDegreeProjectP2.FacturaInteractiva
{
    partial class FacturaInteractivaForm
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
            textBoxLabel = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            textBox2 = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            textBox3 = new TextBox();
            label3 = new Label();
            panel3 = new Panel();
            textBox4 = new TextBox();
            label4 = new Label();
            panel4 = new Panel();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            code = new DataGridViewTextBoxColumn();
            product = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            lbTotal = new Label();
            textBoxLabel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBoxLabel
            // 
            textBoxLabel.Controls.Add(textBox1);
            textBoxLabel.Controls.Add(label1);
            textBoxLabel.Location = new Point(3, 3);
            textBoxLabel.Name = "textBoxLabel";
            textBoxLabel.Size = new Size(129, 52);
            textBoxLabel.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(3, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(123, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 5);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo";
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(135, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(262, 52);
            panel1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(3, 23);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(256, 23);
            textBox2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 5);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 0;
            label2.Text = "Producto";
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(403, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(124, 52);
            panel2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Location = new Point(3, 23);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(118, 23);
            textBox3.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 5);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 0;
            label3.Text = "Precio";
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(533, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(124, 52);
            panel3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Location = new Point(3, 23);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(118, 23);
            textBox4.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 5);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 0;
            label4.Text = "Cantidad";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(button1);
            panel4.Controls.Add(textBoxLabel);
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(panel2);
            panel4.Location = new Point(12, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(792, 62);
            panel4.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(663, 4);
            button1.Name = "button1";
            button1.Size = new Size(126, 51);
            button1.TabIndex = 5;
            button1.Text = "Facturar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { code, product, price, quantity });
            dataGridView1.Location = new Point(12, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(789, 296);
            dataGridView1.TabIndex = 6;
            dataGridView1.UserDeletingRow += dataGridView1_UserDeletingRow;
            // 
            // code
            // 
            code.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            code.HeaderText = "Codigo";
            code.Name = "code";
            code.Resizable = DataGridViewTriState.False;
            // 
            // product
            // 
            product.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            product.HeaderText = "Producto";
            product.Name = "product";
            // 
            // price
            // 
            price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            price.HeaderText = "Precio";
            price.Name = "price";
            // 
            // quantity
            // 
            quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            quantity.HeaderText = "Cantidad";
            quantity.Name = "quantity";
            // 
            // lbTotal
            // 
            lbTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lbTotal.AutoSize = true;
            lbTotal.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbTotal.Location = new Point(12, 388);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(95, 25);
            lbTotal.TabIndex = 7;
            lbTotal.Text = "Total: 0.00";
            lbTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FacturaInteractivaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 422);
            Controls.Add(lbTotal);
            Controls.Add(dataGridView1);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FacturaInteractivaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FacturaInteractiva";
            textBoxLabel.ResumeLayout(false);
            textBoxLabel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel textBoxLabel;
        private TextBox textBox1;
        private Label label1;
        private Panel panel1;
        private TextBox textBox2;
        private Label label2;
        private Panel panel2;
        private TextBox textBox3;
        private Label label3;
        private Panel panel3;
        private TextBox textBox4;
        private Label label4;
        private Panel panel4;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn code;
        private DataGridViewTextBoxColumn product;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn quantity;
        private Label lbTotal;
    }
}