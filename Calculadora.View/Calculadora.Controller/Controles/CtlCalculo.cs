using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Controller.Controles
{
    public class CtlCalculo
    {
        public List<Dictionary<double, string>> ValuePairs { get; set; } = new List<Dictionary<double, string>>();

        public List<string[]> Caminho1 { get; set; }
        public List<string[]> Caminho2 { get; set; }
        public List<string[]> Caminho3 { get; set; }

        public CtlCalculo(List<string[]> caminho1)
        {
            Caminho1 = caminho1;
        }

        public CtlCalculo(List<string[]> caminho1, List<string[]> caminho2) : this(caminho1)
        {
            Caminho2 = caminho2;
        }

        public CtlCalculo(List<string[]> caminho1, List<string[]> caminho2, List<string[]> caminho3) : this(caminho1, caminho2)
        {
            Caminho3 = caminho3;
        }
    }
}
