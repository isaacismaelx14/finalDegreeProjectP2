using finalDegreeProjectP2.FacturaInteractiva;

namespace finalDegreeProjectP2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NetoCalcForm netoCalc = new();
            netoCalc.ShowDialog();
        }

        private void btnExecuteFactura_Click(object sender, EventArgs e)
        {
            FacturaInteractivaForm facturaInteractivaForm = new();
            facturaInteractivaForm.ShowDialog();
        }
    }
}