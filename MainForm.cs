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
            NetoCalcForm netoCalc = new NetoCalcForm();
            netoCalc.ShowDialog();
        }
    }
}