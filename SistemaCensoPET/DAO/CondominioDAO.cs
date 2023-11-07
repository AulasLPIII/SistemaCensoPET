using MySqlConnector;
using SistemaCensoPET.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCensoPET.DAO
{
    public class CondominioDAO
    {

        public void salvar(CondominioDTO condominiodto)
        {
            //Conexao com o Banco de Dados
            string strconexao = "";
            //String de Conexao com o Banco de Dados
            strconexao = "server=localhost;userid=professor;password=professor@;database=bdcensopet";
            //Criação do Canal de Comunicação
            MySqlConnection con = new MySqlConnection(strconexao);
            //O canal é criado fechado, para usarmos devemos abrí-lo
            con.Open();
            //Comando SQL (insert)
            string comandosql = "insert into condominio (nome, endereco, numero, cep) values (@nome,@endereco,@numero,@cep)";
            //Criacao do objeto de comando (envelope)
            MySqlCommand envelope = new MySqlCommand();
            //Indica ao envelope por qual canal de comunicacao ele será enviado
            envelope.Connection = con;
            //Coloca o comando SQL dentro do envelope
            envelope.CommandText = comandosql;
            //Neste ponto estamos dando ao parâmetro "@nome" o valor da variável "nome"
            envelope.Parameters.AddWithValue("@nome", condominiodto.Nome);
            //As três linhas abaixo (comentadas) fazem a mesma ação da unica linha acima
            //MySqlParameter parameter = new MySqlParameter();
            //parameter.ParameterName = "@nome";
            //parameter.Value = nome;
            //Neste ponto estamos dando ao parâmetro "@endereco" o valor da variável "endereco"
            envelope.Parameters.AddWithValue("@endereco", condominiodto.Endereco);
            //Neste ponto estamos dando ao parâmetro "@numero" o valor da variável "numero_num"
            envelope.Parameters.AddWithValue("@numero", condominiodto.Numero);
            //Neste ponto estamos dando ao parâmetro "@cep" o valor da variável "cep"
            envelope.Parameters.AddWithValue("@cep", condominiodto.Cep);
            //Cria uma versão preparada do comando em uma instância do SQL Server.
            envelope.Prepare();
            //Executa o comando SQL na instância apontada
            //Ele retorna um valor inteiro que representa a quantidade de linhas afetadas
            int retorno = envelope.ExecuteNonQuery();
        }
    }
}
