using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Calculadora.View.Interfaces
{
    public partial class FmAjuda : Form
    {
        List<System.Drawing.Image> imagens;
        int indice = 0;

        public FmAjuda()
        {
            InitializeComponent();
            imagens = new List<System.Drawing.Image>
            {
                Properties.Resources.Ajuda_Texto,
                Properties.Resources.Ajuda_Ciclo
            };
        }

        private void FmAjuda_Load(object sender, EventArgs e)
        {
            PbImagemAjuda.SizeMode = PictureBoxSizeMode.StretchImage;
            PbImagemAjuda.Image = imagens[indice];
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            if (indice < imagens.Count - 1)
            {
                indice++;
                PbImagemAjuda.Image = imagens[indice];
            }
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            if (indice > 0)
            {
                indice--;
                PbImagemAjuda.Image = imagens[indice];
            }
        }
    }
}
