using Calculadora.Model.Crud;
using Calculadora.Controller.Controles.Excessoes;

namespace Calculadora.Controller.Controles
{
    public class CtlCategoria
    {
        public string ValorComboBox { get; set; }

        public CtlCategoria(string cmbValor) 
        {
            if (string.IsNullOrEmpty(cmbValor))
            {
                throw new ExcessoesDeControleComboBox("Erro, este campo deve ser preenchido"); // Talves eu não precise dessa validação
            }
            else if (cmbValor == "Materias Primas") // Verificação para mudar o valor recebido para o nome da tabela
            {
                cmbValor = cmbValor.Replace(' ', '_');
            }
            ValorComboBox = cmbValor;
        }

        public Dictionary<string, double> DicionarioDeComponentes()
        {
            CRUDComponentes componentes = new CRUDComponentes(ValorComboBox); // Criando o objeto de controle dos componentes
            Dictionary<string, double> dicionarioDeComponentes = componentes.CriarDicionarioDeComponentes(); // Chama o método e recebe um dicionario dos componentes
            return dicionarioDeComponentes;
        }
    }
}
