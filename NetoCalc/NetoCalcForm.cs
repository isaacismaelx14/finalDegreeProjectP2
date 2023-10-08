namespace finalDegreeProjectP2
{
    public partial class NetoCalcForm : Form
    {
        public NetoCalcForm()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal sueldoBruto = getSueldoBruto();

            decimal afp = sueldoBruto * 0.07m;
            decimal ars = sueldoBruto * 0.03m;
            decimal cooperativa = sueldoBruto * 0.02m;
            decimal isr = 0m;

            if (sueldoBruto >= 34334m && sueldoBruto <= 50000m)
            {
                isr = sueldoBruto * 0.15m;
            }
            else if (sueldoBruto >= 51000m && sueldoBruto <= 100000m)
            {
                isr = sueldoBruto * 0.20m;
            }
            else if (sueldoBruto > 100000m)
            {
                isr = sueldoBruto * 0.25m;
            }

            decimal totalDescuento = afp + ars + cooperativa + isr;
            decimal sueldoNeto = sueldoBruto - totalDescuento;

            lbAfp.Text = afp.ToString("C2");
            lbArs.Text = ars.ToString("C2");
            lbCooperativa.Text = cooperativa.ToString("C2");
            lbIrs.Text = isr.ToString("C2");
            lbTotalDescuento.Text = totalDescuento.ToString("C2");
            lbSueldoNeto.Text = sueldoNeto.ToString("C2");

            panelData.Visible = true;
        }

        private decimal getSueldoBruto()
        {
            decimal sueldoBruto;
            if (!decimal.TryParse(tbSueldoBruto.Text, out sueldoBruto))
            {
                MessageBox.Show("Por favor, ingresa un valor válido para el sueldo bruto.");
                return -1;
            }

            if (sueldoBruto <= 0)
            {
                MessageBox.Show("El sueldo bruto debe ser mayor a 0");
                return -1;
            }

            return sueldoBruto;
        }
    }
}
