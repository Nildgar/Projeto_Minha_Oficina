using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    public partial class CarroOficina : Carro
    {
        public CarroOficina(string matricula, decimal kms, string marca, string modelo, string numChassis, string combustivel)
        {
            this.Matricula = matricula;
            this.Modelo = modelo;
            this.Marca = marca;
            this.NumeroChassis = numChassis;
            this.Combustivel = combustivel;
            this.Kms = kms;
        }
        public decimal VerificaTotal()
        {
            decimal Total = 0;
            foreach(Servico servico in Servico)
            {
                Total = Total + servico.VerificaTotal();
            }
            return Total;
        }
        public override string ToString()
        {
            return Marca + " | " + Modelo + " (" + Matricula + ")";
        }
    }
}
