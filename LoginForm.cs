using finalDegreeProjectP2.Service;

namespace finalDegreeProjectP2
{
    public partial class LoginForm : Form
    {
        private LoginService LoginService;
        public LoginForm()
        {
            InitializeComponent();
            LoginService = new LoginService();
        }

        private void HandleClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private bool CheckForm()
        {
            if (string.IsNullOrEmpty(tbUser.Text) || string.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return false;
            }

            return true;
        }

        private async Task<bool> IsAuthorized()
        {
            if (!CheckForm())
                return false;

            bool auth = await LoginService.Authenticate(tbUser.Text, tbPassword.Text);
            return auth;
        }

        private void SetLoadingForm(bool loading)
        {
            if (loading)
            {
                btnLogin.Enabled = false;
                btnLogin.Text = "Cargando...";
                tbPassword.Enabled = false;
                tbUser.Enabled = false;
            }
            else
            {
                btnLogin.Enabled = true;
                btnLogin.Text = "Iniciar Sesión";
                tbPassword.Enabled = true;
                tbUser.Enabled = true;
            }

        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            SetLoadingForm(true);
            bool authorized = await IsAuthorized();

            if (!authorized)
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
                SetLoadingForm(false);
                return;
            }

            MainForm mainForm = new();
            mainForm.FormClosed += HandleClose;
            mainForm.Show();

            Hide();

        }
    }
}
