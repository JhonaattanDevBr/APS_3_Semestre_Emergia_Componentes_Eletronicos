namespace Calculadora.View
{
    public partial class FmPrincipal : Form
    {
        public FmPrincipal()
        {
            InitializeComponent();
        }


        // Verificações das entradas nas caixas de texto
        private void TxtComponente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }

        private void TxtEsforcoCam1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void TxtEsforcoCam2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void TxtEsforcoCam3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void TxtEsforcoCam4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }


        // Verificações dos Radio Buttons
        private void RbtUm_CheckedChanged(object sender, EventArgs e)
        {
            if (RbtUm.Checked)
            {
                this.AtivarCaminhoUm();
            }
        }

        private void RbtDois_CheckedChanged(object sender, EventArgs e)
        {
            if (RbtDois.Checked)
            {
                this.AtivarCaminhoDois();
            }
        }

        private void RbtTres_CheckedChanged(object sender, EventArgs e)
        {
            if (RbtTres.Checked)
            {
                this.AtivarCaminhoTres();
            }
        }

        private void RbtQuatro_CheckedChanged(object sender, EventArgs e)
        {
            if (RbtQuatro.Checked)
            {
                this.AtivarCaminhoDois();
                this.AtivarCaminhoTres();
                this.AtivarCaminhoQuatro();
            }
        }

        // Métodos para ativar os componentes visuais
        private void AtivarCaminhoUm()
        {
            this.DesativarCaminhoDois();
            this.DesativarCaminhoTres();
            this.DesativarCaminhoQuatro();
        }

        private void AtivarCaminhoDois()
        {
            // Liga o caminho 2
            LblCaminho2.Visible = true;
            LblCategoriaCam2.Visible = true;
            CmbCategoriaCam2.Visible = true;
            LblElementoCam2.Visible = true;
            CmbElementoCam2.Visible = true;
            LblEsforcoCam2.Visible = true;
            TxtEsforcoCam2.Visible = true;
            BtnRemoverCam2.Visible = true;
            BtnAdicionarCam2.Visible = true;
            this.DesativarCaminhoTres();
            this.DesativarCaminhoQuatro();
        }

        private void AtivarCaminhoTres()
        {
            // liga o caminho 3
            this.AtivarCaminhoDois();
            LblCaminho3.Visible = true;
            LblCategoriaCam3.Visible = true;
            CmbCategoriaCam3.Visible = true;
            LblElementoCam3.Visible = true;
            CmbElementoCam3.Visible = true;
            LblEsforcoCam3.Visible = true;
            TxtEsforcoCam3.Visible = true;
            BtnRemoverCam3.Visible = true;
            BtnAdicionarCam3.Visible = true;
            this.DesativarCaminhoQuatro();
        }

        private void AtivarCaminhoQuatro()
        {
            // Liga o caminho 4
            LblCaminho4.Visible = true;
            LblCategoriaCam4.Visible = true;
            CmbCategoriaCam4.Visible = true;
            LblElementoCam4.Visible = true;
            CmbElementoCam4.Visible = true;
            LblEsforcoCam4.Visible = true;
            TxtEsforcoCam4.Visible = true;
            BtnRemoverCam4.Visible = true;
            BtnAdicionarCam4.Visible = true;
        }

        private void DesativarCaminhoDois()
        {
            // Desliga o Caminho 2
            TxtEsforcoCam2.Clear();
            LblCaminho2.Visible = false;
            LblCategoriaCam2.Visible = false;
            CmbCategoriaCam2.Visible = false;
            LblElementoCam2.Visible = false;
            CmbElementoCam2.Visible = false;
            LblEsforcoCam2.Visible = false;
            TxtEsforcoCam2.Visible = false;
            BtnRemoverCam2.Visible = false;
            BtnAdicionarCam2.Visible = false;
        }

        private void DesativarCaminhoTres()
        {
            // Desliga o Caminho 3
            TxtEsforcoCam3.Clear();
            LblCaminho3.Visible = false;
            LblCategoriaCam3.Visible = false;
            CmbCategoriaCam3.Visible = false;
            LblElementoCam3.Visible = false;
            CmbElementoCam3.Visible = false;
            LblEsforcoCam3.Visible = false;
            TxtEsforcoCam3.Visible = false;
            BtnRemoverCam3.Visible = false;
            BtnAdicionarCam3.Visible = false;
        }

        private void DesativarCaminhoQuatro()
        {
            // Desliga o Caminho 4
            TxtEsforcoCam4.Clear();
            LblCaminho4.Visible = false;
            LblCategoriaCam4.Visible = false;
            CmbCategoriaCam4.Visible = false;
            LblElementoCam4.Visible = false;
            CmbElementoCam4.Visible = false;
            LblEsforcoCam4.Visible = false;
            TxtEsforcoCam4.Visible = false;
            BtnRemoverCam4.Visible = false;
            BtnAdicionarCam4.Visible = false;
        }

        

    }
}
