using GerenciadoEmpresaX.Conexao;
using GerenciadoEmpresaX.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GerenciadoEmpresaX.Repository
{
    public class ClienteRepository
    {
        private readonly SqlConnection Connection = new ConectBd().GetConnection();


        #region  CadastrarCliente
        public void CadastraCliente(Cliente cliente)
        {
            try
            {
                var command = Connection.CreateCommand();
                command.CommandText = @"INSERT INTO Clientes (Nome, Endereco, Telefone, Email) VALUES (@Nome, @Endereco, @Telefone, @Email)";
                command.Parameters.AddWithValue("@Nome", cliente.Nome);
                command.Parameters.AddWithValue("@Endereco", cliente.Endereco);
                command.Parameters.AddWithValue("@Telefone", cliente.Telefone);
                command.Parameters.AddWithValue("@Email", cliente.Email);
                Connection.Open();
                command.ExecuteNonQuery();
                Connection.Close();
                MessageBox.Show("Cadastro realizado com succeso!");
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao cadastra cliente!");
            }
        }
        #endregion

        #region ListarClientes
        public DataTable ListarClientes()
        {
            try
            {
                SqlDataAdapter tabelaCliente = new SqlDataAdapter("select * from Clientes", Connection);
                DataTable dados = new DataTable();
                tabelaCliente.Fill(dados);
                Connection.Close();
                return dados;
            }
            catch (Exception erro)
            {

                MessageBox.Show($"Erro ao exucutar o comando sql ,{erro}");
                return null;
            }
        }
        #endregion
    }
}
