using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCensoPET.Util
{
    //Esta Classe cria a conexão com o Banco
    //Agora as informações sobre conexão estão dentro de uma única classe
    public class ConexaoBD
    {
        private MySqlConnection con;
        public ConexaoBD() 
        {
            //Conexao com o Banco de Dados
            string strconexao = "";
            //String de Conexao com o Banco de Dados
            strconexao = "server=localhost;userid=professor;password=professor@;database=bdcensopet";
            //Criação do Canal de Comunicação
            con = new MySqlConnection(strconexao);
        }

        public MySqlConnection RetornaConexao()
        {
            return this.con;
        }
    }
}
