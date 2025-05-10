using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Model.Crud
{
    public class CRUDMateriaPrima : CRUD
    {
        public CRUDMateriaPrima(string nomeTabela) // Construtor da classe
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

                    Query = $"SELECT nome_materiaP, energia_embutida_sej_kg FROM {NomeTabela}"; // Criando a query
                    using (SqlCommand cmd = new SqlCommand(Query, sqlConnection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read()) // Faz a leitura da coluna
                            {
                                string nomeMateriaPrima = reader["nome_materiaP"].ToString(); // utiliza o ["nome_materiaP"] como indice na tabela
                                double energiaSejEmbutida = (double)reader["energia_embutida_sej_kg"];
                                dicionario.Add(nomeMateriaPrima, energiaSejEmbutida); // Adiciona os dados no dicionario
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
