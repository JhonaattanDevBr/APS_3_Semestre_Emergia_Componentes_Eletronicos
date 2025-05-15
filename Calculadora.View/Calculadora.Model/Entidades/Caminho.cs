using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Model.Entidades
{
    public class Caminho
    {
        public List<No> Nos { get; set; } = new List<No>();


        public void AdicionarNo(No no)
        {
            Nos.Add(no);
        }

        public double CalcularTotalEmergiaCaminho()
        {
            double totalEmergiaCaminho = 0;
            foreach (No no in Nos)
            {
                totalEmergiaCaminho += no.CalcularEmergiaDoNo();
            }
            return totalEmergiaCaminho;
        }
    }
}
