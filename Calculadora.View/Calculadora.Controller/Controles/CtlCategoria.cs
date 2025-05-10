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

        public Dictionary<string, double> SelecionarConsulta()
        {
            Dictionary<string, double> dicionario =  new Dictionary<string, double>();
            if (ValorComboBox == "Componentes")
            {
                dicionario =  this.DicionarioDeComponentes();
            }
            else if (ValorComboBox == "Materias_Primas")
            {
                dicionario = this.DicionarioDeMateriasPrimas();
            }
            else if (ValorComboBox == "Processos")
            {
                dicionario = this.DicionarioDeProcessos();
            }
            else
            {
                dicionario = this.DicionarioDeProdutos();
            }
                return dicionario;
        }

        private Dictionary<string, double> DicionarioDeComponentes()
        {
            CRUDComponente crudComponente = new CRUDComponente(ValorComboBox); // Criando o objeto de controle dos componentes
            Dictionary<string, double> dicionarioDeComponentes = crudComponente.CriarDicionario(); // Chama o método e recebe um dicionario dos componentes
            return dicionarioDeComponentes;
        }
        
        private Dictionary<string, double> DicionarioDeMateriasPrimas()
        {
            CRUDMateriaPrima crudMateriaPrima = new CRUDMateriaPrima(ValorComboBox); // Criando o objeto de controle dos componentes
            Dictionary<string, double> dicionarioDeMateriasPrimas = crudMateriaPrima.CriarDicionario(); // Chama o método e recebe um dicionario dos componentes
            return dicionarioDeMateriasPrimas;
        }
        
        private Dictionary<string, double> DicionarioDeProcessos()
        {
            CRUDProcesso crudProcesso = new CRUDProcesso(ValorComboBox); // Criando o objeto de controle dos componentes
            Dictionary<string, double> dicionarioDeProcessos = crudProcesso.CriarDicionario(); // Chama o método e recebe um dicionario dos componentes
            return dicionarioDeProcessos;
        }
        
        private Dictionary<string, double> DicionarioDeProdutos()
        {
            CRUDProduto crudProduto = new CRUDProduto(ValorComboBox); // Criando o objeto de controle dos componentes
            Dictionary<string, double> dicionarioDeProdutos = crudProduto.CriarDicionario(); // Chama o método e recebe um dicionario dos componentes
            return dicionarioDeProdutos;
        }
    }
}
