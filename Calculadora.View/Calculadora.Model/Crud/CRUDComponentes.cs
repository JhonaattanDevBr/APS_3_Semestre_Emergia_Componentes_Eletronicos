using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient; // Precisa instalar o pacote para funcionar, o System.data.SqlCliente esta obsoleto e foi trocado pelo Microsoft.Data.SqlCliente

namespace Calculadora.Model.Crud
{
    public class CRUDComponentes : CRUD // Vou utilizar interfaces aqui 
    {
        private string _nomeTabela;
        private string _query;

        public CRUDComponentes(string nomeTabela) // Construtor da classe
        {
            _nomeTabela = nomeTabela;
        }

        public Dictionary<string, double> CriarDicionarioDeComponentes()
        {
            try
            {
                Dictionary<string, double> dicionario = new Dictionary<string, double>(); // Cria um dicionario para retorno

                using (SqlConnection sqlConnection = new SqlConnection(ConncetionString)) // Criando a conexão com o BD
                {
                    sqlConnection.Open();

                    _query = $"SELECT nome_componente, massa_gramas FROM {_nomeTabela}"; // Criando a query
                    using (SqlCommand cmd = new SqlCommand(_query, sqlConnection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader()) 
                        {
                            while (reader.Read()) // Faz a leitura da coluna
                            {
                                string nomeComponente = reader["nome_componente"].ToString(); // utiliza o ["nome_componente"] como indice na tabela
                                double massaGramas = (double)reader["massa_gramas"];
                                dicionario.Add(nomeComponente, massaGramas); // Adiciona os dados no dicionario
                            }
                        }
                    }
                    return dicionario; // retorna o dicionario
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
