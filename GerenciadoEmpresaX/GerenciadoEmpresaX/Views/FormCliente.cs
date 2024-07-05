using GerenciadoEmpresaX.Model;
using GerenciadoEmpresaX.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadoEmpresaX
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.Email = txtEmail.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.Endereco = txtEndereco.Text;
            ClienteRepository repository = new ClienteRepository();
            repository.CadastraCliente(cliente);
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            ClienteRepository cliente = new ClienteRepository();
            TabelaClientes.DataSource = cliente.ListarClientes();
        }
    }
}
