using Calculadora.Controller.Controles;
using System.Data;

namespace Calculadora.View
{
    public partial class FmPrincipal : Form
    {
        public FmPrincipal()
        {
            InitializeComponent();
        }

        // Configurações iniciais do formulario
        private void FmPrincipal_Load(object sender, EventArgs e)
        {
            CmbCategoriaCam1.SelectedIndex = 0;
        }

        // Verificações das entradas nas caixas de texto
        private void TxtComponente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }

        private void TxtnomeCam1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }

        private void TxtNomeCam2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }

        private void TxtNomeCam3_KeyPress(object sender, KeyPressEventArgs e)
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


        // Métodos para ativar os componentes visuais
        private void AtivarCaminhoUm()
        {
            this.DesativarCaminhoDois();
            this.DesativarCaminhoTres();
        }

        private void AtivarCaminhoDois()
        {
            // Liga o caminho 2
            TxtNomeCam2.Visible = true;
            LblNomeCam2.Visible = true;
            LblCaminho2.Visible = true;
            LblCategoriaCam2.Visible = true;
            CmbCategoriaCam2.Visible = true;
            LblElementoCam2.Visible = true;
            CmbElementoCam2.Visible = true;
            LblEsforcoCam2.Visible = true;
            TxtEsforcoCam2.Visible = true;
            BtnRemoverCam2.Visible = true;
            BtnAdicionarCam2.Visible = true;
            LblDgvCam2.Visible = true;
            DgvCaminho2.Visible = true;
            CmbCategoriaCam2.SelectedIndex = 0;
            this.DesativarCaminhoTres();
        }

        private void AtivarCaminhoTres()
        {
            // liga o caminho 3
            this.AtivarCaminhoDois();
            TxtNomeCam3.Visible = true;
            LblNomeCam3.Visible = true;
            LblCaminho3.Visible = true;
            LblCategoriaCam3.Visible = true;
            CmbCategoriaCam3.Visible = true;
            LblElementoCam3.Visible = true;
            CmbElementoCam3.Visible = true;
            LblEsforcoCam3.Visible = true;
            TxtEsforcoCam3.Visible = true;
            BtnRemoverCam3.Visible = true;
            BtnAdicionarCam3.Visible = true;
            LblDgvCam3.Visible = true;
            DgvCaminho3.Visible = true;
            CmbCategoriaCam3.SelectedIndex = 0;
        }


        private void DesativarCaminhoDois()
        {
            // Desliga o Caminho 2
            TxtEsforcoCam2.Clear();
            TxtNomeCam2.Clear();
            TxtNomeCam2.Visible = false;
            LblCaminho2.Visible = false;
            LblCategoriaCam2.Visible = false;
            CmbCategoriaCam2.Visible = false;
            LblElementoCam2.Visible = false;
            CmbElementoCam2.Visible = false;
            LblEsforcoCam2.Visible = false;
            TxtEsforcoCam2.Visible = false;
            BtnRemoverCam2.Visible = false;
            BtnAdicionarCam2.Visible = false;
            LblDgvCam2.Visible = false;
            DgvCaminho2.Visible = false;
            DgvCaminho2.Rows.Clear();
        }

        private void DesativarCaminhoTres()
        {
            // Desliga o Caminho 3
            TxtEsforcoCam3.Clear();
            TxtNomeCam3.Clear();
            TxtNomeCam3.Visible = false;
            LblCaminho3.Visible = false;
            LblCategoriaCam3.Visible = false;
            CmbCategoriaCam3.Visible = false;
            LblElementoCam3.Visible = false;
            CmbElementoCam3.Visible = false;
            LblEsforcoCam3.Visible = false;
            TxtEsforcoCam3.Visible = false;
            BtnRemoverCam3.Visible = false;
            BtnAdicionarCam3.Visible = false;
            LblDgvCam3.Visible = false;
            DgvCaminho3.Visible = false;
            DgvCaminho3.Rows.Clear();
        }


        private void CmbCategoriaCam1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CtlCategoria ctlCategoria = new CtlCategoria(CmbCategoriaCam1.SelectedItem.ToString());
            Dictionary<string, double> dicionario = ctlCategoria.SelecionarConsulta();
            CmbElementoCam1.DataSource = new BindingSource(dicionario, null);
            CmbElementoCam1.DisplayMember = "key";
            CmbElementoCam1.ValueMember = "value";
        }

        private void BtnAdicionarCam1_Click(object sender, EventArgs e)
        {
            // Preciso popular o DataGrid quando eu clicar no botão
            DgvCaminho1.Rows.Add(CmbCategoriaCam1.SelectedItem, CmbElementoCam1.SelectedItem.ToString(), TxtEsforcoCam1.Text); // Vou precisar arrumar essa perte pq ele pega os cl=olchetes
            TxtEsforcoCam1.Clear();
        }

        private void BtnRemoverCam1_Click(object sender, EventArgs e)
        {
            if (DgvCaminho1.Rows.Count > 0)
            {
                DgvCaminho1.Rows.RemoveAt(DgvCaminho1.Rows.Count - 1);
            }
        }

        private void CmbCategoriaCam2_SelectedIndexChanged(object sender, EventArgs e)
        {
            CtlCategoria ctlCategoria = new CtlCategoria(CmbCategoriaCam2.SelectedItem.ToString());
            Dictionary<string, double> dicionario = ctlCategoria.SelecionarConsulta();
            CmbElementoCam2.DataSource = new BindingSource(dicionario, null);
            CmbElementoCam2.DisplayMember = "key";
            CmbElementoCam2.ValueMember = "value";
        }

        private void BtnAdicionarCam2_Click(object sender, EventArgs e)
        {
            DgvCaminho2.Rows.Add(CmbCategoriaCam2.SelectedItem, CmbElementoCam2.SelectedItem.ToString(), TxtEsforcoCam2.Text); // Vou precisar arrumar essa perte pq ele pega os cl=olchetes
            TxtEsforcoCam2.Clear();
        }

        private void BtnRemoverCam2_Click(object sender, EventArgs e)
        {
            DgvCaminho2.Rows.RemoveAt(DgvCaminho2.Rows.Count - 1);
        }

        private void CmbCategoriaCam3_SelectedIndexChanged(object sender, EventArgs e)
        {
            CtlCategoria ctlCategoria = new CtlCategoria(CmbCategoriaCam3.SelectedItem.ToString());
            Dictionary<string, double> dicionario = ctlCategoria.SelecionarConsulta();
            CmbElementoCam3.DataSource = new BindingSource(dicionario, null);
            CmbElementoCam3.DisplayMember = "key";
            CmbElementoCam3.ValueMember = "value";
        }

        private void BtnAdicionarCam3_Click(object sender, EventArgs e)
        {
            DgvCaminho3.Rows.Add(CmbCategoriaCam2.SelectedItem, CmbElementoCam3.SelectedItem.ToString(), TxtEsforcoCam3.Text); // Vou precisar arrumar essa perte pq ele pega os cl=olchetes
            TxtEsforcoCam3.Clear();
        }

        private void BtnRemoverCam3_Click(object sender, EventArgs e)
        {
            DgvCaminho3.Rows.RemoveAt(DgvCaminho3.Rows.Count - 1);
        }

        private void TxtnomeCam1_TextChanged(object sender, EventArgs e)
        {
            LblNomeCam1.Text = TxtNomeCam1.Text.ToString();
        }

        private void TxtNomeCam2_TextChanged(object sender, EventArgs e)
        {
            LblNomeCam2.Text = TxtNomeCam2.Text.ToString();
        }

        private void TxtNomeCam3_TextChanged(object sender, EventArgs e)
        {
            LblNomeCam3.Text = TxtNomeCam3.Text.ToString();
        }
    }
}
