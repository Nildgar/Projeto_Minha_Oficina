using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    public partial class Servico
    {
        public Servico(DateTime entrada, string tipo, DateTime saida)
        {
            this.DataEntrada = entrada;
            this.Tipo = tipo;
            this.DataSaida = saida;
        }
        public decimal VerificaTotal()
        {
            decimal Total = 0;
            foreach(Parcela parcela in Parcela)
            {
                Total = Total + parcela.Valor;
            }
            return Total;
        }
        public override string ToString()
        {
            return DataEntrada + " | " + VerificaTotal() + "€";
        }
    }
}
