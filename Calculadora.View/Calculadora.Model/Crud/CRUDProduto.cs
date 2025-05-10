using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Model.Crud
{
    public class CRUDProduto : CRUD
    {
        public CRUDProduto(string nomeTabela) // Construtor da classe
        {
            NomeTabela = nomeTabela;
        }

        public override Dictionary<string, double> CriarDicionario()
        {
            try
            {
                Dictionary<string, double> dicionario = new Dictionary<string, double>(); // Cria um dicionario para retorno

                using (SqlConnection sqlConnection = new SqlConnection(ConncetionString)) // Criando a conexão com o BD
                {
                    sqlConnection.Open();

                    Query = $"SELECT nome_produto, massa_total_gramas FROM {NomeTabela}"; // Criando a query
                    using (SqlCommand cmd = new SqlCommand(Query, sqlConnection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read()) // Faz a leitura da coluna
                            {
                                string nomeProduto = reader["nome_produto"].ToString(); // utiliza o ["nome_componente"] como indice na tabela
                                double massaTotalGramas = (double)reader["massa_total_gramas"];
                                dicionario.Add(nomeProduto, massaTotalGramas); // Adiciona os dados no dicionario
                            }
                        }
                    }
                    return dicionario; // retorna o dicionario
                }
            }
            catch (Exception)
            {
                throw; // vou ver o que vou fazer com isso
            }
        }
    }
}
