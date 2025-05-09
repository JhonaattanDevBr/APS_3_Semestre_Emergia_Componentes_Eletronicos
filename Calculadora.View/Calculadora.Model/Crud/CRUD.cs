using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Model.Crud
{
    public abstract class CRUD
    {
        // Caminho da maquina
        //protected static string ConncetionString = @"Data Source=DESKTOP-AF6EDUF\SQLEXPRESSS;Initial Catalog=Lci_Teste;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        
        // Caminho do Notebook
        protected static string ConncetionString = @"Data Source=JHONATAN\SQLEXPRESS;Initial Catalog=Lci_Teste;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
    }
}
