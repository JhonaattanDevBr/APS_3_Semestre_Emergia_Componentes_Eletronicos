namespace Calculadora.Model.Entidades
{
    public class CalculadoraEmergia
    {
        public double TotalEmergia { get; set; }
        public List<Caminho> Caminhos { get; set; } = new List<Caminho>();
        public Relatorio Relatorio { get; set; }

        public void AdicionarCaminho(Caminho caminho)
        {
            Caminhos.Add(caminho);
        }

        public double CalcularValorTotalCaminho()
        {
            foreach (Caminho caminho in Caminhos)
            {
                TotalEmergia += caminho.CalcularTotalEmergiaCaminho();
            }
            return TotalEmergia;
        }
    }
}
