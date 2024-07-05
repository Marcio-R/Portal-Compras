using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadoEmpresaX.Conexao
{
    public class ConectBd
    {
        public SqlConnection GetConnection()
        {
            string conexao = ConfigurationManager.ConnectionStrings["BDEmpresaX"].ConnectionString;
            return new SqlConnection(conexao);
        }
    }
}
