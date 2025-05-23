using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Layout.Properties;
using System.IO;
using System.Collections.Generic;
using System.Globalization;


namespace Calculadora.Model.Entidades
{
    public class Relatorio
    {
        //public string NomeRelatorio { get; set; }

        //public DateTime DataCriacao { get; set; }

        public static void CriarTabelaEmPdf(string nomeRelatorio, double valorTotalEmergia, string caminhoArquivo, List<List<string>> dadosTabela)
        {
            // Cria o writer e o documento PDF
            using (PdfWriter writer = new PdfWriter(caminhoArquivo))
            using (PdfDocument pdf = new PdfDocument(writer))
            using (Document documento = new Document(pdf))
            {
                // Fonte padrão
                PdfFont fonteNegrito = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
                PdfFont fonteNormal = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

                // Nome do relatório (no topo)
                Paragraph titulo = new Paragraph("Relatório de insumos para produção de: " + nomeRelatorio)
                    .SetFont(fonteNegrito)
                    .SetFontSize(18)
                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                    .SetMarginBottom(5);

                // Data atual (embaixo do título)
                string dataFormatada = DateTime.Now.ToString("D");
                Paragraph data = new Paragraph(dataFormatada)
                    .SetFont(fonteNormal)
                    .SetFontSize(12)
                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                    .SetMarginBottom(20);

                // Texto antes da tabela
                Paragraph textoAntes = new Paragraph(
                    $"Com base nos dados obtidos, foi realizado o cálculo do valor total de Emergia consumida na produção do produto {nomeRelatorio.ToUpper()}. " +
                    "Esse cálculo permite avaliar o impacto energético envolvido em cada etapa do processo produtivo, considerando os diferentes insumos e recursos utilizados. " +
                    "A tabela a seguir apresenta uma organização detalhada, na qual cada elemento é classificado em sua respectiva categoria. " +
                    "Além disso, a tabela especifica os valores de Unidade de Emergia por Joule (UEV) e Solar Emergy Joules (SEJ) correspondentes a cada componente. " +
                    "Dessa forma, é possível compreender a contribuição individual de cada elemento para o consumo total de Emergia, facilitando análises e tomadas de decisão mais fundamentadas.")
                    .SetFont(fonteNormal)
                    .SetFontSize(14)
                    .SetMarginBottom(10);

                // Adiciona os elementos na ordem correta
                documento.Add(titulo);
                documento.Add(data);
                documento.Add(textoAntes);

                // Cria uma tabela com 3 colunas
                Table tabela = new Table(5, true);

                // Cabeçalho da tabela
                tabela.AddHeaderCell(new Cell().Add(new Paragraph("Categoria").SetFont(fonteNegrito)));
                tabela.AddHeaderCell(new Cell().Add(new Paragraph("Elemento").SetFont(fonteNegrito)));
                tabela.AddHeaderCell(new Cell().Add(new Paragraph("Valor UEV").SetFont(fonteNegrito)));
                tabela.AddHeaderCell(new Cell().Add(new Paragraph("Valor Sej").SetFont(fonteNegrito)));
                tabela.AddHeaderCell(new Cell().Add(new Paragraph("Esfoco").SetFont(fonteNegrito)));

                foreach (var sublista in dadosTabela)
                {
                    if (sublista.Count >= 4)
                    {
                        double valorUev = double.Parse(sublista[2], CultureInfo.InvariantCulture);
                        double valorSej = valorUev + double.Parse(sublista[3], CultureInfo.InvariantCulture);

                        tabela.AddCell(sublista[0]);
                        tabela.AddCell(sublista[1]);
                        tabela.AddCell(valorUev.ToString("E2", CultureInfo.InvariantCulture));
                        tabela.AddCell(valorSej.ToString("E2", CultureInfo.InvariantCulture));
                        tabela.AddCell(sublista[3]);
                    }
                }

                documento.Add(tabela); // Adiciona a tabela ao documento

                // Depois da tabela, adiciona o total em formato científico
                Paragraph totalCientifico = new Paragraph("Valor Total (científico): " + valorTotalEmergia.ToString("E2", CultureInfo.InvariantCulture))
                    .SetFont(fonteNegrito)
                    .SetFontSize(12)
                    .SetMarginTop(20);

                // Total em formato numérico simples
                Paragraph totalNumerico = new Paragraph("Valor Total (numérico): " + valorTotalEmergia.ToString("N2", CultureInfo.InvariantCulture))
                    .SetFont(fonteNegrito)
                    .SetFontSize(12);

                documento.Add(totalCientifico);
                documento.Add(totalNumerico);
            }
        }
    }
}
