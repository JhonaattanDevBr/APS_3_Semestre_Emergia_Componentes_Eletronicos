namespace Calculadora.Model.Entidades
{
    public class Calculadora
    {
        public double TotalEmergia { get; set; }
        public List<Caminho> Caminhos { get; set; } = new List<Caminho>();
        public Relatorio Relatorio { get; set; }
    }
}
