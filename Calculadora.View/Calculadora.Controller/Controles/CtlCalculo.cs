using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora.Model.Entidades;

namespace Calculadora.Controller.Controles
{
    public class CtlCalculo
    {
        public string NomeCaminho1 { get; set; }
        public List<string[]> Caminho1 { get; set; }

        public string NomeCaminho2 { get; set; }
        public List<string[]> Caminho2 { get; set; }

        public string NomeCaminho3 { get; set; }
        public List<string[]> Caminho3 { get; set; }

        public double ValorTotalEmergia { get; set; }
        public List<List<string>> ElementosTabela { get; set; } = new List<List<string>>();

        public CtlCalculo(string nomeCaminho1, List<string[]> caminho1)
        {
            NomeCaminho1 = nomeCaminho1;
            Caminho1 = caminho1;
        }

        public CtlCalculo(string nomeCaminho1, string nomeCaminho2, List<string[]> caminho1, List<string[]> caminho2) : this(nomeCaminho1, caminho1)
        {
            NomeCaminho2 = nomeCaminho2;
            Caminho2 = caminho2;
        }

        public CtlCalculo(string nomeCaminho1, string nomeCaminho2, string nomeCaminho3,
               List<string[]> caminho1, List<string[]> caminho2, List<string[]> caminho3) : this(nomeCaminho1, nomeCaminho2, caminho1, caminho2)
        {
            NomeCaminho3 = nomeCaminho3;
            Caminho3 = caminho3;
        }

        public double ControlarExecucaoCalculo()
        {
            if (NomeCaminho3 != null)
            {
                Caminho caminho1 = CriarCaminho(Caminho1);
                Caminho caminho2 = CriarCaminho(Caminho2);
                Caminho caminho3 = CriarCaminho(Caminho3);
                CalculadoraEmergia calculadoraEmergia = new CalculadoraEmergia();
                calculadoraEmergia.AdicionarCaminho(caminho1);
                calculadoraEmergia.AdicionarCaminho(caminho2);
                calculadoraEmergia.AdicionarCaminho(caminho3);
                this.PegarElementosTabela(Caminho1);
                this.PegarElementosTabela(Caminho2);
                this.PegarElementosTabela(Caminho3);
                ValorTotalEmergia = calculadoraEmergia.CalcularValorTotalCaminho();
                return ValorTotalEmergia;
            }
            else if (NomeCaminho2 != null)
            {
                Caminho caminho1 = CriarCaminho(Caminho1);
                Caminho caminho2 = CriarCaminho(Caminho2);
                CalculadoraEmergia calculadoraEmergia = new CalculadoraEmergia();
                calculadoraEmergia.AdicionarCaminho(caminho1);
                calculadoraEmergia.AdicionarCaminho(caminho2);
                this.PegarElementosTabela(Caminho1);
                this.PegarElementosTabela(Caminho2);
                ValorTotalEmergia = calculadoraEmergia.CalcularValorTotalCaminho();
                return ValorTotalEmergia;
            }
            else
            {
                Caminho caminho1 = CriarCaminho(Caminho1);
                CalculadoraEmergia calculadoraEmergia = new CalculadoraEmergia();
                calculadoraEmergia.AdicionarCaminho(caminho1);
                this.PegarElementosTabela(Caminho1);
                ValorTotalEmergia = calculadoraEmergia.CalcularValorTotalCaminho();
                return ValorTotalEmergia;
            }
        }

        private Caminho CriarCaminho(List<string[]> caminho)
        {
            Caminho cam = new Caminho();
            foreach (var c in caminho)
            {
                string[] dadosDoCaminho = c;
                string nomeElemento = dadosDoCaminho[1];
                double valorSej = double.Parse(dadosDoCaminho[2]);
                double esforco = double.Parse(dadosDoCaminho[3]);
                No no = new No(nomeElemento, valorSej, esforco);
                cam.AdicionarNo(no);
            }
            return cam;
        }

        private void PegarElementosTabela(List<string[]> caminho)
        {
            foreach (var c in caminho)
            {
                List<string> dadosTabela = new List<string>();
                for (int i = 0; i < 1; i++)
                {
                    dadosTabela.Add(c[0]);
                    dadosTabela.Add(c[1]);
                    dadosTabela.Add(c[2]);
                    dadosTabela.Add(c[3]);
                    ElementosTabela.Add(dadosTabela);
                }
            }
        }

        public void CriarRelatorio(string nomeElemento)
        {
            string documentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Relatorio.CriarTabelaEmPdf(nomeElemento, ValorTotalEmergia, documentos + $"\\{nomeElemento}.pdf", ElementosTabela);
        }

    }
}
