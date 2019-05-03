using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class Inicio : Form
    {
        public List<Cliente> ListaClientes = new List<Cliente>();
        public Inicio()
        {
            InitializeComponent();
            Cliente cliente = new Cliente("Edgar", "Cordeiro", "Texugueira", 123456789, 919245453);
            ListaClientes.Add(cliente);
            Cliente cliente2 = new Cliente("Neuza", "Cordeiro", "Texugueira", 987654321, 919434344);
            ListaClientes.Add(cliente2);
        }

        private void ButtonGestaoClientes_Click(object sender, EventArgs e)
        {
            Gestao_de_Clientes NovaGestaoCliente = new Gestao_de_Clientes(ListaClientes);
            NovaGestaoCliente.ShowDialog();
            ListaClientes.Clear();
            ListaClientes = NovaGestaoCliente.ListaClienteAtualizada;
        }
    }
}
