namespace finalDegreeProjectP2.FacturaInteractiva
{
    public partial class FacturaInteractivaForm : Form
    {
        private decimal total = 0m;

        public FacturaInteractivaForm()
        {
            InitializeComponent();
        }

        private void ClearForm()
        {
            tbCodigo.Text = "";
            tbProducto.Text = "";
            tbPrecio.Text = "";
            tbQuantity.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (
                !string.IsNullOrEmpty(tbCodigo.Text) &&
                !string.IsNullOrEmpty(tbProducto.Text) &&
                decimal.TryParse(tbPrecio.Text, out decimal precio) &&
                int.TryParse(tbQuantity.Text, out int cantidad)
               )
            {
                dataGridView1.Rows.Add(tbCodigo.Text, tbProducto.Text, precio, cantidad);
                total += precio * cantidad;
                UpdateTotal();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos correctamente.");
            }
        }

        private void UpdateTotal()
        {
            lbTotal.Text = $"Total: {total:C2}";
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (
                decimal.TryParse(e.Row.Cells[2].Value.ToString(), out decimal precio) &&
                int.TryParse(e.Row.Cells[3].Value.ToString(), out int cantidad)
               )
            {
                total -= precio * cantidad;
                UpdateTotal();
            }
        }
    }
}
