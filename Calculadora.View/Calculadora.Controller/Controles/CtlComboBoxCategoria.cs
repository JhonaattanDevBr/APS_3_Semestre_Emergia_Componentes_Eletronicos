using Calculadora.Controller.Controles.Enumeracoes;
using Calculadora.Controller.Controles.Excessoes;

namespace Calculadora.Controller.Controles
{
    public class CtlComboBoxCategoria
    {
        public ValoresComboBox ValorComboBox { get; set; }
        public CtlComboBoxCategoria(string cmbValor) 
        {
            if (string.IsNullOrEmpty(cmbValor))
            {
                throw new ExcessoesDeControleComboBox("Erro, este campo deve ser preenchido");
            }
            ValorComboBox = Enum.Parse<ExcessoesDeControleComboBox>(cmbValor);
        }
    }
}
