using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Model.Entidades
{
    public class No
    {
        public string NomeElemento { get; private set; }
        public double ValorSej { get; private set; }
        public double Esforco { get; private set; }

        public No(string nomeElemento, double valorSej, double esforco)
        {
            NomeElemento = nomeElemento;
            ValorSej = valorSej;
            Esforco = esforco;
        }

        public double CalcularEmergiaDoNo() 
        {
            return Esforco * ValorSej;
        }
    }
}
