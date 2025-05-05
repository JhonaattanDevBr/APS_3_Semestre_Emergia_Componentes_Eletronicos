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
            else
            {
                this.DesativarCaminhoDois();
                this.DesativarCaminhoTres();
                this.DesativarCaminhoQuatro();
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
                    this.AtivarCaminhoDois();
                    break;

                case 3:
                    this.AtivarCaminhoDois();
                    this.AtivarCaminhoTres();
                    break;

                case 4:
                    this.AtivarCaminhoDois();
                    this.AtivarCaminhoTres();
                    this.AtivarCaminhoQuatro();
                    break;
            }
        }

        private void AtivarCaminhoUm()
        {
            this.DesativarCaminhoDois();
            this.DesativarCaminhoTres();
            this.DesativarCaminhoQuatro();
        }

        private void AtivarCaminhoDois()
        {
            this.DesativarCaminhoTres();
            this.DesativarCaminhoQuatro();
            LblCaminho2.Visible = true;
            LblCategoriaCam2.Visible = true;
            CmbCategoriaCam2.Visible = true;
            LblElementoCam2.Visible = true;
            CmbElementoCam2.Visible = true;
            LblValorCam2.Visible = true;
            TxtValorCam2.Visible = true;
            BtnRemoverCam2.Visible = true;
            BtnAdicionarCam2.Visible = true;
        }

        private void AtivarCaminhoTres()
        {
            this.DesativarCaminhoQuatro();
            LblCaminho3.Visible = true;
            LblCategoriaCam3.Visible = true;
            CmbCategoriaCam3.Visible = true;
            LblElementoCam3.Visible = true;
            CmbElementoCam3.Visible = true;
            LblValorCam3.Visible = true;
            TxtValorCam3.Visible = true;
            BtnRemoverCam3.Visible = true;
            BtnAdicionarCam3.Visible = true;
        }

        private void AtivarCaminhoQuatro()
        {
            LblCaminho4.Visible = true;
            LblCategoriaCam4.Visible = true;
            CmbCategoriaCam4.Visible = true;
            LblElementoCam4.Visible = true;
            CmbElementoCam4.Visible = true;
            LblValorCam4.Visible = true;
            TxtValorCam4.Visible = true;
            BtnRemoverCam4.Visible = true;
            BtnAdicionarCam4.Visible = true;
        }

        private void DesativarCaminhoDois()
        {
            // Desliga o Caminho 2
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

        private void DesativarCaminhoTres()
        {
            // Desliga o Caminho 3
            LblCaminho3.Visible = false;
            LblCategoriaCam3.Visible = false;
            CmbCategoriaCam3.Visible = false;
            LblElementoCam3.Visible = false;
            CmbElementoCam3.Visible = false;
            LblValorCam3.Visible = false;
            TxtValorCam3.Visible = false;
            BtnRemoverCam3.Visible = false;
            BtnAdicionarCam3.Visible = false;
        }

        private void DesativarCaminhoQuatro()
        {
            // Desliga o Caminho 4
            LblCaminho4.Visible = false;
            LblCategoriaCam4.Visible = false;
            CmbCategoriaCam4.Visible = false;
            LblElementoCam4.Visible = false;
            CmbElementoCam4.Visible = false;
            LblValorCam4.Visible = false;
            TxtValorCam4.Visible = false;
            BtnRemoverCam4.Visible = false;
            BtnAdicionarCam4.Visible = false;
        }
    }
}
