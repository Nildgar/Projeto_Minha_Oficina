using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    public partial class Cliente
    {
        private int soOficina = 1, soAluguer = 2, soVenda = 3, Tudo = 4;
        public Cliente(string PrimeiroNome, string UltimoNome, string morada, int nif, int contacto)
        {
            this.Nome = string.Concat(PrimeiroNome, " ", UltimoNome);
            this.Nif = nif;
            this.Morada = morada;
            this.Contacto = contacto;
        }
        public decimal VerificaTotal(int TipoVerificacao)
        {
            decimal Total = 0;
            if (TipoVerificacao == soOficina || TipoVerificacao == Tudo)
            {
                foreach (CarroOficina carroOficina in CarroOficina)
                {
                    Total = Total + carroOficina.VerificaTotal();
                }
            }
            /*if (TipoVerificacao == soAluguer || TipoVerificacao == Tudo)
            {
                foreach (Aluguer aluguer in Aluguer)
                {
                    Total = Total + aluguer.VerificaTotal();
                }
            }
            if (TipoVerificacao == soVenda || TipoVerificacao == Tudo)
            {
                foreach (Venda venda in Venda)
                {
                    Total = Total + venda.VerificaTotal();
                }
            }*/
            return Total;
        }

        public override string ToString()
        {
            return Nome + "\r\t    " + Nif;
        }
    }
}
