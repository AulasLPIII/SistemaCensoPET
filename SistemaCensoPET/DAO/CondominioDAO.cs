using MySqlConnector;
using SistemaCensoPET.DTO;
using SistemaCensoPET.Util;
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

        private MySqlConnection con;
        private string? comandosql;//A interrogação indica que este atributo pode receber valores null
        private MySqlCommand? envelope;//Precisamos explicitar que isso pode acontecer
        private MySqlDataReader? cursor;

        public CondominioDAO()
        {
            ConexaoBD conexaobd = new ConexaoBD();
            this.con = conexaobd.RetornaConexao();
         
        }
        public int salvar(CondominioDTO condominiodto)
        {

            //O canal é criado fechado, para usarmos devemos abrí-lo
            con.Open();
            //Comando SQL (insert)
            comandosql = "insert into condominio (nome, endereco, numero, cep) values (@nome,@endereco,@numero,@cep)";
            //Criacao do objeto de comando (envelope)
            envelope = new MySqlCommand();
            //Indica ao envelope por qual canal de comunicacao ele será enviado
            envelope.Connection = con;
            //Coloca o comando SQL dentro do envelope
            envelope.CommandText = comandosql;
            //Neste ponto estamos dando ao parâmetro "@nome" o valor da Propriedade "Nome"
            envelope.Parameters.AddWithValue("@nome", condominiodto.Nome);
            //As três linhas abaixo (comentadas) fazem a mesma ação da unica linha acima
            //MySqlParameter parameter = new MySqlParameter();
            //parameter.ParameterName = "@nome";
            //parameter.Value = nome;
            //Neste ponto estamos dando ao parâmetro "@endereco" o valor da Propriedade "Endereco"
            envelope.Parameters.AddWithValue("@endereco", condominiodto.Endereco);
            //Neste ponto estamos dando ao parâmetro "@numero" o valor da Propriedade "Numero"
            envelope.Parameters.AddWithValue("@numero", condominiodto.Numero);
            //Neste ponto estamos dando ao parâmetro "@cep" o valor da Propriedade "Cep"
            envelope.Parameters.AddWithValue("@cep", condominiodto.Cep);
            //Cria uma versão preparada do comando em uma instância do SQL Server.
            envelope.Prepare();
            //Executa o comando SQL na instância apontada
            //Ele retorna um valor inteiro que representa a quantidade de linhas afetadas
            int retorno = envelope.ExecuteNonQuery();
            //Fechar o canal de comunicação
            con.Close();

            return retorno;
        }

        public List<CondominioDTO> ListarTodos()
        {
            //Criação da Lista que irá guardar objetos condominios
            List<CondominioDTO> listacond = new List<CondominioDTO>();

            //O canal é criado fechado, para usarmos devemos abrí-lo
            con.Open();
            //Comando SQL (SELECT)
            //Perceba que nosso comando não possui parâmetros
            comandosql = "select * from condominio";
            //Criacao do objeto de comando (envelope)
            envelope = new MySqlCommand();
            //Coloca o comando SQL dentro do envelope
            envelope.CommandText = comandosql;
            //Indica ao envelope por qual canal de comunicacao ele será enviado
            envelope.Connection = con;
            //Criação do nosso objeto cursor
            cursor = envelope.ExecuteReader();
            while (cursor.Read())
            {
                //Usamos o cursor para recuperar o conteúdo de cada coluna de uma linha de dados
                //Criação de um objeto condominio com dados do banco de dados
                CondominioDTO condominiodto = new CondominioDTO(cursor.GetInt32("idcondominio"), cursor.GetString("nome"), cursor.GetString("endereco"), cursor.GetInt32("numero"), cursor.GetString("cep"));
                //Adicionando objetos Condominios a Lista de Condominios
                //Desta forma todos os registros do banco de dados ficam
                //guardados dentro desta lista
                listacond.Add(condominiodto);
            }
            con.Close();
            return listacond;
        }
    }
}
