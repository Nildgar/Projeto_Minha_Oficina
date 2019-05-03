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
    public partial class Gestao_de_Clientes : Form
    {
        private String stdDetails = "{0,-30}{1,10}";
        public List<Cliente> ListaClienteAtualizada;
        public Gestao_de_Clientes(List<Cliente> ListaDosClientes)
        {
            InitializeComponent();
            ListaClienteAtualizada = ListaDosClientes;
        }

        private void Gestao_de_Clientes_Shown(object sender, EventArgs e)
        {
            ListBoxClientes.Items.Add("Nome:\r\t\t    NIF:");
            //ListBoxClientes.Items.Add(String.Format(stdDetails, "Nome", "NIF"));
            foreach (Cliente cliente in ListaClienteAtualizada)
            {
                ListBoxClientes.Items.Add(cliente);
                //ListBoxClientes.Items.Add(String.Format(stdDetails, cliente.Nome, cliente.Nif));
            }
            ListBoxClientes.SelectedIndex = 1;
        }

        private void ListBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxClientes.SelectedIndex == 0)
            {
                ListBoxClientes.SelectedIndex = 1;
            }
            Cliente ClienteSelecionado = (Cliente)ListBoxClientes.SelectedItem;
            TextBoxNome.Text = ClienteSelecionado.Nome;
            TextBoxMorada.Text = ClienteSelecionado.Morada;
            TextBoxNif.Text = Convert.ToString(ClienteSelecionado.Nif);
            TextBoxContacto.Text = Convert.ToString(ClienteSelecionado.Contacto);
        }

        private void ButtonPesquisa_Click(object sender, EventArgs e)
        {
            if (TextBoxFiltrar.Text != string.Empty) {
                int Num = 0, Index = 0;
                string Procura = TextBoxFiltrar.Text;
                foreach(Cliente cliente in ListaClienteAtualizada)
                {
                    Num++;
                    if (Convert.ToInt32(Procura) == cliente.Nif || String.Equals(Procura, cliente.Nome))
                    {
                        Index = Num;
                        break;
                    }
                }
                ListBoxClientes.SelectedIndex = Index;
                TextBoxFiltrar.Text = "";
            }
        }
    }
}
