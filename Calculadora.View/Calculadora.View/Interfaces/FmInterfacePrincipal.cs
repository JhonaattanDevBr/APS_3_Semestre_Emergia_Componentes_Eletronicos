using Calculadora.Controller.Controles;
using Calculadora.View.Interfaces;
using System.Data;
using System.Globalization;

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


        //Métodos para desativas os componentes visuais
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


        // Método do caminho 1: combo box da categoria, botão de incluir e excluir  
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
            // preciso verificar se o nome do caminho e o esforço foi preenchido
            if (string.IsNullOrEmpty(TxtNomeCam1.Text) || string.IsNullOrEmpty(TxtEsforcoCam1.Text))
            {
                MessageBox.Show("Os campos nome do elemento e esforço do caminho 1 devem ser preenchidos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string elemento = new CtlCategoria(CmbElementoCam1.SelectedItem.ToString()).PegarNomeElemento();
                string unidadeElemento = new CtlCategoria(CmbElementoCam1.SelectedItem.ToString()).PegarValorElemento();
                DgvCaminho1.Rows.Add(CmbCategoriaCam1.SelectedItem, elemento, unidadeElemento, TxtEsforcoCam1.Text);
                TxtEsforcoCam1.Clear();
            }
        }

        private void BtnRemoverCam1_Click(object sender, EventArgs e)
        {
            if (DgvCaminho1.Rows.Count > 0)
            {
                DgvCaminho1.Rows.RemoveAt(DgvCaminho1.Rows.Count - 1);
            }
        }


        // Método do caminho 2: combo box da categoria, botão de incluir e excluir  
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
            // preciso verificar se o nome do caminho e o esforço foi preenchido
            if (string.IsNullOrEmpty(TxtNomeCam2.Text) || string.IsNullOrEmpty(TxtEsforcoCam2.Text))
            {
                MessageBox.Show("Os campos nome do elemento e esforço do caminho 2 devem ser preenchidos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string elemento = new CtlCategoria(CmbElementoCam2.SelectedItem.ToString()).PegarNomeElemento();
                string unidadeElemento = new CtlCategoria(CmbElementoCam2.SelectedItem.ToString()).PegarValorElemento();
                DgvCaminho2.Rows.Add(CmbCategoriaCam2.SelectedItem, elemento, unidadeElemento, TxtEsforcoCam2.Text);
                TxtEsforcoCam2.Clear();
            }

        }

        private void BtnRemoverCam2_Click(object sender, EventArgs e)
        {
            DgvCaminho2.Rows.RemoveAt(DgvCaminho2.Rows.Count - 1);
        }


        // Método do caminho 3: combo box da categoria, botão de incluir e excluir  
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
            // preciso verificar se o nome do caminho e o esforço foi preenchido
            if (string.IsNullOrEmpty(TxtNomeCam3.Text) || string.IsNullOrEmpty(TxtEsforcoCam3.Text))
            {
                MessageBox.Show("Os campos nome do elemento e esforço do caminho 3 devem ser preenchidos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string elemento = new CtlCategoria(CmbElementoCam3.SelectedItem.ToString()).PegarNomeElemento();
                string unidadeElemento = new CtlCategoria(CmbElementoCam3.SelectedItem.ToString()).PegarValorElemento();
                DgvCaminho3.Rows.Add(CmbCategoriaCam2.SelectedItem, elemento, unidadeElemento, TxtEsforcoCam3.Text);
                TxtEsforcoCam3.Clear();
            }
        }

        private void BtnRemoverCam3_Click(object sender, EventArgs e)
        {
            DgvCaminho3.Rows.RemoveAt(DgvCaminho3.Rows.Count - 1);
        }


        // Metodo para calcular a emergia
        private void BtnCalculcar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtComponente.Text) ||
               (DgvCaminho1.Visible == true && DgvCaminho1.Rows.Count == 0) ||
               (DgvCaminho2.Visible == true && DgvCaminho2.Rows.Count == 0) ||
               (DgvCaminho3.Visible == true && DgvCaminho3.Rows.Count == 0))
            {
                MessageBox.Show("Para calcular é necessario informar o nome do componente a ser calculado e adicionar elementos as tabelas.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtComponente.Focus();
            }
            else
            {
                if (RbtDois.Checked)
                {
                    List<string[]> dadosCaminh01 = new List<string[]>();
                    dadosCaminh01 = this.PegarDadosCaminho(DgvCaminho1);
                    List<string[]> dadosCaminh02 = new List<string[]>();
                    dadosCaminh02 = this.PegarDadosCaminho(DgvCaminho2);
                    CtlCalculo ctlCalculo = new CtlCalculo(TxtNomeCam1.Text.Trim(), TxtNomeCam2.Text.Trim(), dadosCaminh01, dadosCaminh02);
                    double resutado = ctlCalculo.ControlarExecucaoCalculo();
                    MessageBox.Show($"Emergia total calculada para {TxtComponente.Text.Trim()}:\n" +
                                    $"Total em notação cietifica: {resutado.ToString("E2", CultureInfo.InvariantCulture)} seJ\n" +
                                    $"Total em valores numericos: {resutado.ToString("N2", CultureInfo.InvariantCulture)} seJ",
                                    "Calculo realizado com sucesso!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (RbtTres.Checked)
                {
                    List<string[]> dadosCaminh01 = new List<string[]>();
                    dadosCaminh01 = this.PegarDadosCaminho(DgvCaminho1);
                    List<string[]> dadosCaminh02 = new List<string[]>();
                    dadosCaminh02 = this.PegarDadosCaminho(DgvCaminho2);
                    List<string[]> dadosCaminh03 = new List<string[]>();
                    dadosCaminh03 = this.PegarDadosCaminho(DgvCaminho3);
                    CtlCalculo ctlCalculo = new CtlCalculo(TxtNomeCam1.Text.Trim(), TxtNomeCam2.Text.Trim(), TxtNomeCam3.Text.Trim(), dadosCaminh01, dadosCaminh02, dadosCaminh03);
                    double resutado = ctlCalculo.ControlarExecucaoCalculo();
                    MessageBox.Show($"Emergia total calculada para {TxtComponente.Text.Trim()}:\n" +
                                                    $"Total em notação cietifica: {resutado.ToString("E2", CultureInfo.InvariantCulture)} seJ\n" +
                                                    $"Total em valores numericos: {resutado.ToString("N2", CultureInfo.InvariantCulture)} seJ",
                                                    "Calculo realizado com sucesso!",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    List<string[]> dadosCaminh01 = new List<string[]>();
                    dadosCaminh01 = this.PegarDadosCaminho(DgvCaminho1);
                    CtlCalculo ctlCalculo = new CtlCalculo(TxtNomeCam1.Text.Trim(), dadosCaminh01);
                    double resutado = ctlCalculo.ControlarExecucaoCalculo();
                    MessageBox.Show($"Emergia total calculada para {TxtComponente.Text.Trim()}:\n" +
                                                    $"Total em notação cietifica: {resutado.ToString("E2", CultureInfo.InvariantCulture)} seJ\n" +
                                                    $"Total em valores numericos: {resutado.ToString("N2", CultureInfo.InvariantCulture)} seJ",
                                                    "Calculo realizado com sucesso!",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private List<string[]> PegarDadosCaminho(DataGridView dataGridView)
        {
            List<string[]> dadosCaminho = new List<string[]>();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    string[] valores = new string[4];
                    valores[0] = row.Cells[0].Value.ToString();
                    valores[1] = row.Cells[1].Value.ToString();
                    valores[2] = row.Cells[2].Value.ToString();
                    valores[3] = row.Cells[3].Value.ToString();

                    dadosCaminho.Add(valores);
                }
            }
            return dadosCaminho;
        }

        private void BtnLimparTudo_Click(object sender, EventArgs e)
        {
            TxtComponente.Clear();
            TxtNomeCam1.Clear();
            TxtEsforcoCam1.Clear();
            DgvCaminho1.Rows.Clear();
            this.RbtUm.Checked = true;
            TxtComponente.Focus();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Deseja encerrar o sistema?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sair == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnAjuda_Click(object sender, EventArgs e)
        {
            FmAjuda fmAjuda = new FmAjuda();
            fmAjuda.ShowDialog();
        }

        private void ObterAjudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BtnAjuda_Click(sender, e);
        }

        private void BtnEmergia_Click(object sender, EventArgs e)
        {
            FmEmergia fmEmergia = new FmEmergia();
            fmEmergia.ShowDialog();
        }
    }
}
