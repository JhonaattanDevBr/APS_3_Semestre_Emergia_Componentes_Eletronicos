using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Model.Crud.Interface
{
    interface ICRUD
    {
        public abstract Dictionary<string, double> CriarDicionario();
    }
}
