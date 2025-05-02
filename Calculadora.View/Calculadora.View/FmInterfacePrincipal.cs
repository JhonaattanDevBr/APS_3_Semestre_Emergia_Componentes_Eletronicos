namespace Calculadora.View
{
    public partial class FmPrincipal : Form
    {
        public FmPrincipal()
        {
            InitializeComponent();
        }

        private void TxtComponente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }

        private void TxtQuantidadeCaminhos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void TxtQuantidadeCaminhos_TextChanged(object sender, EventArgs e)
        {

            if (!(TxtQuantidadeCaminhos.Text == ""))
            {
                int numeroValido = Convert.ToInt32(TxtQuantidadeCaminhos.Text);

                if (!(numeroValido > 0 && numeroValido < 5))
                {
                    MessageBox.Show("A faixa de valores permitida é de 0 a 4", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtQuantidadeCaminhos.Clear();
                    TxtQuantidadeCaminhos.Focus();
                }
                this.AtivadorDeCaminhos(numeroValido);
            }
        }

        private void AtivadorDeCaminhos(int numeroCaminhos)
        {
            switch (numeroCaminhos)
            {
                case 1:
                    this.AtivarCaminhoUm();
                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;
            }
        }

        private void AtivarCaminhoUm()
        {
            LblCaminho2.Visible = false;
            LblCategoriaCam2.Visible = false;
            CmbCategoriaCam2.Visible = false;
            LblElementoCam2.Visible = false;
            CmbElementoCam2.Visible = false;
            LblValorCam2.Visible = false;
            TxtValorCam2.Visible = false;
            BtnRemoverCam2.Visible = false;
            BtnAdicionarCam2.Visible = false;
        }
    }
}
