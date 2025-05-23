using Calculadora.Controller.Controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora.View.Interfaces
{
    public partial class FmResultado : Form
    {
        public FmResultado(string nomeElemento, double resutado, CtlCalculo ctlCalculo)
        {
            InitializeComponent();
            LblElementoCalculado.Text = nomeElemento;
            LblResultadoCientifico.Text = $"{resutado.ToString("E2", CultureInfo.InvariantCulture)} seJ";
            LblResultadoNumerico.Text = $"{resutado.ToString("N2", CultureInfo.InvariantCulture)} seJ";
            ctlCalculo.CriarRelatorio(nomeElemento);
            LblRelatorio.Text = nomeElemento;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
