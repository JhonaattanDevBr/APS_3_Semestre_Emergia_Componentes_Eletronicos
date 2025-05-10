using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient; // Precisa instalar o pacote para funcionar, o System.data.SqlCliente esta obsoleto e foi trocado pelo Microsoft.Data.SqlCliente

namespace Calculadora.Model.Crud
{
    public class CRUDComponente : CRUD // Vou utilizar interfaces aqui 
    {
        public CRUDComponente(string nomeTabela) // Construtor da classe
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

                    Query = $"SELECT nome_componente, massa_gramas FROM {NomeTabela}"; // Criando a query
                    using (SqlCommand cmd = new SqlCommand(Query, sqlConnection))
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
                throw; // vou ver o que vou fazer com isso
            }
        }
    }
}
