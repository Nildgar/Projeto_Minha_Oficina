using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    public partial class Parcela
    {
        public Parcela(string descricao, decimal valor)
        {
            this.Descricao = descricao;
            this.Valor = valor;
        }
        public override string ToString()
        {
            return Descricao + " " + Valor + "€";
        }
    }
}
